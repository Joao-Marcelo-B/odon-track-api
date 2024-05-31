using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Odon.Track.Application.Authorization;
using Odon.Track.Application.Contract.Auth;
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

        [HttpPatch("autorizar/usuario")]
        [Authorize(Roles = RolesForUsers.Professor)]
        public async Task<IActionResult> AutorizarUsuario([FromBody] PatchAutorizarUsuarioRequest request) =>
            await _auth.AutorizarUsuario(request);

        [HttpGet("roles")]
        [Authorize(Roles = RolesForUsers.Professor)]
        public async Task<IActionResult> GetRoles([FromQuery] int periodo) =>
            await _auth.GetRoles(periodo);

        [HttpPatch("roles/semestre")]
        [Authorize(Roles = RolesForUsers.Professor)]
        public async Task<IActionResult> PatchRolesSemestre([FromBody] PatchRolesSemestreRequest request) =>
            await _auth.PatchRolesSemestre(request);
    }
}
