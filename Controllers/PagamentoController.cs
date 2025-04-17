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

        public PagamentoController(PagamentoRepository pagamentoRepository )
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
    }

}
