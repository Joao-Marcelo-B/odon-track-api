using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Odon.Track.Application.Authorization;
using Odon.Track.Application.Contract.Estudantes;
using Odon.Track.Application.Contract.Usuarios;
using Odon.Track.Application.Services;

namespace Odon.Track.Api.Controllers
{
    
    [Route("[controller]")]
    [ApiController]
    public class UsuariosController : Controller
    {
        private readonly UsuariosServices _services;

        public UsuariosController(UsuariosServices services)
        {
            _services = services;
        }

        [HttpGet]
        [Authorize(Roles = RolesForUsers.Administrador)]
        public async Task<IActionResult> GetUsuarios(int pageIndex, int pageSize)
        {
            return await _services.GetUsuarios(pageIndex, pageSize);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<IActionResult> GetUsuarioById(int id)
        {
            return await _services.GetUsuarioById(id);
        }

        [HttpPatch]
        [Authorize]
        public async Task<IActionResult> UpdateUsuario([FromBody] PathUsuarioRequest request) =>
           await _services.UpdateUsuario(request);
    }
}
