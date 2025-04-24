using API_ECommerce.Context;
using API_ECommerce.Interfaces;
using API_ECommerce.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        private IClienteRepository _clienteRepository;

        [HttpGet]
        public IActionResult ListarClientes()
        {
            return Ok(ClienteRepository.ListarTodos());
        }


    
        [HttpPost]
        public IActionResult CadastrarCliente(Models.Cliente cliente)
        {
            ClienteRepository.Cadastrar(cliente);
            return Ok("Cliente cadastrado com sucesso!");
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


            [HttpGet("buscar/{nome}")]
            public IActionResult BuscarClientePorNome(string nome)
            {
                Models.Cliente cliente = ClienteRepository.BuscarPorNome(nome);
                if (cliente == null)
                {
                    return NotFound("Cliente não encontrado");
                }
                return Ok(cliente);
            }

        }
    }
}



