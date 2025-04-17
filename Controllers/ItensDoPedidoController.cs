using API_ECommerce.Context;
using API_ECommerce.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItensDoPedidoController : ControllerBase
    {
        
        public ItensDoPedidoRepository ItensDoPedidoRepository;
        public ItensDoPedidoController(ItensDoPedidoRepository itens)
        {
           
           
            ItensDoPedidoRepository = itens;
        }

    }
}
