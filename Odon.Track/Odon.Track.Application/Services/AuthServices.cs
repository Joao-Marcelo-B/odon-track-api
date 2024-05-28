using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Odon.Track.Application.Authorization;
using Odon.Track.Application.Configuration;
using Odon.Track.Application.Contract.Auth;
using Odon.Track.Application.Crypto;
using Odon.Track.Application.Data.MySQL;
using Odon.Track.Application.Data.MySQL.Entity;
using Odon.Track.Application.Errors;
using Odon.Track.Application.Responses;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Odon.Track.Application.Services
{
    public class AuthServices(OdontrackContext _context, AppSettings _settings) : BaseResponses
    {
        public async Task<IActionResult> Signup(PostSignupRequest request)
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
                return BadRequest(OdonTrackErrors.IdentificadorUsed);

            //TODO: Talvez validar codigo enviado ao email

            byte[] passwordHash, passwordSatl;
            PasswordSaltHasher.CreatePasswordHashAndSalt(request.Password, out passwordHash, out passwordSatl);

            var user = new Usuario()
            {
                Email = request.Email,
                IdTipoUsuario = request.TipoUsuario,
                IdentificadorUnifenas = request.Identificador,
                Blocked = 1,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSatl,
            };
            await _context.Usuarios.AddAsync(user);
            await _context.SaveChangesAsync();

            if (request.TipoUsuario.Equals(3))
            {
                var estudante = new Estudante()
                {
                    IdUsuario = user.Id,
                    Nome = request.Nome,
                };
                await _context.Estudantes.AddAsync(estudante);
            } else if (request.TipoUsuario.Equals(1) || request.TipoUsuario.Equals(2))
            {
                var professor = new Professor()
                {
                    Nome = request.Nome,
                    IdUsuario = user.Id,
                };
                await _context.Professors.AddAsync(professor);
            }
            await _context.SaveChangesAsync();

            return Created();
        }

        public async Task<IActionResult> Auth(PostAuthRequest request, HttpContext _httpContext)
        {
            if (!request.Email.Contains("unifenas"))
                return BadRequest(OdonTrackErrors.EmailUnifenasInvalid);

            var user = await _context.Usuarios.FirstOrDefaultAsync(x => x.Email.Equals(request.Email));
            if (user == null)
                return BadRequest(OdonTrackErrors.UsuarioNotFound);

            if (user.Blocked == 1)
                return BadRequest(OdonTrackErrors.UsuarioBlocked);

            if (!PasswordSaltHasher.VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt))
                return BadRequest(OdonTrackErrors.CredenciaisInvalid);

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_settings.SharedKeyToken);

            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.NameIdentifier, EncryptionHelper.Encrypt(user.Id.ToString())));

            var professor = await _context.Professors.FirstOrDefaultAsync(x => x.IdUsuario.Equals(user.Id));
            if(professor != null)
            {
                if(user.IdTipoUsuario.Equals(1))
                    claims.Add(new Claim( ClaimTypes.Role, RolesForUsers.Administrador));
                claims.Add(new Claim( ClaimTypes.Role, RolesForUsers.Professor ));
            }

            var estudante = await _context.Estudantes.FirstOrDefaultAsync(x => x.IdUsuario.Equals(user.Id));
            if(estudante != null)
            {
                claims.Add(new Claim(ClaimTypes.Role, RolesForUsers.Estudante));
                var query = from rs in _context.RolesSemestre
                            join r in _context.Roles on rs.IdRole equals r.Id
                            where rs.Periodo == estudante.PeriodoAtual
                            select r.Name;

                var roles = query.ToList();

               foreach( var role in query.ToList())
                    claims.Add(new Claim(ClaimTypes.Role, role));
            }
            string nomeUsuario = estudante != null ? estudante.Nome : professor.Nome;

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddDays(15),
                Issuer = _settings.Issuer,
                Audience = _settings.Issuer,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return Ok(new
            {
                IdUsuario = user.Id,
                IdTipoUsuario = user.IdTipoUsuario,
                Nome = nomeUsuario,
                AccessToken = tokenString,
                Expires = tokenDescriptor.Expires
            });
        }

        public async Task<IActionResult> AutorizarUsuario(PatchAutorizarUsuarioRequest request)
        {
            var user = await _context.Usuarios.FirstOrDefaultAsync(x => x.Id.Equals(request.IdUsuario));
            if (user == null)
                return BadRequest(OdonTrackErrors.UsuarioNotFound);

            var estudante = await _context.Estudantes.FirstOrDefaultAsync(x => x.IdUsuario.Equals(user.Id));
            var professor = await _context.Professors.FirstOrDefaultAsync(x => x.IdUsuario.Equals(user.Id));
            if(estudante == null && professor == null)
                return BadRequest(OdonTrackErrors.UsuarioNotFound);

            user.Blocked = 0;
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
