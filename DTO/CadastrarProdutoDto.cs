namespace API_ECommerce.DTO
{
    public class CadastrarProdutoDto
    {
        public string Nome { get; set; } = null!;
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public string Imagem { get; set; }
        public string Categoria { get; set; } = null!;
        public int FornecedorId { get; set; }
    }
}
