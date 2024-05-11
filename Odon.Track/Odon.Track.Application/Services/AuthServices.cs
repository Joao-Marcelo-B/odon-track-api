using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Odon.Track.Application.Configuration;
using Odon.Track.Application.Contract;
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
            await _context.SaveChangesAsync();

            if (request.TipoUsuario.Equals(2))
            {
                var estudante = new Estudante()
                {
                    IdUsuario = user.Id,
                    Nome = request.Nome,
                };
                await _context.Estudantes.AddAsync(estudante);
            } else if (request.TipoUsuario.Equals(1))
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

            if (!PasswordSaltHasher.VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt))
                return BadRequest(OdonTrackErrors.CredenciaisInvalid);

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_settings.SharedKeyToken);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", EncryptionHelper.Encrypt(user.Id.ToString())) }),
                Expires = DateTime.UtcNow.AddDays(15),
                Issuer = _settings.Issuer,
                Audience = _settings.Issuer,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            var parsedToken = tokenHandler.ReadJwtToken(tokenString);
            var identity = new ClaimsIdentity(parsedToken.Claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);
            await _httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            return Ok(new
            {
                AccessToken = tokenString,
                Expires = tokenDescriptor.Expires
            });
        }
    }
}
