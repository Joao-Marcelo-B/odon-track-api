using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Odon.Track.Application.Data.MySQL;
using Odon.Track.Application.Data.MySQL.Entity;
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
        public async Task<IActionResult> GetProfessores()
        {
            return await _services.GetProfessores();
        }

    }
}
