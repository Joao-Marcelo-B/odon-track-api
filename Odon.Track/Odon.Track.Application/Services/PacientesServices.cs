using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Odon.Track.Application.Contract.Pacientes;
using Odon.Track.Application.Data.MySQL;
using Odon.Track.Application.Data.MySQL.Entity;
using Odon.Track.Application.Errors;
using Odon.Track.Application.Responses;
using System.Runtime.ConstrainedExecution;

namespace Odon.Track.Application.Services
{
    public class PacientesServices(OdontrackContext _context) : BaseResponses
    {
        public string FormatarCpf(string cpf)
        {
            return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        }

        public async Task<IActionResult> GetPacientes(int pageNumber, int pageSize, string nome)
        {
            var query = _context.Pacientes.AsQueryable();

            if (!string.IsNullOrEmpty(nome))
            {
                query = query.Where(x => x.Nome.Contains(nome));
            }

            var pacientesCount = await query.CountAsync();

            var pacientes = await query.OrderByDescending(x => x.Id)
                                       .Skip((pageNumber - 1) * pageSize)
                                       .Take(pageSize)
                                       .ToListAsync();

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
                response.Add(new GetPacientesResponse()
                {
                    Id = paciente.Id,
                    Atividade = paciente.Ativo,
                    Cpf = FormatarCpf(paciente.CPF),
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
                .Where(x => x.Nome.ToLower().Contains(nome.ToLower()) && x.Ativo == 1)
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
                Ativo = request.Ativo,
                NecessitaResponsavel = request.NecessitaResponsavel,
                Telefone = request.Telefone,
                UFNaturalidade = request.UFNaturalidade.ToUpper(),
                CartaoNacionalSUS = request.CartaoNacionalSUS,
                CartaoRegionalSUS = request.CartaoRegionalSUS,
                Sexo = request.Sexo,
                SexoOutro = request.SexoOutro,
                GrupoEtnico = request.GrupoEtnico,
                DataExpedicaoRG = request.DataExpedicaoRG,
                EstadoCivil = request.EstadoCivil,
                MoraCom = request.MoraCom,
                MoraComOutro = request.MoraComOutro,
                Escola = request.Escola,
                Serie = request.Serie,
                Turno = request.Turno,
                Indicacao = request.Indicacao,
            };
            await _context.Pacientes.AddAsync(paciente);
            await _context.SaveChangesAsync();

            return Created(new { paciente });
        }
        public async Task<IActionResult> PostCadastrarEnderecoPaciente(PostCadastrarEnderecoPacienteRequest request)
        {
            var paciente = await _context.Pacientes.FirstOrDefaultAsync(x => x.Id.Equals(request.IdPaciente));
            if (paciente == null)
                return BadRequest(OdonTrackErrors.PacienteNotFound);

            var endereco = new Endereco()
            {
                IdPaciente = request.IdPaciente,
                NumeroCasa = request.NumeroCasa,
                Logradouro = request.Logradouro,
                Bairro = request.Bairro,
                Cidade = request.Cidade,
                UF = request.UF.ToUpper(),
                CEP = request.CEP,
            };

            await _context.Enderecos.AddAsync(endereco);
            await _context.SaveChangesAsync();

            return Created(new { idEndereco = endereco.Id });
        }
        public async Task<IActionResult> PostCadastrarResponsavelPaciente(PostCadastrarResponsavelPaciente request)
        {
            var paciente = await _context.Pacientes.FirstOrDefaultAsync(x => x.Id.Equals(request.IdPaciente));
            if (paciente == null)
                return BadRequest(OdonTrackErrors.PacienteNotFound);

            var responsavel = new Responsavel()
            {
                IdPaciente = request.IdPaciente,
                Nome = request.Nome,
                CPF = request.CPF,
                Telefone1 = request.Telefone1,
                Telefone2 = request.Telefone2,
                Email = request.Email,
            };

            await _context.Responsaveis.AddAsync(responsavel);
            await _context.SaveChangesAsync();

            return Created(new { idResponsavel = responsavel.Id });
        }
        public async Task<IActionResult> PostCadastrarEnderecoResposavel(PostCadastrarEnderecoResponsavel request)
        {
            var responsavel = await _context.Responsaveis.FirstOrDefaultAsync(x => x.Id.Equals(request.IdResponsavel));

            if (responsavel == null)
                return BadRequest(OdonTrackErrors.ResponsavelNotFound);

            var endereco = new EnderecoResponsavel()
            {
                IdResponsavel = request.IdResponsavel,
                IdPaciente = request.IdPaciente,
                NumeroCasa = request.NumeroCasa,
                Logradouro = request.Logradouro,
                Bairro = request.Bairro,
                Cidade = request.Cidade,
                UF = request.UF.ToUpper(),
                CEP = request.CEP,
            };

            await _context.EnderecosResponsavel.AddAsync(endereco);
            await _context.SaveChangesAsync();

            return Created(new { idEndereco = endereco.Id });
        }
        public async Task<IActionResult> PatchAtualizarPaciente(PathAtualizarPacienteRequest request)
        {
            if (string.IsNullOrEmpty(request.CPF) || request.CPF.Length != 11)
                return BadRequest(OdonTrackErrors.CPFInvalido);

            var pacienteExist = await _context.Pacientes.FirstOrDefaultAsync(x => x.CPF.Equals(request.CPF));
            if (pacienteExist != null)
                if(pacienteExist.Id != request.Id)
                    return BadRequest(OdonTrackErrors.CPFJaCadastrado);

            var paciente = await _context.Pacientes.FirstOrDefaultAsync(x => x.Id.Equals(request.Id));
            if (paciente == null)
                return BadRequest(OdonTrackErrors.PacienteNotFound);

            paciente.Nome = request.Nome;
            paciente.CPF = request.CPF;
            paciente.DataNascimento = request.DataNascimento;
            paciente.Naturalidade = request.Naturalidade;
            paciente.Profissao = request.Profissao;
            paciente.NomeMae = request.NomeMae;
            paciente.NomePai = request.NomePai;
            paciente.RG = request.RG;
            paciente.Ativo = request.Ativo;
            paciente.NecessitaResponsavel = request.NecessitaResponsavel;
            paciente.Telefone = request.Telefone;
            paciente.UFNaturalidade = request.UFNaturalidade;
            paciente.CartaoNacionalSUS = request.CartaoNacionalSUS;
            paciente.CartaoRegionalSUS = request.CartaoRegionalSUS;
            paciente.Sexo = request.Sexo;
            paciente.SexoOutro = request.SexoOutro;
            paciente.GrupoEtnico = request.GrupoEtnico;
            paciente.DataExpedicaoRG = request.DataExpedicaoRG;
            paciente.EstadoCivil = request.EstadoCivil;
            paciente.MoraCom = request.MoraCom;
            paciente.MoraComOutro = request.MoraComOutro;
            paciente.Escola = request.Escola;
            paciente.Serie = request.Serie;
            paciente.Turno = request.Turno;
            paciente.Indicacao = request.Indicacao;

            await _context.SaveChangesAsync();

            return Ok(paciente);
        }
        public async Task<IActionResult> PatchAtualizarEnderecoPaciente(PathAtualizarEnderecoPaciente request)
        {
            var endereco = await _context.Enderecos.FirstOrDefaultAsync(x => x.Id.Equals(request.Id));
            if (endereco == null)
                return BadRequest(OdonTrackErrors.EnderecoNotFound);

            endereco.NumeroCasa = request.NumeroCasa;
            endereco.Logradouro = request.Logradouro;
            endereco.Bairro = request.Bairro;
            endereco.Cidade = request.Cidade;
            endereco.UF = request.UF.ToUpper();
            endereco.CEP = request.CEP;

            await _context.SaveChangesAsync();

            return Ok();

        }
        public async Task<IActionResult> PatchAtualizarResponsavelPaciente(PathAtualizarResponsavelPaciente request)
        {
            var responsavel = await _context.Responsaveis.FirstOrDefaultAsync(x => x.Id.Equals(request.Id));
            if (responsavel == null)
                return BadRequest(OdonTrackErrors.ResponsavelNotFound);

            responsavel.Nome = request.Nome;
            responsavel.CPF = request.CPF;
            responsavel.Telefone1 = request.Telefone1;
            responsavel.Telefone2 = request.Telefone2;
            responsavel.Email = request.Email;

            await _context.SaveChangesAsync();
            
            return Ok();
        }
        public async Task<IActionResult> PatchAtualizarEnderecoRenponsavel(PathAtualizarEnderecoResponsavel request)
        {
            var endereco = await _context.EnderecosResponsavel.FirstOrDefaultAsync(x => x.Id.Equals(request.Id));
            if(endereco == null)
                return BadRequest(OdonTrackErrors.EnderecoNotFound);

            endereco.IdResponsavel = request.IdResponsavel;
            endereco.NumeroCasa = request.NumeroCasa;
            endereco.Logradouro = request.Logradouro;
            endereco.Bairro = request.Bairro;
            endereco.Cidade = request.Cidade;
            endereco.UF = request.UF.ToUpper();
            endereco.CEP = request.CEP;

            await _context.SaveChangesAsync();

            return Ok();
        }
        public async Task<IActionResult> DeleteEnderecoPaciente(int id)
        {
            var endereco = await _context.Enderecos.FirstOrDefaultAsync(x => x.Id == id);

            if (endereco == null)
                return BadRequest(OdonTrackErrors.EnderecoNotFound);

            _context.Enderecos.Remove(endereco);
            await _context.SaveChangesAsync();

            return Ok();
        }
        public async Task<IActionResult> DeleteResponsavelPaciente(int id)
        {
            var responsavel = await _context.Responsaveis.FirstOrDefaultAsync(x => x.Id == id);

            if (responsavel == null)
                return BadRequest(OdonTrackErrors.ResponsavelNotFound);

            var enderecos = await _context.EnderecosResponsavel.Where(x => x.IdResponsavel == id).ToListAsync();
            foreach(var endereco in enderecos)
            {
                _context.EnderecosResponsavel.Remove(endereco);
                await _context.SaveChangesAsync();
            }

            _context.Responsaveis.Remove(responsavel);
            await _context.SaveChangesAsync();

            return Ok();
        }
        public async Task<IActionResult> DeleteEnderecoResposavel(int id)
        {
            var endereco = await _context.EnderecosResponsavel.FirstOrDefaultAsync(x => x.Id == id);

            if (endereco == null)
                return BadRequest(OdonTrackErrors.EnderecoNotFound);

            _context.EnderecosResponsavel.Remove(endereco);
            await _context.SaveChangesAsync();

            return Ok();
        }
        public async Task<IActionResult> GetEnderecoPaciente(int idPaciente)
        {
            var enderecos = await _context.Enderecos.Where(x => x.IdPaciente == idPaciente).ToListAsync();

            return Ok(enderecos);
        }
        public async Task<IActionResult> GetResponsavelPaciente(int idPaciente)
        {
            var responsaveis = await _context.Responsaveis.Where(x => x.IdPaciente == idPaciente).ToListAsync();

            return Ok(responsaveis);
        }
        public async Task<IActionResult> GetEnderecoResposavel(int idPaciente)
        {
            var responsaveis = await _context.Responsaveis.Where(x => x.IdPaciente == idPaciente).ToListAsync();
            var enderecos = new List<GetEnderecoResponsaveisResponse>();
            foreach(var respon in responsaveis)
            {
                var enderecosList = await _context.EnderecosResponsavel.Where(x => x.IdResponsavel == respon.Id).ToListAsync();
                if (enderecosList != null)
                    foreach(var end in enderecosList)
                        enderecos.Add(new()
                        {
                            Id = end.Id,
                            IdResponsavel = end.IdResponsavel,
                            NomeResponsavel = respon.Nome,
                            NumeroCasa = end.NumeroCasa,
                            Logradouro = end.Logradouro,
                            Bairro = end.Bairro,
                            Cidade = end.Cidade,
                            UF = end.UF.ToUpper(),
                            CEP = end.CEP,
                        });   
            }

            return Ok(enderecos);
        }
    }
}
