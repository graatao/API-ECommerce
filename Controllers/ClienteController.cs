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


    }
}



