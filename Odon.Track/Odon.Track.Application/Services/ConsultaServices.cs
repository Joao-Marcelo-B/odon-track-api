using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Odon.Track.Application.Contract.Consultas;
using Odon.Track.Application.Data.MySQL;
using Odon.Track.Application.Data.MySQL.Entity;
using Odon.Track.Application.Errors;
using Odon.Track.Application.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odon.Track.Application.Services
{
    public class ConsultaServices : BaseResponses
    {
        private readonly OdontrackContext _context;
        public ConsultaServices(OdontrackContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> GetConsultas(int pageNumber, int pageSize, string descricao)
        {
            var query = _context.Consultas.AsQueryable();

            if (!string.IsNullOrEmpty(descricao))
            {
                query = query.Where(x => x.Descricao.Contains(descricao));
            }

            var consultasCount = await query.CountAsync();

            var consultas = await query.OrderByDescending(x => x.Id)
                                       .Skip((pageNumber - 1) * pageSize)
                                       .Take(pageSize)
                                       .ToListAsync();

            var response = new List<GetConsultasResponse>();
            foreach (var consulta in consultas)
            {
                var paciente = await _context.Pacientes.FirstOrDefaultAsync(x => x.Id == consulta.IdPaciente);
                response.Add(new()
                {
                    Id = consulta.Id,
                    IdPaciente = consulta.IdPaciente,
                    NomePaciente = paciente != null ? paciente.Nome : "",
                    Descricao = consulta.Descricao,
                    DataConsulta = consulta.DataHoraConsulta.ToString("dd/MM/yyyy"),
                    HoraConsulta = consulta.DataHoraConsulta.ToString("HH:mm"),
                    Realizacao = consulta.Realizacao,
                    Bloqueada = consulta.Bloqueada
                    
                });
            }

            return Ok(new { Consultas = response, Count = consultasCount });
               
        }

        public async Task<IActionResult> PostCadastrarConsulta(PostCadastrarConsultaResquest request)
        {
            string dataHoraConsultaString = $"{request.DataConsulta} {request.HoraConsulta}";

            string formato = "yyyy-MM-dd HH:mm";
            DateTime dataHoraConsulta = DateTime.ParseExact(dataHoraConsultaString, formato, CultureInfo.InvariantCulture);

            if (dataHoraConsulta < DateTime.Now)
                return BadRequest("Data e hora não podem ser menores que a data atual.");

            var consulta = new Consulta()
            {
                IdPaciente = request.IdPaciente,
                Descricao = request.Descricao,
                DataCadastro = DateTime.Now,
                DataHoraConsulta = dataHoraConsulta,
                Realizacao = "A REALIZAR"
            };

            await _context.Consultas.AddAsync(consulta);
            await _context.SaveChangesAsync();

            return Ok();
        }

        public async Task<IActionResult> PatchAtualizarConsulta(PatchAtualizarConsultaResquest request)
        {
            var consulta = await _context.Consultas.FirstOrDefaultAsync(x => x.Id.Equals(request.Id));

            if (consulta == null)
                return BadRequest(OdonTrackErrors.ConsultaNotFound);

            string dataHoraConsultaString = $"{request.DataConsulta} {request.HoraConsulta}";

            string formato = "yyyy-MM-dd HH:mm";
            DateTime dataHoraConsulta = DateTime.ParseExact(dataHoraConsultaString, formato, CultureInfo.InvariantCulture);

            if (consulta.DataHoraConsulta != dataHoraConsulta)
                return BadRequest("Data e hora não podem ser alteradas.");

            consulta.Descricao = request.Descricao;
            consulta.Realizacao = request.Realizacao;
            if (request.Realizacao != "A REALIZAR")
                consulta.Bloqueada = 1;

            await _context.SaveChangesAsync();

            return Ok(consulta);
        }
    }
}
