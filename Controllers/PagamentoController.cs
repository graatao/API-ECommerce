using API_ECommerce.Context;
using API_ECommerce.Models;
using API_ECommerce.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pagamento = API_ECommerce.Models.Pagamento;

namespace API_ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoController : ControllerBase
    {

        public PagamentoRepository PagamentoRepository;

        public PagamentoController(PagamentoRepository pagamentoRepository)
        {

            PagamentoRepository = pagamentoRepository;
        }

        [HttpGet]
        public IActionResult ListarPagamentos()
        {
            return Ok(PagamentoRepository.ListarTodos());
        }

        [HttpPost]
        public IActionResult CadastrarPagamento(Pagamento pagamento)
        {
            PagamentoRepository.Cadastrar(pagamento);
            return Ok("Pagamento cadastrado com sucesso!");
        }
    
    [HttpGet("{id}")]
        public IActionResult ListarPagamentoPorId(int id)
        {
            Pagamento pagamento = PagamentoRepository.ListarPorId(id);
            if (pagamento == null)
            {
                return NotFound("Pagamento não encontrado");
            }
            return Ok(pagamento);
        }
        [HttpDelete("{id}")]
        public IActionResult DeletarPagamento(int id)
        {
            try
            {
                PagamentoRepository.Deletar(id);
                return Ok("Pagamento deletado com sucesso!");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

    }
}
