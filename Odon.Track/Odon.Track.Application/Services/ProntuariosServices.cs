using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Odon.Track.Application.Contract.Pacientes;
using Odon.Track.Application.Data.MySQL;
using Odon.Track.Application.Data.MySQL.Entity;
using Odon.Track.Application.Errors;
using Odon.Track.Application.Responses;

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
