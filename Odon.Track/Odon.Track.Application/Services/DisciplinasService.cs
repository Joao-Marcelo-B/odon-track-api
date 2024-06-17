using System.Runtime.Intrinsics.Arm;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Odon.Track.Application.Contract.Disciplinas;
using Odon.Track.Application.Data.MySQL;
using Odon.Track.Application.Data.MySQL.Entity;
using Odon.Track.Application.Responses;

namespace Odon.Track.Application.Services
{
    public class DisciplinasService : BaseResponses
    {
        private OdontrackContext _context;
        public DisciplinasService(OdontrackContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> AddDisciplina(Disciplina disciplina)
        {
            var disciplinaFound = await _context.Disciplinas.FirstOrDefaultAsync(d => d.Nome == disciplina.Nome);
            if (disciplina != null && disciplinaFound == null)
            {
                _context.Disciplinas.Add(disciplina);
                _context.SaveChanges();
                return Ok(disciplina);
            }
            else
            {
                return BadRequest("Nome para a Disciplina inválido.");
            }
        }

        public async Task<IActionResult> DeleteDisciplina(int id)
        {
            var disciplina = await _context.Disciplinas.FirstOrDefaultAsync(d => d.Id == id);
            if (disciplina != null)
            {
                _context.Disciplinas.Remove(disciplina);
                _context.SaveChanges();
                return Ok(disciplina);
            }
            else
            {
                return BadRequest("Disciplina não encontrada.");
            }
        }

        public async Task<IActionResult> GetDisciplinas()
        {
            var response = await _context.Disciplinas
                .Include(d => d.DisciplinasProfessores)
                .ThenInclude(dp => dp.Professor)
                .ToListAsync();

            List<GetDisciplinasResponse> responseDisciplinas = new();
            

            foreach (var item in response)
            {
                GetDisciplinasResponse Disciplina = new();
                Disciplina.Id = item.Id;
                Disciplina.Nome = item.Nome;
                var professores = await _context.Professors
                .Include(p => p.Usuario)
                .Include(p => p.DisciplinasProfessores)
                .ThenInclude(dp => dp.Disciplina)
                .ToListAsync();
                List<string> professoresDisciplina = new();
                foreach (var x in item.DisciplinasProfessores)
                {                
                    if (x.Id_Disciplinas == item.Id)
                        professoresDisciplina.Add(x.Professor.Nome);
                }
                Disciplina.Professores = professoresDisciplina;
                responseDisciplinas.Add(Disciplina);
            }

            return Ok(new { responseDisciplinas });
        }
    }
}
