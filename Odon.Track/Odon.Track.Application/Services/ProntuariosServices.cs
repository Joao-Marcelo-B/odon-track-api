using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Odon.Track.Application.Contract.Prontuarios;
using Odon.Track.Application.Data.MySQL;
using Odon.Track.Application.Data.MySQL.Entity;
using Odon.Track.Application.Data.UpdateEntities;
using Odon.Track.Application.Errors;
using Odon.Track.Application.Responses;
using Org.BouncyCastle.Asn1.Ocsp;

namespace Odon.Track.Application.Services
{
    public class ProntuariosServices(OdontrackContext _context) : BaseResponses
    {
        public async Task<IActionResult> PostCadastrarTriagem(PostCadastrarTriagemRequest request)
        {
            var paciente = await _context.Pacientes.FirstOrDefaultAsync(x => x.Id.Equals(request.IdPaciente));
            if (paciente == null)
                return BadRequest(OdonTrackErrors.PacienteNotFound);

            var endereco = await _context.Enderecos.FirstOrDefaultAsync(x => x.IdPaciente.Equals(request.IdPaciente));
            if (endereco == null)
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
                IdEstudanteAssinatura = request.IdEstudanteAssinatura,
                DataCadastro = DateTime.Now
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

        public async Task<IActionResult> PostCadastrarProntuario(PostCadastrarProntuarioRequest request)
        {
            var paciente = await _context.Pacientes.FirstOrDefaultAsync(x => x.Id.Equals(request.IdPaciente));
            if (paciente == null)
                return BadRequest(OdonTrackErrors.PacienteNotFound);

            var prontuario = await _context.Prontuarios.FirstOrDefaultAsync(x => x.IdPaciente.Equals(request.IdPaciente));
            if (prontuario == null)
            {
                prontuario = new Prontuario();
                prontuario.IdPaciente = request.IdPaciente;
                await _context.Prontuarios.AddAsync(prontuario);
                await _context.SaveChangesAsync();
            }

            Prontuario insertDataProntuario = InsertDataProntuario(request);

            prontuario.InsertValueProntuario(insertDataProntuario, prontuario);
            _context.Prontuarios.Update(prontuario);
            await _context.SaveChangesAsync();


            return Created();
        }
        
        private Prontuario InsertDataProntuario(PostCadastrarProntuarioRequest request)
        {
            var prontuario = new Prontuario
            {
                QueixaPrincipal = request.QueixaPrincipal,
                HistoriaDoencaAtual = request.HistoriaDoencaAtual,
            };

            return prontuario;
        }

        public async Task<IActionResult> PathAlterarTriagem(PathAlterarTriagemRequest request)
        {
            var triagem = await _context.Triagens.FirstOrDefaultAsync(x => x.Id.Equals(request.Id));
            if (triagem == null)
                BadRequest(OdonTrackErrors.TriagemNotFound);

            var horario = await _context.HorariosDisponiveisAtendimento.FirstOrDefaultAsync(x => x.IdTriagem.Equals(request.Id));
            horario.SeteMeia = request.HorariosDisponiveisAtendimento.Contains(EHorarioDisponivelAtendimento.sete_meia) ? 1 : 0;
            horario.NoveMeia = request.HorariosDisponiveisAtendimento.Contains(EHorarioDisponivelAtendimento.nove_meia) ? 1 : 0;
            horario.UmaMeia = request.HorariosDisponiveisAtendimento.Contains(EHorarioDisponivelAtendimento.uma_meia) ? 1 : 0;
            horario.TresMeia = request.HorariosDisponiveisAtendimento.Contains(EHorarioDisponivelAtendimento.tres_meia) ? 1 : 0;

            await _context.SaveChangesAsync();

            triagem.EncaminharPeriodo = request.EncaminharPeriodo;
            triagem.EspecializacaoCirurgia = request.EspecializacaoCirurgia ? 1 : 0;
            triagem.EspecializacaoProteseImplante = request.EspecializacaoProteseImplante ? 1 : 0;
            triagem.OutrasEspecializacoes = request.OutrasEspecializacoes;

            await _context.SaveChangesAsync();

            var tratamentos = await _context.NecessidadeTratamentos
                                .Where(x => x.IdTriagem.Equals(triagem.Id))
                                .ToListAsync();
            foreach (var tratamento in tratamentos)
            {
                _context.NecessidadeTratamentos.Remove(tratamento);
            }

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

            return Ok();
        }

        public async Task<IActionResult> GetProntuarios(int pageNumber, int pageSize, string nomePaciente)
        {
            // Construindo a consulta base
            var query = _context.Prontuarios
                                .OrderByDescending(x => x.Id)
                                .Include(x => x.Paciente)
                                .Include(x => x.EstudanteVinculado)
                                .Include(x => x.ProfessorVinculado)
                                .AsQueryable();

            // Aplicando o filtro de nome do paciente, se fornecido
            if (!string.IsNullOrEmpty(nomePaciente))
            {
                query = query.Where(x => x.Paciente.Nome.Contains(nomePaciente));
            }

            // Obtendo o número total de prontuários (para paginação)
            var prontuariosCount = await query.CountAsync();

            // Aplicando paginação
            var prontuarios = await query
                                    .Skip((pageNumber - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            // Selecionando os campos desejados para a resposta
            var response = prontuarios.Select(x => new
            {
                x.Id,
                x.DataCadastro,
                NomePaciente = x.Paciente.Nome,
                NomeEstudante = x.EstudanteVinculado != null ? x.EstudanteVinculado.Nome : "--",
                NomeProfessor = x.ProfessorVinculado != null ? x.ProfessorVinculado.Nome : "--",
                Status = ParseProntuarioStatus(x.IdProntuarioStatus)
            });

            // Retornando a resposta com os resultados paginados e a contagem total
            return Ok(new { Prontuarios = response, Count = prontuariosCount });
        }

        public async Task<IActionResult> GetTriagem(int pageNumber, int pageSize, string nomePaciente)
        {
            // Construindo a consulta base
            var query = _context.Triagens
                                .OrderByDescending(x => x.Id)
                                .Include(x => x.EstudanteAssinatura)
                                .Include(x => x.ProfessorAssinatura)
                                .Include(x => x.Paciente)
                                .AsQueryable();

            // Aplicando o filtro de nome do paciente, se fornecido
            if (!string.IsNullOrEmpty(nomePaciente))
            {
                query = query.Where(x => x.Paciente.Nome.Contains(nomePaciente));
            }

            // Obtendo o número total de triagens (para paginação)
            var triagensCount = await query.CountAsync();

            // Aplicando paginação
            var triagens = await query
                                    .Skip((pageNumber - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            // Selecionando os campos desejados para a resposta
            var response = triagens.Select(x => new
            {
                x.Id,
                x.DataCadastro,
                NomePaciente = x.Paciente.Nome,
                NomeEstudante = x.EstudanteAssinatura != null ? x.EstudanteAssinatura.Nome : "--",
                NomeProfessor = x.ProfessorAssinatura != null ? x.ProfessorAssinatura.Nome : "--",
                Status = "Aprovado"
            });

            // Retornando a resposta com os resultados paginados e a contagem total
            return Ok(new { Triagens = response, Count = triagensCount });
        }


        public async Task<IActionResult> GetTriagemById(int id)
        {
            var triagem = await _context.Triagens.FirstOrDefaultAsync(x => x.Id == id);

            if(triagem == null)
                return BadRequest(OdonTrackErrors.TriagemNotFound);
            var paciente = await _context.Pacientes.FirstOrDefaultAsync(x => x.Id == triagem.IdPaciente);
            var professor = await _context.Professors.FirstOrDefaultAsync(x => x.Id == triagem.IdProfessorAssinatura);
            var estudante = await _context.Estudantes.FirstOrDefaultAsync(x => x.Id == triagem.IdEstudanteAssinatura);
            var tratamentos = await _context.NecessidadeTratamentos
                                .Where(x => x.IdTriagem.Equals(id))
                                .ToListAsync();
            var horarios = await _context.HorariosDisponiveisAtendimento.FirstOrDefaultAsync(x => x.IdTriagem == id);


            GetTriagemResponse response =  new GetTriagemResponse();
            response.Paciente = new Pessoa();
            response.Professor = new Pessoa();
            response.Estudante = new Pessoa();
            response.Tratamentos = new List<Tratamento>();
            response.HorariosDisponiveisAtendimento = new List<Horarios>();
            response.Id = triagem.Id;
            response.EncaminharPeriodo = triagem.EncaminharPeriodo;
            response.OutrasEspecializacoes = triagem.OutrasEspecializacoes;
            response.DataCadastro = triagem.DataCadastro;
            response.EspecializacaoCirurgia = triagem.EspecializacaoCirurgia == 1 ? true : false;
            response.EspecializacaoProteseImplante = triagem.EspecializacaoProteseImplante == 1 ? true : false;
            response.Paciente.Id = paciente != null ? paciente.Id : 0;
            response.Paciente.Nome = paciente != null ? paciente.Nome : "";
            response.Professor.Id = professor != null ? professor.Id : 0;
            response.Professor.Nome = professor != null ? professor.Nome : "";
            response.Estudante.Id = estudante != null ? estudante.Id : 0;
            response.Estudante.Nome = estudante != null ? estudante.Nome : "";

            foreach(var item in tratamentos)
            {
                response.Tratamentos.Add(new Tratamento()
                {
                    TipoTratamento = (ETratamento)Enum.Parse(typeof(ETratamento), item.Tratamento),
                    Descricao = item.Descricao
                });
            }

            if (horarios.SeteMeia == 1)
                response.HorariosDisponiveisAtendimento.Add(new Horarios()
                {
                    Id = "sete_meia",
                    Descricao = "7:30"
                });

            if(horarios.NoveMeia == 1)
                response.HorariosDisponiveisAtendimento.Add(new Horarios()
                {
                    Id = "nove_meia",
                    Descricao = "9:30"
                });

            if (horarios.UmaMeia == 1)
                response.HorariosDisponiveisAtendimento.Add(new Horarios()
                {
                    Id = "uma_meia",
                    Descricao = "13:30"
                });

            if (horarios.TresMeia == 1)
                response.HorariosDisponiveisAtendimento.Add(new Horarios()
                {
                    Id = "tres_meia",
                    Descricao = "15:30"
                });

            return Ok(response);
        }

        public async Task<IActionResult> GetProntoAtendimento(int pageNumber, int pageSize, string nomePaciente)
        {
            // Construindo a consulta base
            var query = _context.ProntuarioProntoAtendimentos
                                .OrderByDescending(x => x.Id)
                                // .Include(x => x.EstudanteVinculado)
                                .Include(x => x.ProfessorVinculado)
                                .Include(x => x.Paciente)
                                .AsQueryable();

            // Aplicando o filtro de nome do paciente, se fornecido
            if (!string.IsNullOrEmpty(nomePaciente))
            {
                query = query.Where(x => x.Paciente.Nome.Contains(nomePaciente));
            }

            // Obtendo o número total de pronto atendimentos (para paginação)
            var prontoAtendimentosCount = await query.CountAsync();

            // Aplicando paginação
            var prontoAtendimentos = await query
                                            .Skip((pageNumber - 1) * pageSize)
                                            .Take(pageSize)
                                            .ToListAsync();

            // Selecionando os campos desejados para a resposta
            var response = prontoAtendimentos.Select(x => new
            {
                x.Id,
                DataCadastro = x.DataFichaFeita,
                NomePaciente = x.Paciente.Nome,
                NomeEstudante = "--", // x.EstudanteVinculado != null ? x.EstudanteVinculado.Nome : "--",
                NomeProfessor = x.ProfessorVinculado != null ? x.ProfessorVinculado.Nome : "--",
                Status = "Aprovado"
            });

            // Retornando a resposta com os resultados paginados e a contagem total
            return Ok(new { ProntoAtendimentos = response, Count = prontoAtendimentosCount });
        }


        public async Task<IActionResult> GetReavaliacaoAnamnese(int idPaciente, int pageNumber, int pageSize)
        {
            if(idPaciente == 0)
                return BadRequest(OdonTrackErrors.PacienteNotFound);

            var reavaliacoesAnamnese = await _context.ReavaliacaoAnamneses.Include(x => x.Paciente)
                                                                        .Where(x => x.IdPaciente.Equals(idPaciente))
                                                                        .OrderByDescending(x => x.Id)
                                                                        .Skip((pageNumber - 1) * pageSize)
                                                                        .Take(pageSize)
                                                                        .ToListAsync();

            var reavaliacaoAnamneseCount = await _context.ReavaliacaoAnamneses.Where(x => x.IdPaciente.Equals(idPaciente)).CountAsync(x => x.IdPaciente.Equals(idPaciente));

            return Ok(new { ReavaliacoesAnamnese = reavaliacoesAnamnese, Count = reavaliacaoAnamneseCount });
        }

        private string ParseProntuarioStatus(int? idProntuarioStatus)
        {
            var status = idProntuarioStatus switch
            {
                1000 => "Prontuario Incompleto",
                _ => ""
            };

            return status;
        }
    }
}
