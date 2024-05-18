using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Odon.Track.Application.Contract.Estudantes;
using Odon.Track.Application.Contract.Usuarios;
using Odon.Track.Application.Data.MySQL;
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

    }
}
