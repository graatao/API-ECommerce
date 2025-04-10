using API_ECommerce.Models;

namespace API_ECommerce.Interfaces
{
    public interface IPagamentoRepository 
    {
        List<Pagamento> ListarTodos();
        //recebe um identificador e retorna o pagamento correspondente
        Pagamento ListarPorId(int id);
        //Create (CADASTRAR)
        void Cadastrar(Pagamento pagamento);
        //Update (ATUALIZAR)
        //Recebe um identificador para encontrar o Pagamento e recebe o Pagamento Novo para substituir o antigo
        void Atualizar(Pagamento pagamento);
        //Delete (DELETAR)
        //Recebe um identificador para encontrar o Pagamento e o deleta
        void Deletar(int id);
    }
}
