using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Odon.Track.Application.Authorization;
using Odon.Track.Application.Contract.Prontuarios;
using Odon.Track.Application.GetToken;
using Odon.Track.Application.Services;

namespace Odon.Track.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = RolesForUsers.Professor + "," + RolesForUsers.Estudante)]
    public class ProntuariosController(ProntuariosServices _services) : ControllerBase
    {
        [HttpPost]
        [Authorize(Roles = RolesForAccess.CadastrarProntuario)]
        public async Task<IActionResult> PostCadastrarProntuario([FromBody] PostCadastrarProntuarioRequest request) =>
            await _services.PostCadastrarProntuario(request, GetHeaderValues.GetIdUsuario(Request.HttpContext.User.Claims));

        [HttpGet("details/{idProntuario}")]
        public async Task<IActionResult> GetProntuarioDetails([FromRoute] int idProntuario) =>
            await _services.GetProntuarioDetails(idProntuario);

        [HttpPost("triagem")]
        [Authorize(Roles = RolesForAccess.CadastrarTriagem)]
        public async Task<IActionResult> PostCadastrarTriagem([FromBody] PostCadastrarTriagemRequest request) =>
            await _services.PostCadastrarTriagem(request);

        [HttpPatch("triagem")]
        public async Task<IActionResult> PathAlterarTriagem([FromBody] PathAlterarTriagemRequest request) =>
            await _services.PathAlterarTriagem(request);

        [HttpGet]
        public async Task<IActionResult> GetProntuarios([FromQuery] string nomePaciente, [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10) =>
            await _services.GetProntuarios(pageNumber, pageSize, nomePaciente);

        [HttpPatch("triagem/filtro")]
        public async Task<IActionResult> GetTriagem(
        [FromQuery] string nomePaciente,
        [FromBody] PatchBuscarTriagemRequeste filtro,
        [FromQuery] int pageNumber = 1,
        [FromQuery] int pageSize = 10)
        {
            return await _services.GetTriagem(filtro, pageNumber, pageSize, nomePaciente);
        }


        [HttpGet("triagem/{id}")]
        public async Task<IActionResult> GetTriagemById(int id) =>
            await _services.GetTriagemById(id);

        [HttpGet("pronto/atendimento")]
        public async Task<IActionResult> GetProntoAtendimento([FromQuery] string nomePaciente, [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10) =>
            await _services.GetProntoAtendimento(pageNumber, pageSize, nomePaciente);

        [HttpGet("reavaliacao/anamnese")]
        public async Task<IActionResult> GetReavaliacaoAnamnese([FromQuery]int idPaciente, [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10) =>
            await _services.GetReavaliacaoAnamnese(idPaciente, pageNumber, pageSize);
    }   
}
