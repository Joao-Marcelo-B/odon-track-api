using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Odon.Track.Application.Data.MySQL;
using Odon.Track.Application.Data.MySQL.Entity;
using Odon.Track.Application.Responses;

namespace Odon.Track.Application.Services
{
    public class ProfessoresServices : BaseResponses
    {
        private readonly OdontrackContext _context;
        public ProfessoresServices(OdontrackContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> GetProfessores()
        {
            var professores = await _context.Professors.ToListAsync();
            return Ok(new {professores});
        }
    }
}
