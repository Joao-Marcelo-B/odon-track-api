using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Odon.Track.Application.Authorization;
using Odon.Track.Application.Contract.Auth;
using Odon.Track.Application.Contract.Estudantes;
using Odon.Track.Application.Services;

namespace Odon.Track.Api.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class EstudantesController : Controller
    {
        private readonly EstudantesServices _services;

        public EstudantesController(EstudantesServices services)
        {
            _services = services;
        }
        [HttpGet]
        [Authorize(Roles = RolesForUsers.Administrador + "," + RolesForUsers.Professor)]
        public async Task<IActionResult> GetEstudantes()
        {
            return await _services.GetEstudantes();
        }

        [HttpGet("{id}")]
        [Authorize(Roles = RolesForUsers.Administrador + "," + RolesForUsers.Professor)]
        public async Task<IActionResult> GetEstudanteById([FromRoute]int id)
        {
            return await _services.GetByEstudante(id);
        }

        [HttpPatch]
        [Authorize(Roles = RolesForUsers.Administrador + "," + RolesForUsers.Professor)]
        public async Task<IActionResult> UpdateEstudante([FromBody] PathEstudantesRequest request) =>
            await _services.UpdateEstudante(request);
    }
}
