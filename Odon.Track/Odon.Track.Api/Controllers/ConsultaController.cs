using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Odon.Track.Application.Authorization;
using Odon.Track.Application.Contract.Consultas;
using Odon.Track.Application.Services;

namespace Odon.Track.Api.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class ConsultaController : Controller
    {
        private readonly ConsultaServices _services;

        public ConsultaController(ConsultaServices services)
        {
            _services = services;
        }
        [HttpGet]
        public async Task<IActionResult> GetConsultas([FromQuery] string descricao, [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            return await _services.GetConsultas(pageNumber, pageSize, descricao);
        }

        [HttpPost]
        public async Task<IActionResult> PostCadastrarConsulta([FromBody] PostCadastrarConsultaResquest request) => 
            await _services.PostCadastrarConsulta(request);

        [HttpPatch]
        public async Task<IActionResult> PatchAtualizarConsulta([FromBody] PatchAtualizarConsultaResquest request) =>
            await _services.PatchAtualizarConsulta(request);
    }
}
