using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Odon.Track.Application.Authorization;
using Odon.Track.Application.Contract.Prontuarios;
using Odon.Track.Application.GetToken;
using Odon.Track.Application.Data.MySQL.Entity;
using Odon.Track.Application.Services;
using Org.BouncyCastle.Asn1.Ocsp;

namespace Odon.Track.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize(Roles = RolesForUsers.Administrador + "," + RolesForUsers.Professor + "," + RolesForUsers.Estudante)]
    public class ProntuariosController(ProntuariosServices _services) : ControllerBase
    {
        [HttpPost]
        [Authorize(Roles = RolesForAccess.CadastrarProntuario)]
        public async Task<IActionResult> PostCadastrarProntuario([FromBody] PostCadastrarProntuarioRequest request) =>
            await _services.PostCadastrarProntuario(request, GetHeaderValues.GetIdUsuario(Request.HttpContext.User.Claims));

        [HttpPost("responder")]
        public async Task<IActionResult> PostResponderQuestionario([FromBody] PostResponderQuestionarioRequest request) =>
            await _services.PostResponderQuestionario(request, GetHeaderValues.GetIdUsuario(Request.HttpContext.User.Claims));

        [HttpGet("respostas/{idProntuario}")]
        public async Task<IActionResult> GetRespostasProntuario([FromRoute] int idProntuario) =>
            await _services.GetRespostasProntuario(idProntuario);

        [HttpGet("grupos")]
        public async Task<IActionResult> GetGrupos() =>
            await _services.GetGrupos();

        [HttpPost("imagem")]
        [Authorize(Roles = RolesForAccess.CadastrarProntuario)]
        [RequestSizeLimit(10048576)]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> PostUploadImagem([FromForm] PostUploadImagemRequest request) =>
            await _services.PostUploadImagem(request);

        [HttpGet("imagens/{idProntuario}")]
        public async Task<IActionResult> GetImagensProntuario([FromRoute] int idProntuario, [FromQuery] string tipoImagem = "") =>
            await _services.GetImagensProntuario(idProntuario, tipoImagem);

        [HttpDelete("imagem/{idImagem}")]
        public async Task<IActionResult> DeleteImagemProntuario([FromRoute] int idImagem = 0) =>
            await _services.DeleteImagemProntuario(idImagem);

        [HttpGet("{idProntuario}")]
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

        [HttpGet("pronto/atendimento/{id}")]
        public async Task<IActionResult> GetProntuarioProntoAtendimentoById(int id) =>
            await _services.GetProntoAtendimentoById(id);

        [HttpGet("reavaliacao/anamnese")]
        public async Task<IActionResult> GetReavaliacaoAnamnese([FromQuery]int idPaciente, [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10) =>
            await _services.GetReavaliacaoAnamnese(idPaciente, pageNumber, pageSize);

        [Authorize(Roles = RolesForUsers.Administrador + "," + RolesForUsers.Professor + "," + RolesForUsers.Estudante)]
        [HttpPost("pronto/atendimento")]
        public async Task<IActionResult> PostCadastrarProntoAtendimento([FromBody] PostProntuarioProntoAtendimentoRequest request) =>
            await _services.PostCadastrarProntoAtendimento(request,GetHeaderValues.GetIdUsuario(Request.HttpContext.User.Claims));

    }   
}
