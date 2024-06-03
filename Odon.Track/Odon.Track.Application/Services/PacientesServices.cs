using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Odon.Track.Application.Contract.Pacientes;
using Odon.Track.Application.Data.MySQL;
using Odon.Track.Application.Data.MySQL.Entity;
using Odon.Track.Application.Errors;
using Odon.Track.Application.Responses;

namespace Odon.Track.Application.Services
{
    public class PacientesServices(OdontrackContext _context) : BaseResponses
    {
        public async Task<IActionResult> GetPacientes(int pageNumber, int pageSize)
        {
            var pacientesCount = await _context.Pacientes.CountAsync();

            var pacientes = await _context.Pacientes.OrderBy(x => x.Id).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

            var pacientesList = pacientes.Select(x => new
            {
                x.Id,
                x.Nome,
                x.CPF,
                x.IdPacienteStatus,
                x.DataNascimento,
                x.Ativo
            });

            var response = new List<GetPacientesResponse>();
            foreach (var paciente in pacientesList)
            {
                response.Add(new()
                {
                    Id = paciente.Id,
                    Atividade = paciente.Ativo,
                    Cpf = paciente.CPF,
                    DataNascimento = paciente.DataNascimento.ToString("dd/MM/yyyy"),
                    Nome = paciente.Nome,
                    Status = ParsePacienteStatus(paciente.IdPacienteStatus)
                });
            }

            return Ok(new { Pacientes = response, Count = pacientesCount });
        }

        private string ParsePacienteStatus(int idPacienteStatus)
        {
            switch (idPacienteStatus)
            {
                case 1000:
                    return "Pendente Triagem";
                case 2000:
                    return "Pedente Prontuário";
                case 3000:
                    return "Prontuário Incompleto";
                default:
                    return "";
            }
        }

        public async Task<IActionResult> GetPacienteById(int id)
        {
            var paciente = await _context.Pacientes.FirstOrDefaultAsync(x => x.Id == id);
            if (paciente == null)
                return BadRequest(OdonTrackErrors.EstudanteNotFound);
            else
                return Ok(paciente);
        }

        public async Task<IActionResult> GetPacienteByNome(string nome)
        {
            var pacientes = await _context.Pacientes
                .Where(x => x.Nome.ToLower().Contains(nome.ToLower()))
                .ToListAsync();

            if (!pacientes.Any())
                return Ok(new List<Paciente>());

            return Ok(pacientes);
        }

        public async Task<IActionResult> PostCadastrarPaciente(int idUsuario, PostCadastrarPacienteRequest request)
        {
            if(string.IsNullOrEmpty(request.CPF) || request.CPF.Length != 11)
                return BadRequest(OdonTrackErrors.CPFInvalido);

            var pacienteExist = await _context.Pacientes.AnyAsync(x => x.CPF.Equals(request.CPF));
            if(pacienteExist)
                return BadRequest(OdonTrackErrors.CPFJaCadastrado);

            var paciente = new Paciente()
            {
                Nome = request.Nome,
                IdUsuarioCadastro = idUsuario,
                CPF = request.CPF,
                IdPacienteStatus = 1000,
                DataCadastro = DateTime.Now,
                DataNascimento = request.DataNascimento,
                Naturalidade = request.Naturalidade,
                Profissao = request.Profissao,
                NomeMae = request.NomeMae,
                NomePai = request.NomePai,
                RG = request.RG,
                Ativo = request.Ativadade,
                Telefone = request.Telefone,
                UFNaturalidade = request.UF,
                CartaoNacionalSus = request.CartaoNacionalSUS,
                CartaoRegionalSus = request.CartaoRegionalSUS,
            };
            await _context.Pacientes.AddAsync(paciente);
            await _context.SaveChangesAsync();

            var endereco = new Endereco()
            {
                Bairro = request.Bairro,
                CEP = request.CEP,
                Cidade = request.Cidade,
                IdPaciente = paciente.Id,
                Logradouro = request.Logradouro,
                NumeroCasa = request.NumeroCasa,
                UF = request.UF,
            };
            await _context.Enderecos.AddAsync(endereco);
            await _context.SaveChangesAsync();

            paciente.IdPacienteStatus = 2000;
            await _context.SaveChangesAsync();

            if (request.ResponsaveisPaciente.Count > 0)
            {
                foreach(var responsavel in request.ResponsaveisPaciente)
                {
                    var responsavelPaciente = new Responsavel()
                    {
                        IdPaciente = paciente.Id,
                        CPF = responsavel.CPF,
                        Email = responsavel.Email,
                        Nome = responsavel.Nome,
                        Telefone = responsavel.Telefone
                    };
                    await _context.Responsaveis.AddAsync(responsavelPaciente);
                }
                await _context.SaveChangesAsync();
            }

            return Created(new { idPaciente = paciente.Id });
        }
    }
}
