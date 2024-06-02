using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Odon.Track.Application.Authorization;
using Odon.Track.Application.Services;

namespace Odon.Track.Api.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class ProfessoresController : ControllerBase
    {
        private readonly ProfessoresServices _services;

        public ProfessoresController(ProfessoresServices services)
        {
            _services = services;
        }

        [HttpGet]
        [Authorize(Roles = RolesForUsers.Professor)]
        public async Task<IActionResult> GetProfessores()
        {
            return await _services.GetProfessores();
        }

        [HttpGet("{id}")]
        [Authorize(Roles = RolesForUsers.Professor)]
        public async Task<IActionResult> GetProdessoresDetails(int id)
        {
            return await _services.GetProfessorDetails(id);
        }

        [HttpGet("buscarPorNome")]
        public async Task<IActionResult> GetProfessoresByNome(string nome)
        {
            return await _services.GetProfessoresByNome(nome);
        }

    }
}
