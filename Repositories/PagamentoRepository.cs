using API_ECommerce.Interfaces;

namespace API_ECommerce.Repositories
{
    public class PagamentoRepository : Interfaces.IPagamentoRepository
    {
        public PagamentoRepository(Context.EcommerceContext _context) { }
        public void Cadastrar(Pagamento pagamento)
        {
            // Implementar a lógica para cadastrar um pagamento
            // Exemplo: salvar no banco de dados
        }
        public void Atualizar(Pagamento pagamento)
        {
            // Implementar a lógica para atualizar um pagamento
            // Exemplo: atualizar no banco de dados
        }
        public void Deletar(int id)
        {
            // Implementar a lógica para deletar um pagamento
            // Exemplo: remover do banco de dados
        }
        public Pagamento ListarPorId(int id)
        {
            // Implementar a lógica para listar um pagamento por ID
            // Exemplo: buscar no banco de dados
            return new Pagamento(); // Retornar um objeto de pagamento fictício
        }
        public List<Pagamento> ListarTodos()
        {
            // Implementar a lógica para listar todos os pagamentos
            // Exemplo: buscar no banco de dados
            return new List<Pagamento>(); // Retornar uma lista fictícia de pagamentos
        }

        List<Models.Pagamento> IPagamentoRepository.ListarTodos()
        {
            throw new NotImplementedException();
        }

        Models.Pagamento IPagamentoRepository.ListarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Models.Pagamento pagamento)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Models.Pagamento pagamento)
        {
            throw new NotImplementedException();
        }
    }
}
