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
        public void Atualizar(Models.Cliente cliente)
        {
            Models.Cliente cliente1 = _context.Clientes.Find(cliente.IdCliente);
            if (cliente1 == null)
            {
                throw new Exception("Cliente não encontrado");
            }
            cliente1.Nome = cliente.Nome;
            cliente1.Email = cliente.Email;
            cliente1.Telefone = cliente.Telefone;
            cliente1.Endereco = cliente.Endereco;
            cliente1.DataCadastro = cliente.DataCadastro;
            _context.Clientes.Update(cliente1);
            _context.SaveChanges();

            throw new NotImplementedException();
        }

        public void Cadastrar(Models.Cliente cliente)
        {

            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }
        public void Deletar(int id)
        {

            throw new NotImplementedException();
        }
        public Models.Cliente ListarPorId(int id)
        {
            
            throw new NotImplementedException();
        }
        public List<Models.Cliente> ListarTodos()
        {
            return _context.Clientes.ToList();
        }

    }
}