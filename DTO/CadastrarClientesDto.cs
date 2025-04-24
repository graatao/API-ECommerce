namespace API_ECommerce.DTO
{
    public class CadastrarClientesDto
    {
        public string Nome { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Telefone { get; set; } = null!;
        public string Endereco { get; set; } = null!;
        public string Senha { get; set; } = null!;
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; set; }
    }
}
