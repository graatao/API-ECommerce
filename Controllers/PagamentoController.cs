using API_ECommerce.Context;
using API_ECommerce.Models;
using API_ECommerce.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoController : ControllerBase
    {
        private readonly EcommerceContext _context;
        public PagamentoRepository PagamentoRepository;

        public PagamentoController(EcommerceContext context)
        {
            _context = context;
            PagamentoRepository = new PagamentoRepository(_context);
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
