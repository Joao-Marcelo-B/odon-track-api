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

        public async Task<IActionResult> GetEstudantes(int mostrarInativos)
        {
            
            var estudantes = await _context.Estudantes.ToListAsync();
            var usuariosEstudantes = await _context.Usuarios.Where(x => x.IdTipoUsuario == 3).ToListAsync();

            GetEstudantesResponse estudante = new ();
            foreach (var item in estudantes)
            {
                if (mostrarInativos == 1)
                {
                    estudante.Estudantes.Add(new EstudantesInfo
                    {
                        Id = item.Id,
                        Nome = item.Nome,
                        PeriodoAtual = item.PeriodoAtual,
                        Identificador = usuariosEstudantes.Find(x => x.Id == item.IdUsuario).IdentificadorUnifenas,
                        Ativo = item.Ativo == 1 ? true : false
                    });
                }
                else if (item.Ativo == 1)
                {
                    estudante.Estudantes.Add(new EstudantesInfo
                    {
                        Id = item.Id,
                        Nome = item.Nome,
                        PeriodoAtual = item.PeriodoAtual,
                        Identificador = usuariosEstudantes.Find(x => x.Id == item.IdUsuario).IdentificadorUnifenas,
                        Ativo = item.Ativo == 1 ? true : false
                    });
                }

                
            }
                
            
            return Ok(new { estudante.Estudantes });
        }

        public async Task<IActionResult> GetEstudanteById(int id)
        {
            var estudante = await _context.Estudantes.FirstOrDefaultAsync(x => x.Id == id);
            
            if (estudante == null)
                return BadRequest(OdonTrackErrors.EstudanteNotFound);

            var usuariosEstudantes = await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == estudante.IdUsuario);
            var detalhesEstudante = new EstudantesInfo();
            detalhesEstudante.Id = estudante.Id;
            detalhesEstudante.Identificador = usuariosEstudantes.IdentificadorUnifenas;
            detalhesEstudante.PeriodoAtual = estudante.PeriodoAtual;
            detalhesEstudante.Nome = estudante.Nome;
            detalhesEstudante.Ativo = estudante.Ativo == 1 ? true: false;

            return Ok(detalhesEstudante);
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
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Id == estudante.IdUsuario);

            estudante.Nome = request.Nome;
            estudante.PeriodoAtual = request.Periodo;
            estudante.Ativo = request.Ativo ? 1 :0;
            usuario.Blocked = estudante.Ativo;

            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}

