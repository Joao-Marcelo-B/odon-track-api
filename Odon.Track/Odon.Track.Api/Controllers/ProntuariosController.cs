using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Odon.Track.Application.Authorization;
using Odon.Track.Application.Contract.Pacientes;
using Odon.Track.Application.Services;

namespace Odon.Track.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProntuariosController(ProntuariosServices _services) : ControllerBase
    {
        [HttpPost("triagem")]
        [Authorize(Roles = RolesForAccess.CadastrarTriagem)]
        public async Task<IActionResult> PostCadastrarTriagem([FromBody] PostCadastrarTriagemRequest request) =>
            await _services.PostCadastrarTriagem(request);
    }   
}
