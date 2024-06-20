using System.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
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
        public async Task<IActionResult> GetProfessores(int mostrarInativos)
        {
            var professores = await _context.Professors
                .Include(p=> p.Usuario)
                .Include(p => p.DisciplinasProfessores)
                .ThenInclude(dp => dp.Disciplina)
                .ToListAsync();
            List<GetProfessoresDisciplinasResponse> professoresDisciplinas = new();
            
            foreach (var item in professores)
            {
                if (mostrarInativos == 1)
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
                        Bloqueado = item.Usuario.Blocked,
                        Ativo = item.Ativo
                    });
                }

                else
                {
                    if (item.Ativo == 1)
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
                            Bloqueado = item.Usuario.Blocked,
                            Ativo = item.Ativo
                        });
                    }
                }
            }
            return Ok(new { professoresDisciplinas });
        }

        public async Task<IActionResult> GetProfessoresInativos()
        {
            var professores = await _context.Professors
                .Include(p => p.Usuario)
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
                    Bloqueado = item.Usuario.Blocked,
                    Ativo = item.Ativo
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

            GetProfessoresDetailsResponse professoresDetails = new();

            foreach (var item in professores)
            {
                List<string> disciplinas = new();
                foreach (var disciplina in item.DisciplinasProfessores)
                {
                    if (disciplina.Id_Professor == item.Id)
                        disciplinas.Add(disciplina.Disciplina.Nome);
                }
                professoresDetails = new()
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    NomeDisciplina = disciplinas,
                    IdentificadorUnifenas = item.Usuario.IdentificadorUnifenas,
                    Email = item.Usuario.Email,
                    Ativo = item.Ativo
                };
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

        public async Task<IActionResult> DeleteDisciplinaProfessor(int idProfessor, DeleteProfessorDisciplinaRequest disciplina)
        {
            var Disciplina = await _context.Disciplinas.FirstOrDefaultAsync(d => d.Nome == disciplina.NomeDisciplina);
            if (Disciplina != null)
            {
                var disciplinasProfessor = await _context.DisciplinasProfessor.FirstOrDefaultAsync(dp => dp.Id_Professor == idProfessor && dp.Disciplina.Id == Disciplina.Id);
                if (disciplinasProfessor != null)
                {
                    _context.DisciplinasProfessor.Remove(disciplinasProfessor);
                    _context.SaveChanges();
                    return Ok("Removido com sucesso.");
                }
                else
                    return BadRequest("Houve um erro interno.");
            }
            else
                return BadRequest("Houve um erro interno.");
        }

        public async Task<IActionResult> AddDisciplinaProfessor(PostAddDisciplinaProfessorRequest request)
        {
            var disciplina = await _context.Disciplinas.FirstOrDefaultAsync(d => d.Id == request.idDisciplina);
            if (disciplina != null)
            {
                var professor = await _context.Professors.FirstOrDefaultAsync(p => p.Id == request.idProfessor);
                if (professor != null)
                {
                    DisciplinasProfessor dp = new();
                    dp.Id_Professor = request.idProfessor;
                    dp.Id_Disciplinas = request.idDisciplina;
                    _context.DisciplinasProfessor.Add(dp);
                    _context.SaveChanges();
                    return Ok("Disciplina vinculada a professor.");
                }
                else
                    return BadRequest("Professor inválido.");
            }
            else return BadRequest("Disciplina inválida.");
        }

        public async Task<IActionResult> UpdateProfessor(PatchUpdateProfessorRequest request)
        {
            var professor = await _context.Professors.FirstOrDefaultAsync(p => p.Id == request.Id);

            if (professor != null)
            {
                var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Id == professor.IdUsuario);

                usuario.Blocked = request.Ativo ? 0 : 1;
                professor.Ativo = request.Ativo ? 1 : 0;
                professor.Nome = request.Nome;
                _context.Professors.Update(professor);
                _context.Usuarios.Update(usuario);
                await _context.SaveChangesAsync();
                return Ok("Dados atualizados com sucesso.");
            }
            else
                return BadRequest("Ouve um erro ao atualizar os dados.");
        }        
    }
}
