using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI;
using Newtonsoft.Json;
using Odon.Track.Application.Contract.Auth;
using Odon.Track.Application.Contract.RecoverPassword;
using Odon.Track.Application.Data.MySQL;
using Odon.Track.Application.Data.MySQL.Entity;
using Odon.Track.Application.Responses;

namespace Odon.Track.Application.Services
{
    public class RecoverPasswordServices : BaseResponses
    {
        private static readonly HttpClient client = new HttpClient();
        private readonly OdontrackContext _context;
        public RecoverPasswordServices(OdontrackContext context) 
        {
            _context = context;
        }

        public async Task<IActionResult> GetCode(PostRecoverPasswordRequest email)
        {
            if (email != null && (_context.Usuarios.FirstOrDefault(u => u.Email == email.Email)) != null)
            {
                PostRecoverPasswordResponse aux = new();
                aux.email = email.Email;

                Random random = new Random();
                aux.codigo = random.Next(100000, 1000000).ToString();

                var nomeProfessor = _context.Usuarios
                               .FromSqlInterpolated($"SELECT nome FROM professor p INNER JOIN usuario u on u.id = p.id_usuario WHERE Email = '{email.Email}';")
                               .FirstOrDefault();
                var nomeEstudante = _context.Usuarios
                               .FromSqlInterpolated($"SELECT nome FROM professor p INNER JOIN usuario u on u.id = p.id_usuario WHERE Email = '{email.Email}';")
                               .FirstOrDefault();

                if (nomeProfessor != null)
                    aux.nomeUsuario = nomeProfessor.ToString();
                else if (nomeEstudante != null)
                    aux.nomeUsuario = nomeEstudante.ToString();
                else
                    return BadRequest("Ocorreu um erro interno.");

                var json = JsonConvert.SerializeObject(aux);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var url = "http://127.0.0.1:5000/EnviarEmail";

                var response = await client.PostAsync(url, data);

                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine(result);
                return Ok(result);
            }
            else
            {
                return BadRequest("Esse email não está cadastrado.");
            }
        }
    }
}
