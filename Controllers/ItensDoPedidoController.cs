using API_ECommerce.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItensDoPedidoController : ControllerBase
    {
        private readonly EcommerceContext _context;
        public ItensDoPedidoRepository ItensDoPedidoRepository;
        public ItensDoPedidoController(EcommerceContext context)
        {
            _context = context;
            ItensDoPedidoRepository = new ItensDoPedidoRepository(_context);
        }

    }
}
