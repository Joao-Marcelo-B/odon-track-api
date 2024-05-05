using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Odon.Track.Application.Data;
using Odon.Track.Application.Services;

namespace Odon.Track.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AuthServices _auth;
        private readonly TesteContext _context;
        public AuthController(AuthServices auth, TesteContext context)
        {
            _auth = auth;
            _context = context;
        }

        [HttpPost("signup")]
        public async Task<IActionResult> Singup() =>
            await _auth.Singup();

        [HttpPost]
        public async Task<IActionResult> Auth() =>
            await _auth.Auth();
        [HttpGet]
        public async Task<IActionResult> Teste()
        {
            return Ok(new { message = "Deu Certo!" });
        }

        [HttpGet("banco")]
        public async Task<IActionResult> TesteBanco()
        {
            var response = await _context.TesteTables.FirstOrDefaultAsync();
            return Ok(response);
        }
    }
}
