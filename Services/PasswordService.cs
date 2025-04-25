using API_ECommerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace API_ECommerce.Services
{
    public class PasswordService
    {
        private readonly PasswordHasher<Cliente> _hasher = new PasswordHasher<Cliente>();
    
    public string HashPassword(Cliente cliente)
        {
            return _hasher.HashPassword(cliente, cliente.Senha);
        }
        public bool VerifyPassword(Cliente cliente, string password)
        {
            var result = _hasher.VerifyHashedPassword(cliente, cliente.Senha, password);
            return result == PasswordVerificationResult.Success;
        }
    }   
}
