using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Odon.Track.Application.Configuration;
using Odon.Track.Application.Contract.Auth;
using Odon.Track.Application.Contract.RecoverPassword;
using Odon.Track.Application.Crypto;
using Odon.Track.Application.Data.MySQL;
using Odon.Track.Application.Data.MySQL.Entity;
using Odon.Track.Application.Responses;

namespace Odon.Track.Application.Services
{
    public class RecoverPasswordServices : BaseResponses
    {
        private static readonly HttpClient client = new HttpClient();
        private readonly OdontrackContext _context;
        private readonly AppSettings _settings;
        public RecoverPasswordServices(OdontrackContext context, AppSettings settings)
        {
            _context = context;
            _settings = settings;
        }

        public async Task<IActionResult> GetCode(PostRecoverPasswordRequest email)
        {
            if (email != null && (_context.Usuarios.FirstOrDefault(u => u.Email == email.Email)) != null)
            {
                CodigoSeguranca codigoSeguranca = new CodigoSeguranca();
                PostRecoverPasswordResponse aux = new();
                aux.email = email.Email;
                Random random = new Random();
                aux.codigo = random.Next(100000, 1000000).ToString();
                aux.numeroUnifenas = "(35) 98888-8888";

                var usuario = await _context.Usuarios
                    .FirstOrDefaultAsync(u => u.Email == email.Email);
                var nomeProfessor = await _context.Professors.FirstOrDefaultAsync(p => p.IdUsuario == usuario.Id);
                var nomeEstudante = await _context.Estudantes.FirstOrDefaultAsync(p => p.IdUsuario == usuario.Id);

                if (nomeProfessor != null)
                    aux.nomeUsuario = nomeProfessor.Nome.ToString();
                else if (nomeEstudante != null)
                    aux.nomeUsuario = nomeEstudante.Nome.ToString();
                else
                    return BadRequest("Ocorreu um erro interno.");

                var json = JsonConvert.SerializeObject(aux);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var url = $"{_settings.ApiPython}/EnviarEmail";
                var response = await client.PostAsync(url, data);
                string result = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    codigoSeguranca.Email = aux.email;
                    codigoSeguranca.Validade = DateTime.Now.AddMinutes(7);
                    codigoSeguranca.Codigo = int.Parse(aux.codigo);
                    codigoSeguranca.Id = await _context.CodigoSeguranca
                        .OrderByDescending(i => i.Id)
                            .Select(i => (int?)i.Id)
                            .FirstOrDefaultAsync() ?? 0;
                    codigoSeguranca.Id += 1;
                    _context.CodigoSeguranca.Add(codigoSeguranca);
                    _context.SaveChanges();
                    codigoSeguranca.Codigo = 0;
                    return Ok(codigoSeguranca);
                }
                else
                    return BadRequest("Ocorreu um erro com a API para envio de emails.");               
            }
            else
            {
                return BadRequest("Esse email não está cadastrado.");
            }
        }

        public async Task<IActionResult> CompareCode(PostRecoverPasswordCompareCodeRequest obj)
        {
            var codigoSeguranca = await _context.CodigoSeguranca.FirstOrDefaultAsync(cs => cs.Id == obj.Id);
            if (codigoSeguranca == null)
                return BadRequest("Ocorreu um erro interno.");
            else if (codigoSeguranca.Codigo == obj.Codigo && DateTime.Now < codigoSeguranca.Validade)
                return Ok(codigoSeguranca);
            else
                return BadRequest("O código está incorreto ou já foi expirado.");
        }

        public async Task<IActionResult> ChangePassword(PatchRecoverPasswordChangePassword request)
        {
            var usuarioSelecionado = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == request.Email);
            byte[] passwordHash, passwordSatl;
            PasswordSaltHasher.CreatePasswordHashAndSalt(request.Password, out passwordHash, out passwordSatl);

            if (usuarioSelecionado == null)
                return BadRequest("Não foi possível processar a sua solicitação.");
            else
            {
                usuarioSelecionado.PasswordHash = passwordHash;
                usuarioSelecionado.PasswordSalt = passwordSatl;
                _context.Usuarios.Update(usuarioSelecionado);
                await _context.SaveChangesAsync();
                return Ok("Senha alterada com sucesso");
            }          
        }
    }
}
