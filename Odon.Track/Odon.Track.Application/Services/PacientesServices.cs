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

            return Ok(new { Pacientes = pacientes.Select(x => new
            {
                x.Nome,
                x.CPF,
                x.IdPacienteStatus,
                x.Ativo
            }), Count = pacientesCount });
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
                Telefone = request.Telefone,
                UFNaturalidade = request.UF,
                CartaoNacionalSus = request.CartaoNacionalSUS,
                CartaoRegionalSus = request.CartaoRegionalSUS,
            };
            await _context.Pacientes.AddAsync(paciente);
            await _context.SaveChangesAsync();

            if(request.ResponsaveisPaciente.Count > 0)
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

        public async Task<IActionResult> PostCadastrarEnderecoPaciente(PostCadastrarEnderecoPacienteRequest request)
        {
            var paciente = await _context.Pacientes.FirstOrDefaultAsync(x => x.Id.Equals(request.IdPaciente));
            if(paciente == null)
                return BadRequest(OdonTrackErrors.PacienteNotFound);

            var endereco = new Endereco()
            {
                Bairro = request.Bairro,
                CEP = request.CEP,
                Cidade = request.Cidade,
                IdPaciente = request.IdPaciente,
                Logradouro = request.Logradouro,
                NumeroCasa = request.NumeroCasa,
                UF = request.UF,
            };
            await _context.Enderecos.AddAsync(endereco);
            await _context.SaveChangesAsync();

            paciente.IdPacienteStatus = 2000;
            await _context.SaveChangesAsync();

            return Created();
        }

        public async Task<IActionResult> PostCadastrarTriagem(PostCadastrarTriagemRequest request)
        {
            var paciente = await _context.Pacientes.FirstOrDefaultAsync(x => x.Id.Equals(request.IdPaciente));
            if(paciente == null)
                return BadRequest(OdonTrackErrors.PacienteNotFound);

            var endereco = await _context.Enderecos.FirstOrDefaultAsync(x => x.IdPaciente.Equals(request.IdPaciente));
            if(endereco == null)
                return BadRequest(OdonTrackErrors.EnderecoPendente);

            var triagemExiste = await _context.Triagens.AnyAsync(x => x.IdPaciente.Equals(request.IdPaciente));
            if (triagemExiste)
                return BadRequest(OdonTrackErrors.TriagemFound);

            var triagem = new Triagem()
            {
                IdPaciente = request.IdPaciente,
                EncaminharPeriodo = request.EncaminharPeriodo,
                EspecializacaoCirurgia = request.EspecializacaoCirurgia ? 1 : 0,
                EspecializacaoProteseImplante = request.EspecializacaoProteseImplante ? 1 : 0,
                IdProfessorAssinatura = request.IdProfessorAssinatura,
                OutrasEspecializacoes = request.OutrasEspecializacoes,
                IdEstudanteAssinatura = request.IdEstudanteAssinatura
            };
            await _context.Triagens.AddAsync(triagem);
            await _context.SaveChangesAsync();

            foreach (var tratamento in request.Tratamentos)
            {

               var necessidadeTratamento = new NecessidadeTratamento()
                {
                    IdTriagem = triagem.Id,
                    Tratamento = tratamento.TipoTratamento.ToString(),
                    Descricao = tratamento.Descricao
                };
                await _context.NecessidadeTratamentos.AddAsync(necessidadeTratamento);
            }
            await _context.SaveChangesAsync();

            var horarioDisponivel = new HorarioDisponivelAtendimento()
            {
                IdTriagem = triagem.Id,
                SeteMeia = request.HorariosDisponiveisAtendimento.Contains(EHorarioDisponivelAtendimento.sete_meia) ? 1 : 0,
                NoveMeia = request.HorariosDisponiveisAtendimento.Contains(EHorarioDisponivelAtendimento.nove_meia) ? 1 : 0,
                UmaMeia = request.HorariosDisponiveisAtendimento.Contains(EHorarioDisponivelAtendimento.uma_meia) ? 1 : 0,
                TresMeia = request.HorariosDisponiveisAtendimento.Contains(EHorarioDisponivelAtendimento.tres_meia) ? 1 : 0,
            };
            await _context.HorariosDisponiveisAtendimento.AddAsync(horarioDisponivel);
            await _context.SaveChangesAsync();

            paciente.IdPacienteStatus = 3000;
            await _context.SaveChangesAsync();

            return Created();
        }
    }
}
