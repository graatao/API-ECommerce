using API_ECommerce.Context;

namespace API_ECommerce.Interfaces
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