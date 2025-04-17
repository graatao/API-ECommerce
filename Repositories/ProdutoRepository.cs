using API_ECommerce.Context;
using API_ECommerce.Interfaces;
using API_ECommerce.Models;

namespace API_ECommerce.Repositories
{
    public class ProdutoRepository : IProdutoRepository


    {
        private readonly EcommerceContext _context;
        public ProdutoRepository(EcommerceContext context)
        {
            _context = context;
        }

        public void Atualizar(Produto produto)
        {
            Produto produtoEncontrado = _ = _context.Produtos.Find(produto.IdProduto);
            if (produtoEncontrado == null)
            {
                throw new Exception("Produto não encontrado");
            }
            produtoEncontrado.Nome = produto.Nome;
            produtoEncontrado.Preco = produto.Preco;
            produtoEncontrado.Descricao = produto.Descricao;
            produtoEncontrado.EstoqueDisponivel = produto.EstoqueDisponivel;
            produtoEncontrado.Categoria = produto.Categoria;
            produtoEncontrado.Imagem = produto.Imagem;
            _context.Produtos.Update(produtoEncontrado);
        }
        public Produto BuscarPorId(int id)
        {
            return _context.Produtos.FirstOrDefault(p => p.IdProduto == id);

        }
        public void Cadastrar(Produto produto)
        {
            _context.Produtos.Add(produto);
        }

        public void Deletar(int id)
        {
            Produto produtoEncontrado = _context.Produtos.Find(id);
            if(produtoEncontrado == null)
            {
                throw new Exception("Produto não encontrado");
            }
            _context.Produtos.Remove(produtoEncontrado);
            _context.SaveChanges();
        }

        public Produto ListarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Produto> ListarTodos()
        {
            return _context.Produtos.ToList();
        }
    }
}
