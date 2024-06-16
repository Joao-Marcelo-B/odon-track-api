using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Odon.Track.Application.Authorization;
using Odon.Track.Application.Contract.Pacientes;
using Odon.Track.Application.GetToken;
using Odon.Track.Application.Services;

namespace Odon.Track.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = RolesForUsers.Professor + "," + RolesForUsers.Estudante)]
    public class PacientesController(PacientesServices _services) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetPacientes([FromQuery] string nomePaciente, [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10) =>
            await _services.GetPacientes(pageNumber, pageSize, nomePaciente);

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPacienteById([FromRoute] int id)
        {
            return await _services.GetPacienteById(id);
        }

        [HttpGet("buscarPorNome")]
        public async Task<IActionResult> GetPacienteByNome(string nome)
        {
            return await _services.GetPacienteByNome(nome);
        }

        [HttpGet("Endereco/{id}")]
        public async Task<IActionResult> GetEnderecoPaciente([FromRoute] int id) =>
            await _services.GetEnderecoPaciente(id);

        [HttpGet("Responsavel/{id}")]
        public async Task<IActionResult> GetResponsavelPaciente([FromRoute] int id) =>
            await _services.GetResponsavelPaciente(id);

        [HttpGet("Responsavel/Endereco/{id}")]
        public async Task<IActionResult> GetEnderecoRenponsavel([FromRoute] int id) =>
            await _services.GetEnderecoResposavel(id);

        [HttpPost]
        [Authorize(Roles = RolesForAccess.CadastrarPaciente)]
        public async Task<IActionResult> PostCadastrarPaciente([FromBody] PostCadastrarPacienteRequest request) =>
            await _services.PostCadastrarPaciente(GetHeaderValues.GetIdUsuario(Request.HttpContext.User.Claims) ,request);

        [HttpPost("Endereco")]
        public async Task<IActionResult> PostCadastrarEnderecoPaciente([FromBody] PostCadastrarEnderecoPacienteRequest request) => 
            await _services.PostCadastrarEnderecoPaciente(request);

        [HttpPost("Responsavel")]
        public async Task<IActionResult> PostCadastrarResponsavelPaciente([FromBody] PostCadastrarResponsavelPaciente request) =>
            await _services.PostCadastrarResponsavelPaciente(request);

        [HttpPost("Responsavel/Endereco")]
        public async Task<IActionResult> PostCadastrarEnderecoResponsavel([FromBody] PostCadastrarEnderecoResponsavel request) =>
            await _services.PostCadastrarEnderecoResposavel(request);

        [HttpPatch]
        public async Task<IActionResult> PatchAtualizarPaciente([FromBody] PathAtualizarPacienteRequest request) =>
            await _services.PatchAtualizarPaciente(request);

        [HttpPatch("Endereco")]
        public async Task<IActionResult> PatchAtualizarEnderecoPaciente([FromBody] PathAtualizarEnderecoPaciente request) =>
            await _services.PatchAtualizarEnderecoPaciente(request);

        [HttpPatch("Responsavel")]
        public async Task<IActionResult> PatchAtualizarResponsavelPaciente([FromBody] PathAtualizarResponsavelPaciente request) =>
            await _services.PatchAtualizarResponsavelPaciente(request);

        [HttpPatch("Responsavel/Endereco")]
        public async Task<IActionResult> PatchAtualizarEnderecoRenponsavel([FromBody] PathAtualizarEnderecoResponsavel request) =>
            await _services.PatchAtualizarEnderecoRenponsavel(request);

        [HttpDelete("Endereco/{id}")]
        public async Task<IActionResult> DeleteEnderecoPaciente([FromRoute] int id) =>
            await _services.DeleteEnderecoPaciente(id);

        [HttpDelete("Responsavel/{id}")]
        public async Task<IActionResult> DeleteResponsavelPaciente([FromRoute] int id) =>
            await _services.DeleteResponsavelPaciente(id);

        [HttpDelete("Responsavel/Endereco/{id}")]
        public async Task<IActionResult> DeleteEnderecoRenponsavel([FromRoute] int id) =>
            await _services.DeleteEnderecoResposavel(id);

        
    }
}
