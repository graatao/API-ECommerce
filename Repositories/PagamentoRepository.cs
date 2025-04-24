using API_ECommerce.Context;
using API_ECommerce.Interfaces;
using API_ECommerce.Models;

namespace API_ECommerce.Repositories
{
    public class PagamentoRepository : IPagamentoRepository
    {
        private readonly EcommerceContext _context;
        public PagamentoRepository(EcommerceContext context)
        {
            _context = context;
        }

        public void Atualizar(Pagamento pagamento)
        {
            Pagamento pagamentoEncontrado = _context.Pagamentos.Find(pagamento.IdPagamento);
            if (pagamentoEncontrado == null)
            {
                throw new Exception("Pagamento não encontrado");
            }
            pagamentoEncontrado.FormaPagamento = pagamento.FormaPagamento;
            pagamentoEncontrado.Status = pagamento.Status;
            
            
            _context.SaveChanges();


        }

        public void Cadastrar(Pagamento pagamento)
        {
            Pagamento pagamentoCadastro = new Pagamento();
            {
                pagamentoCadastro.FormaPagamento = pagamento.FormaPagamento;
                pagamentoCadastro.Status = pagamento.Status;
            }
            _context.Pagamentos.Add(pagamentoCadastro);
            _context.SaveChanges();


            
        }

        public void Deletar(int id)
        {
            Pagamento pagamentoEncontrado = _context.Pagamentos.Find(id);
            if (pagamentoEncontrado == null)
            {
                throw new Exception("Pagamento não encontrado");
            }
            _context.Pagamentos.Remove(pagamentoEncontrado);
            _context.SaveChanges();
            throw new NotImplementedException();
        }

        public Pagamento ListarPorId(int id)
        {
            Pagamento pagamentoEncontrado = _context.Pagamentos.Find(id);
            if (pagamentoEncontrado == null)
            {
                throw new Exception("Pagamento não encontrado");
            }
            return pagamentoEncontrado;

            throw new NotImplementedException();
        }

        public List<Pagamento> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
 
