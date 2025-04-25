namespace API_ECommerce.Exceptions
{
    namespace API_ECommerce.Exceptions
    {
        public class ClienteNaoEncontradoException : Exception
        {
            public ClienteNaoEncontradoException(int id)
                : base($"Cliente com ID {id} não encontrado.") { }

            public ClienteNaoEncontradoException(string valor, string campo = "valor")
                : base($"Cliente com {campo}: '{valor}' não encontrado.") { }
        }
    }
}
