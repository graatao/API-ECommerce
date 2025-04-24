namespace API_ECommerce.DTO
{
    public class CadastrarPagamentoDto
    {
        public string Nome { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string NumeroCartao { get; set; } = null!;
        public string NomeTitular { get; set; } = null!;
        public DateTime DataValidade { get; set; }
        public int CVV { get; set; }
        public bool Ativo { get; set; }
    }
}
