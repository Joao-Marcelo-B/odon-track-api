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

        [Authorize]
        [HttpPatch("alterarSenha/usuario")]
        public async Task<IActionResult> AlterarSenha([FromBody] PatchAlterarSenhaRequeste request) =>
            await _auth.AlterarSenha(request);

        [HttpGet("roles")]
        [Authorize(Roles = RolesForUsers.Professor)]
        public async Task<IActionResult> GetRoles() =>
            await _auth.GetRoles();

        [HttpGet("roles/periodo")]
        [Authorize(Roles = RolesForUsers.Professor)]
        public async Task<IActionResult> GetRolesPeriodo([FromQuery] int semestre) =>
            await _auth.GetRolesPeriodo(semestre);

        [HttpPatch("roles/semestre/periodo")]
        [Authorize(Roles = RolesForUsers.Professor)]
        public async Task<IActionResult> PatchRolesSemestrePeriodo([FromBody] PatchRolesSemestreRequest request) =>
            await _auth.PatchRolesSemestrePeriodo(request);

        [HttpGet("roles/modulo")]
        [Authorize(Roles = RolesForUsers.Professor)]
        public async Task<IActionResult> GetRolesModulo([FromQuery] int semestre) =>
            await _auth.GetRolesModulo(semestre);

        [HttpPatch("roles/semestre/modulo")]
        [Authorize(Roles = RolesForUsers.Professor)]
        public async Task<IActionResult> PatchRolesSemestreModulo([FromBody] PatchRolesModuloRequest request) =>
            await _auth.PatchRolesSemestreModulo(request);
    }
}
