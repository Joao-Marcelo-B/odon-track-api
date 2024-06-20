using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Odon.Track.Application.Authorization;
using Odon.Track.Application.Data.MySQL.Entity;
using Odon.Track.Application.Services;

namespace Odon.Track.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = RolesForUsers.Professor)]
    public class DisciplinasController : Controller
    {
        private readonly DisciplinasService _disciplinasService;

        public DisciplinasController(DisciplinasService disciplinasService)
        {
            _disciplinasService = disciplinasService;
        }
        [HttpPost ("AdicionarDisciplina")]
        public async Task<IActionResult> AddDisciplina([FromBody]Disciplina disciplina)
        {
            return await _disciplinasService.AddDisciplina(disciplina);
        }

        [HttpDelete("ExcluirDisciplina/{id}")]
        public async Task<IActionResult> DeleteDisciplina(int id)
        {
            return await _disciplinasService.DeleteDisciplina(id);
        }

        [HttpGet]
        public async Task<IActionResult> GetDisciplinas()
        {
            return await _disciplinasService.GetDisciplinas();
        }
        [HttpGet("disciplinaByNome/{nome}")]
        public async Task<IActionResult> GetDisciplinaByNome(string nome)
        {
            return await _disciplinasService.GetDisciplinaByNome(nome);
        }
    }
}
