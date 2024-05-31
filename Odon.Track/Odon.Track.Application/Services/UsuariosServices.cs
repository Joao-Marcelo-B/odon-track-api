using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Odon.Track.Application.Contract.Estudantes;
using Odon.Track.Application.Contract.Usuarios;
using Odon.Track.Application.Data.MySQL;
using Odon.Track.Application.Errors;
using Odon.Track.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odon.Track.Application.Services
{
    public class UsuariosServices : BaseResponses
    {
        private readonly OdontrackContext _context;
        public UsuariosServices(OdontrackContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> GetUsuarioById(int id)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);

            if(usuario == null)
            {
               return BadRequest(OdonTrackErrors.UsuarioNotFound);
            }else
            {
                var professor = await _context.Professors.FirstOrDefaultAsync(x => x.IdUsuario.Equals(usuario.Id));
                var estudante = await _context.Estudantes.FirstOrDefaultAsync(x => x.IdUsuario.Equals(usuario.Id));

                GetUsuarioResponse response = new();
                response.Usuario.Add(new UsuarioInfo
                {
                    Id = usuario.Id,
                    Nome = usuario.IdTipoUsuario == 3 ? (estudante != null ? estudante.Nome : "") : (professor != null ? professor.Nome : ""),
                    IdTipoUsuario = usuario.IdTipoUsuario,
                    Email = usuario.Email,
                    Identificador = usuario.IdentificadorUnifenas,
                    periodo = usuario.IdTipoUsuario == 3 ? (estudante != null ? estudante.PeriodoAtual : 0) : 0
                });

                return Ok(response.Usuario);
            }
        }

        public async Task<IActionResult> GetUsuarios(int pageNumber = 1, int pageSize = 10)
        {
            if (pageNumber <= 0 || pageSize <= 0)
            {
                return BadRequest("Número da página e tamanho da página devem ser maiores que zero.");
            }
            var totalRecords = await _context.Usuarios.CountAsync();

            var usuario = await _context.Usuarios
                                        .Skip((pageNumber - 1) * pageSize)
                                        .Take(pageSize)
                                        .ToListAsync();

            GetUsuariosResponse response = new();
            foreach (var item in usuario)
            {
                var professor = await _context.Professors.FirstOrDefaultAsync(x => x.IdUsuario.Equals(item.Id));
                var estudante = await _context.Estudantes.FirstOrDefaultAsync(x => x.IdUsuario.Equals(item.Id));

                response.Usuarios.Add(new UsuariosInfo
                {
                    Id = item.Id,
                    Identificador = item.IdentificadorUnifenas,
                    Email = item.Email,
                    TipoUsuario = item.IdTipoUsuario,
                    Status = item.Blocked,
                    Nome = item.IdTipoUsuario == 3 ? (estudante != null ? estudante.Nome : "") : (professor != null ? professor.Nome : "")
                });
            }

            return Ok(new
            {
                TotalRecords = totalRecords,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalPages = (int)Math.Ceiling(totalRecords / (double)pageSize),
                Usuarios = response.Usuarios
            });
        }

        public async Task<IActionResult> UpdateUsuario(PathUsuarioRequest request)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(x => x.Id.Equals(request.Id));
            if (usuario == null)
                return BadRequest(OdonTrackErrors.UsuarioNotFound);

            var professor = await _context.Professors.FirstOrDefaultAsync(x => x.IdUsuario == usuario.Id);
            var estudante = await _context.Estudantes.FirstOrDefaultAsync(x => x.IdUsuario == usuario.Id);

            if(professor != null)
            {
                professor.Nome = request.Nome;
            }else
            {
                estudante.Nome = request.Nome;
            }

            usuario.IdentificadorUnifenas = request.identificador;

            await _context.SaveChangesAsync();

            return Ok();

        }

    }
}
