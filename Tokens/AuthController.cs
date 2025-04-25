using API_ECommerce.Services;
using Microsoft.AspNetCore.Mvc;

namespace API_ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel model)
        {
            // Aqui você deve validar o usuário com seu banco de dados.
            // Para simplicidade, vamos validar um usuário fixo.
            if (model.Username == "admin" && model.Password == "senha123")
            {
                var token = _authService.GenerateToken(model.Username);
                return Ok(new { Token = token });
            }

            return Unauthorized("Credenciais inválidas");
        }
    }

    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
