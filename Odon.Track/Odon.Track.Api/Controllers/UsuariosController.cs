using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Odon.Track.Application.Authorization;
using Odon.Track.Application.Services;

namespace Odon.Track.Api.Controllers
{
    [Authorize(Roles = RolesForUsers.Administrador)]
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
        public async Task<IActionResult> GetUsuarios(int pageIndex, int pageSize)
        {
            return await _services.GetUsuarios(pageIndex, pageSize);
        }
    }
}
