using API_ECommerce.Controllers;
using API_ECommerce.Models;

namespace API_ECommerce.Interfaces
{
    public interface IProdutoRepository
    {
        List<Produto> ListarTodos();
        //recebe um identificador e retorna o produto correspondente
        Produto ListarPorId(int id);
        //Create (CADASTRAR)
        void Cadastrar(Produto produto);
        //Update (ATUALIZAR)
        //Recebe um identificador para encontrar o Produto e recebe o Produto Novo para substituir o antigo
        void Atualizar(Produto produto);
        //Delete (DELETAR)
        //Recebe um identificador para encontrar o Produto e o deleta
        void Deletar(int id);
        
    }
}
