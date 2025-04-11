using API_ECommerce.Context;
using API_ECommerce.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly EcommerceContext _context;
        public ClienteRepository ClienteRepository;

        public ClienteController(EcommerceContext context)
        {
            _context = context;
            ClienteRepository = new ClienteRepository(_context);
        }



        [HttpGet]
        public IActionResult ListarClientes()
        {
            return Ok(ClienteRepository.ListarTodos());
        }


    }
}

