using API_ECommerce.Context;
using API_ECommerce.Interfaces;
using API_ECommerce.Models;

namespace API_ECommerce.Repositories
{
    public class ClienteRepository : Interfaces.IClienteRepository
    {
        private readonly EcommerceContext _context;
        public ClienteRepository(EcommerceContext context)
        {
            _context = context;
        }
        public void Atualizar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }
        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }
        public Cliente ListarPorId(int id)
        {
            throw new NotImplementedException();
        }
        public List<Cliente> ListarTodos()
        {
            return _context.Clientes.ToList();
        }

    }
}