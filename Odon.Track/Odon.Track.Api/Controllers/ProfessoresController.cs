using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Odon.Track.Application.Authorization;
using Odon.Track.Application.Contract.Professores;
using Odon.Track.Application.Services;
using Org.BouncyCastle.Asn1.Ocsp;

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
        public async Task<IActionResult> GetProfessoresDetails(int id)
        {
            return await _services.GetProfessorDetails(id);
        }

        [HttpGet("buscarPorNome")]
        public async Task<IActionResult> GetProfessoresByNome(string nome)
        {
            return await _services.GetProfessoresByNome(nome);
        }

        [HttpPost("excluir/{id}")]
        public async Task<IActionResult> DeleteDisciplinaProfessor(int id, [FromBody] DeleteProfessorDisciplinaRequest request)
        {
            return await _services.DeleteDisciplinaProfessor(id, request);
        }


    }
}
