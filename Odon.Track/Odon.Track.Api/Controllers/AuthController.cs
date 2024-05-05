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
        public async Task<IActionResult> Auth([FromQuery] int valor) =>
            await _auth.Auth(valor);
    }
}
