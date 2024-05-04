using Microsoft.AspNetCore.Mvc;
using Odon.Track.Application.Services;

namespace Odon.Track.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AuthServices _auth;
        public AuthController(AuthServices auth)
        {
            _auth = auth;
        }

        [HttpPost("signup")]
        public async Task<IActionResult> Singup() =>
            await _auth.Singup();

        [HttpPost]
        public async Task<IActionResult> Auth() =>
            await _auth.Auth();
        [HttpGet]
        public async Task<IActionResult> Teste([FromQuery] int valor)
        {
            var teste = 2 / valor;

            return Ok("Deu Certo!");
        }
    }
}
