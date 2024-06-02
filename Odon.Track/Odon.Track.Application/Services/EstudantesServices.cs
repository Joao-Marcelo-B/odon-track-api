using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Odon.Track.Application.Contract.Auth;
using Odon.Track.Application.Contract.Estudantes;
using Odon.Track.Application.Data.MySQL;
using Odon.Track.Application.Data.MySQL.Entity;
using Odon.Track.Application.Errors;
using Odon.Track.Application.Responses;

namespace Odon.Track.Application.Services
{
    public class EstudantesServices : BaseResponses
    {
        private readonly OdontrackContext _context;
        public EstudantesServices(OdontrackContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> GetEstudantes()
        {
            
            var estudantes = await _context.Estudantes.ToListAsync();
            GetEstudantesResponse estudante = new ();
            foreach (var item in estudantes)
                estudante.Estudantes.Add(new EstudantesInfo
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    PeriodoAtual = item.PeriodoAtual
                });
            
            return Ok(new { estudante.Estudantes });
        }

        public async Task<IActionResult> GetEstudanteById(int id)
        {
            var estudante = await _context.Estudantes.FirstOrDefaultAsync(x => x.Id == id);
            if (estudante == null)
                return BadRequest(OdonTrackErrors.EstudanteNotFound);
            else 
                return Ok(estudante);
        }

        public async Task<IActionResult> GetEstudanteByNome(string nome)
        {
            var estudanteValidos = await (from e in _context.Estudantes
                                          join u in _context.Usuarios on e.IdUsuario equals u.Id
                                          where e.Nome.ToLower().Contains(nome.ToLower()) && u.Blocked == 0
                                          select e).ToListAsync();

            if (estudanteValidos == null || !estudanteValidos.Any())
                return Ok(new List<Paciente>());
            else
                return Ok(estudanteValidos);
        }

        public async Task<IActionResult> UpdateEstudante(PathEstudantesRequest request)
        {
            var estudante = await _context.Estudantes.FirstOrDefaultAsync(x => x.Id.Equals(request.Id));
            if (estudante == null)
                return BadRequest(OdonTrackErrors.EstudanteNotFound);

            estudante.Nome = request.Nome;
            estudante.PeriodoAtual = request.Periodo;

            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}

