using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Odon.Track.Application.Contract;
using Odon.Track.Application.Crypto;
using Odon.Track.Application.Data.MySQL;
using Odon.Track.Application.Data.MySQL.Entity;
using Odon.Track.Application.Errors;
using Odon.Track.Application.Responses;

namespace Odon.Track.Application.Services
{
    public class AuthServices(OdontrackContext _context) : BaseResponses
    {
        public async Task<IActionResult> Singup(PostSingupRequest request)
        {
            if (!request.Email.Contains("unifenas"))
                return BadRequest(OdonTrackErrors.EmailUnifenasInvalid);

            if (request.Password != request.PasswordConfirmed)
                return BadRequest(OdonTrackErrors.PasswordNotMatched);

            var emailUsed = await _context.Usuarios.AnyAsync(x => x.Email.Equals(request.Email));
            if(emailUsed)
                return BadRequest(OdonTrackErrors.EmailUsed);

            var identificadorUsed = await _context.Usuarios.AnyAsync(x => x.IdentificadorUnifenas.Equals(request.Identificador));
            if(identificadorUsed)
                return BadRequest(OdonTrackErrors.EmailUsed);

            //TODO: Talvez validar codigo enviado ao email

            byte[] passwordHash, passwordSatl;
            PasswordSaltHasher.CreatePasswordHashAndSalt(request.Password, out passwordHash, out passwordSatl);

            var user = new Usuario()
            {
                Email = request.Email,
                IdTipoUsuario = request.TipoUsuario,
                IdentificadorUnifenas = request.Identificador,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSatl,
            };
            await _context.Usuarios.AddAsync(user);

            if (request.TipoUsuario.Equals(2))
            {
                var estudante = new Estudante()
                {
                    IdUsuario = user.Id,
                    Nome = request.Nome,
                    Matricula = request.Identificador,
                };
                await _context.Estudantes.AddAsync(estudante);
            } else if (request.TipoUsuario.Equals(1))
            {
                var professor = new Professor()
                {
                    Nome = request.Nome
                };
                await _context.Professors.AddAsync(professor);
            }
            await _context.SaveChangesAsync();

            return Created();
        }
        public async Task<IActionResult> Auth()
        {
            return Ok();
        } 
    }
}
