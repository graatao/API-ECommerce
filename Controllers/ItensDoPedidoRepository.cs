using API_ECommerce.Context;

namespace API_ECommerce.Controllers
{
    public class ItensDoPedidoRepository
    {
        public ItensDoPedidoRepository(EcommerceContext context)
        {
            Context = context;
        }

        public EcommerceContext Context { get; }
    }
}