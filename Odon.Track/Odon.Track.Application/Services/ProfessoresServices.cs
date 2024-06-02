using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Odon.Track.Application.Contract.Professores;
using Odon.Track.Application.Data.MySQL;
using Odon.Track.Application.Data.MySQL.Entity;
using Odon.Track.Application.Errors;
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
            var professores = await _context.Professors
                .Include(p=> p.Usuario)
                .Include(p => p.DisciplinasProfessores)
                .ThenInclude(dp => dp.Disciplina)
                .ToListAsync();
            List<GetProfessoresDisciplinasResponse> professoresDisciplinas = new();
            
            foreach (var item in professores)
            {
                List<string> disciplinas = new();
                foreach (var disciplina in item.DisciplinasProfessores)
                {
                    if (disciplina.Id_Professor == item.Id)
                        disciplinas.Add(disciplina.Disciplina.Nome);                                    
                }
                professoresDisciplinas.Add(new()
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    NomeDisciplina = disciplinas,
                    CodigoUnifenas = item.Usuario.IdentificadorUnifenas,
                    Bloqueado = item.Usuario.Blocked
                });
            }
            return Ok(new { professoresDisciplinas });
        }

        public async Task<IActionResult> GetProfessorDetails(int id)
        {
            Professor professor = new();

            var professores = await _context.Professors
                .Include(p => p.Usuario)
                .Include(p => p.DisciplinasProfessores)
                .ThenInclude(dp => dp.Disciplina)
                .Where(p => p.Id == id).ToListAsync();

            List<GetProfessoresDetailsResponse> professoresDetails = new();

            foreach (var item in professores)
            {
                List<string> disciplinas = new();
                foreach (var disciplina in item.DisciplinasProfessores)
                {
                    if (disciplina.Id_Professor == item.Id)
                        disciplinas.Add(disciplina.Disciplina.Nome);
                }
                professoresDetails.Add(new()
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    NomeDisciplina = disciplinas,
                    IdentificadorUnifenas = item.Usuario.IdentificadorUnifenas,
                    Email = item.Usuario.Email
                });
            }

            return Ok(new { professoresDetails });
        }

        public async Task<IActionResult> GetProfessoresByNome(string nome)
        {
            var professoresValidos = await (from p in _context.Professors
                                          join u in _context.Usuarios on p.IdUsuario equals u.Id
                                          where p.Nome.ToLower().Contains(nome.ToLower()) && u.Blocked == 0
                                          select p).ToListAsync();

            if (professoresValidos == null || !professoresValidos.Any())
                return Ok(new List<Paciente>());
            else
                return Ok(professoresValidos);
        }
    }
}
