using API_ECommerce.Context;
using API_ECommerce.Interfaces;
using API_ECommerce.Models;
using API_ECommerce.Repositories;

using API_ECommerce.Services;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        public ClienteRepository ClienteRepository;

        public ClienteController(ClienteRepository clienteRepository)
        {

            ClienteRepository = clienteRepository;
        }

        private IClienteRepository clienteRepository;

        private readonly PasswordService _passwordService = new PasswordService();


        [HttpGet]
        public IActionResult ListarClientes()
        {
            return Ok(ClienteRepository.ListarTodos());
        }

        [HttpGet("{id}")]
        public IActionResult ListarClientePorId(int id)
        {
            Models.Cliente cliente = ClienteRepository.ListarPorId(id);
            if (cliente == null)
            {
                return NotFound("Cliente não encontrado");
            }
            return Ok(cliente);
        }
        [HttpDelete("{id}")]
        public IActionResult DeletarCliente(int id)
        {
            try
            {
                ClienteRepository.Deletar(id);
                return Ok("Cliente deletado com sucesso!");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }

        [HttpGet("buscar/{nome}")]
        private static IActionResult BuscarClientePorNome(ClienteController @this, string nome)
        {
            Models.Cliente cliente = @this.ClienteRepository.BuscarPorNome(nome);
            if (cliente == null)
            {
                return @this.NotFound("Cliente não encontrado");
            }
            return @this.Ok(cliente);
        }
        [HttpPost]
        public IActionResult CadastrarCliente(Cliente cliente)
        {
            cliente.Senha = _passwordService.HashPassword(cliente);
            clienteRepository.Cadastrar(cliente);
            return CreatedAtAction(nameof(BuscarClientePorNome), new { id = cliente.IdCliente }, cliente);

    }

    }
}

