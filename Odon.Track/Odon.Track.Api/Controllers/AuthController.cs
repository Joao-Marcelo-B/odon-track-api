using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Odon.Track.Application.Contract;
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
        public async Task<IActionResult> Singup([FromBody] PostSingupRequest request) =>
            await _auth.Singup(request);

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Auth() =>
            await _auth.Auth();
    }
}
