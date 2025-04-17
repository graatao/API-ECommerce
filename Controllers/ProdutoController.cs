using API_ECommerce.Context;
using API_ECommerce.Interfaces;
using API_ECommerce.Models;
using API_ECommerce.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace API_ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
       
        public ProdutoController(IProdutoRepository produtoRepository)
        {
         
            _produtoRepository = produtoRepository;
        }

        private IProdutoRepository _produtoRepository;
        [HttpGet]
        public IActionResult ListarProdutos()
        {
            return Ok(_produtoRepository.ListarTodos());
        }

        [HttpPost]
        public IActionResult CadastrarProduto(Models.Produto produto)
        {
            _produtoRepository.Cadastrar(produto);
        
       return Ok("Produto cadastrado com sucesso!");
        }


        [HttpGet("{id}")]
        public IActionResult ListarProdutoPorId(int id)
        {
            Produto produto = _produtoRepository.ListarPorId(id);
            if (produto == null)
            {
                return NotFound("Produto não encontrado");
            }
            return Ok(produto);
        }


        [HttpDelete("{id}")]

     public IActionResult DeletarProduto(int id)
        {
            try
            {
                _produtoRepository.Deletar(id);
                return Ok("Produto deletado com sucesso!");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPut("{id}")]
        public IActionResult AtualizarProduto(int id, Models.Produto produto)
        {
            try
            {
                produto.IdProduto = id;
                _produtoRepository.Atualizar(produto);
                return Ok("Produto atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }

}





