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
        public async Task<IActionResult> Signup([FromBody] PostSignupRequest request) =>
            await _auth.Signup(request);

        [HttpPost]
        public async Task<IActionResult> Auth([FromBody] PostAuthRequest request) =>
            await _auth.Auth(request, HttpContext);
    }
}
