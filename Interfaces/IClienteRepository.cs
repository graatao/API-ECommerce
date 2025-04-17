using API_ECommerce.Models;

namespace API_ECommerce.Interfaces
{
    public interface IClienteRepository
    {
        List<Cliente> ListarTodos();
        //recebe um identificador e retorna o cliente correspondente
        Cliente ListarPorId(int id);
        //Create (CADASTRAR)
        void Cadastrar(Cliente cliente);
        //Update (ATUALIZAR)
        //Recebe um identificador para encontrar o Cliente e recebe o Cliente Novo para substituir o antigo
        void Atualizar(Cliente cliente);
        //Delete (DELETAR)
        //Recebe um identificador para encontrar o Cliente e o deleta
        void Deletar(int id);
    
    }
}

