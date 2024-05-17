using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> GetEstudantes()
        {
            return await _services.GetEstudantes();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEstudanteById([FromRoute]int id)
        {
            return await _services.GetByEstudante(id);
        }
    }
}
