namespace API_ECommerce.DTO
{
    internal class ClienteDTO
    {
        public int IdCliente { get; set; }
        public object? Nome { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string? Endereco { get; set; }
    }
}