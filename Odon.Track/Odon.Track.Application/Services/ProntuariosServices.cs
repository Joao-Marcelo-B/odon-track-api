using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Odon.Track.Application.Contract.Prontuarios;
using Odon.Track.Application.Data.MySQL;
using Odon.Track.Application.Data.MySQL.Entity;
using Odon.Track.Application.Data.UpdateEntities;
using Odon.Track.Application.Errors;
using Odon.Track.Application.Responses;
using Odon.Track.Application.ConvertTypes;
using Microsoft.IdentityModel.Tokens;
using System.Linq;
using Org.BouncyCastle.Asn1.Ocsp;

namespace Odon.Track.Application.Services;

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

        var usuario = await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == request.IdUsuario);

        if (usuario == null)
            return BadRequest("Erro de usuario");

        Professor professor = null;
        Estudante estudante = null;
        if (usuario.IdTipoUsuario == 1 || usuario.IdTipoUsuario == 2)
            professor = await _context.Professors.FirstOrDefaultAsync(x => x.IdUsuario == usuario.Id);
        else
            estudante = await _context.Estudantes.FirstOrDefaultAsync(x => x.IdUsuario == usuario.Id);


        var triagem = new Triagem()
        {
            IdPaciente = request.IdPaciente,
            EncaminharPeriodo = request.EncaminharPeriodo,
            EspecializacaoCirurgia = request.EspecializacaoCirurgia ? 1 : 0,
            EspecializacaoProteseImplante = request.EspecializacaoProteseImplante ? 1 : 0,
            OutrasEspecializacoes = request.OutrasEspecializacoes,
            IdProfessorAssinatura = professor != null ? professor.Id : null,
            IdEstudanteAssinatura = estudante != null ? estudante.Id : null,
            Status = request.Status.ToString(),
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

    public async Task<IActionResult> PostCadastrarProntuario(PostCadastrarProntuarioRequest request, int idUsuario)
    {
        
        var paciente = await _context.Pacientes.FirstOrDefaultAsync(x => x.Id.Equals(request.Paciente.Id));
        if (paciente == null)
            return BadRequest(OdonTrackErrors.PacienteNotFound);

        var usuario = await _context.Usuarios.FirstOrDefaultAsync(x => x.Id.Equals(idUsuario));
        if(usuario == null)
            return BadRequest(OdonTrackErrors.UsuarioNotFound);

        var prontuario = await _context.Prontuarios.FirstOrDefaultAsync(x => x.IdPaciente.Equals(request.Paciente.Id));
        if (prontuario == null)
        {
            prontuario = new Prontuario();
            prontuario.IdPaciente = request.Paciente.Id;
            prontuario.DataCadastro = DateTime.Now;
            prontuario.IdProntuarioStatus = 1000;

            if(usuario.IdTipoUsuario == 1 || usuario.IdTipoUsuario == 2)
            {
                prontuario.IdProfessorVinculado = idUsuario;
                prontuario.AssinadoProfessor = 1;
            }
            else
                prontuario.IdEstudanteVinculado = idUsuario;

            

            await _context.Prontuarios.AddAsync(prontuario);
            await _context.SaveChangesAsync();
        }
        
        Prontuario updateDataProntuario = InsertDataProntuario(request);

        prontuario.UpdateValueProntuario(updateDataProntuario);

        await UpdateEndodontia(request, prontuario.Id);

        await InsertDescricaoDentes(request.DescricaoDente, prontuario.Id);

        await InsertDiagnosticoDente(request.DiagnosticosDente, prontuario.Id);

        await InsertReavaliacaoAnamnese(request.ReavaliacaoAnamnese, prontuario.Id);

        _context.Prontuarios.Update(prontuario);
        await _context.SaveChangesAsync();

        return Updated();
    }

    private async Task InsertReavaliacaoAnamnese(List<ReavaliacaoDeAnamnese> reavaliacaoDeAnamneses, int idProntuario)
    {
        if (reavaliacaoDeAnamneses == null || reavaliacaoDeAnamneses.Count <= 0)
            return;

        var reavaliacaoOld = await _context.ReavaliacaoAnamneses.Where(x => x.IdProntuario.Equals(idProntuario)).ToListAsync();
        if (reavaliacaoOld != null && reavaliacaoOld.Count > 0)
            _context.ReavaliacaoAnamneses.RemoveRange(reavaliacaoOld);

        await _context.SaveChangesAsync();

        foreach (var reavaliacao in reavaliacaoDeAnamneses)
        {
            ReavaliacaoAnamnese reavaliacaoAnamnese = new ReavaliacaoAnamnese
            {
                IdProntuario = idProntuario,
                Data = reavaliacao.DataReavaliacao,
                FrequenciaRespiratoria = reavaliacao.FrequenciaRespiratoria,
                Medicamentos = reavaliacao.Medicamentos,
                Observacoes = reavaliacao.Observacoes,
                PressaoArterial = reavaliacao.PressaoArterial,
                Pulso = reavaliacao.Pulso,
                TemperaturaAxilar = reavaliacao.TemperaturaAxilar
            };
            await _context.ReavaliacaoAnamneses.AddAsync(reavaliacaoAnamnese);
        }
        await _context.SaveChangesAsync();
    }

    private async Task UpdateEndodontia(PostCadastrarProntuarioRequest request, int idProntuario)
    {
        if(request.Endodontia == null || request.Endodontia.Count <= 0)
            return;

        var endodontiaOld = await _context.Endodontias.Where(x => x.IdProntuario.Equals(idProntuario)).ToListAsync();
        if(endodontiaOld != null && endodontiaOld.Count > 0)
            _context.Endodontias.RemoveRange(endodontiaOld);

        await _context.SaveChangesAsync();

        foreach (var endo in request.Endodontia)
        {
            EndodontiaEntity endodontia = new EndodontiaEntity
            {
                IdProntuario = idProntuario,
                Dente = endo.Dente
            };
            await _context.Endodontias.AddAsync(endodontia);
            await _context.SaveChangesAsync();

            var updateEndodontia = InsertDataEndodontia(endo);

            endodontia.UpdateValueEndodontia(updateEndodontia);

            await InsertOdontometria(endo.Odontometria, idProntuario, endodontia.Id);

            await InsertRetorno(endodontia.Id, endo.Retornos);
        }
    }

    private async Task InsertRetorno(int idEndodontia, List<Retorno> retornos)
    {
        foreach (var item in retornos)
        {
            RetornoEntity retorno = null;
            if (item.Id > 0)
            {
                retorno = await _context.RetornosEntity.FirstOrDefaultAsync(x => x.Id.Equals(item.Id));
                if (retorno == null)
                {
                    retorno = new RetornoEntity
                    {
                        IdEndodontia = idEndodontia,
                        DataRetorno = item.DataRetorno
                    };
                    await _context.RetornosEntity.AddAsync(retorno);
                }
                retorno.DataRetorno = item.DataRetorno;
            }
            else
            {
                retorno = new RetornoEntity
                {
                    IdEndodontia = idEndodontia,
                    DataRetorno = item.DataRetorno
                };
                await _context.RetornosEntity.AddAsync(retorno);
            }
        }

        await _context.SaveChangesAsync();
    }

    private async Task InsertOdontometria(List<Odontometria> odontometrias, int idProntuario, int idEndodontia)
    {
        foreach (var odontometria in odontometrias)
        {
            OdontometriaEntity odontometriaEntity = null;
            if (odontometria.Id > 0)
            {
                odontometriaEntity = await _context.Odontometrias.FirstOrDefaultAsync(x => x.Id.Equals(odontometria.Id));
                if (odontometriaEntity == null)
                {
                    odontometriaEntity = new OdontometriaEntity
                    {
                        IdProntuario = idProntuario,
                        IdEndodontia = idEndodontia,
                    };
                    await _context.Odontometrias.AddAsync(odontometriaEntity);
                }
            }
            else
            {
                odontometriaEntity = new OdontometriaEntity
                {
                    IdProntuario = idProntuario,
                    IdEndodontia = idEndodontia,
                    CAD = odontometria.CAD,
                    Canal = odontometria.Canal,
                    CRD = odontometria.CRD,
                    CRT = odontometria.CRT,
                    DiametroAnatomico = odontometria.DiametroAnatomico,
                    DiametroCirurgico = odontometria.DiametroCirurgico,
                    PontoDeRefencia = odontometria.PontoDeReferenciaPontoDeReferencia
                };
                await _context.Odontometrias.AddAsync(odontometriaEntity);

            }
            odontometriaEntity.CAD = odontometria.CAD;
            odontometriaEntity.Canal = odontometria.Canal;
            odontometriaEntity.CRD = odontometria.CRD;
            odontometriaEntity.CRT = odontometria.CRT;
            odontometriaEntity.DiametroAnatomico = odontometria.DiametroAnatomico;
            odontometriaEntity.DiametroCirurgico = odontometria.DiametroCirurgico;
            odontometriaEntity.PontoDeRefencia = odontometria.PontoDeReferenciaPontoDeReferencia;
        }
        await _context.SaveChangesAsync();
    }

    //private async Task InsertOdontometria(Odontometria newOdontometria,int idProntuario, int idEndodontia)         
    //{
    //    if(newOdontometria == null)
    //        return;

    //    Type type = typeof(Odontometria);
    //    foreach(var property in type.GetProperties())
    //    {
    //        switch(property.Name)
    //        {
    //            case nameof(ETipoOdontometria.Canal):
    //                if(newOdontometria.Canal == null)
    //                    break;
    //                await InsertOdontometriaDescricoes(idProntuario, idEndodontia, property.Name, newOdontometria.Canal);
    //                break;
    //            case nameof(ETipoOdontometria.CAD):
    //                await InsertOdontometriaDescricoes(idProntuario, idEndodontia, property.Name, newOdontometria.CAD);
    //                break;
    //            case nameof(ETipoOdontometria.CRD):
    //                await InsertOdontometriaDescricoes(idProntuario, idEndodontia, property.Name, newOdontometria.CRD);
    //                break;
    //            case nameof(ETipoOdontometria.CRT):
    //                await InsertOdontometriaDescricoes(idProntuario, idEndodontia, property.Name, newOdontometria.CRT);
    //                break;
    //            case nameof(ETipoOdontometria.DiametroAnatomico):
    //                await InsertOdontometriaDescricoes(idProntuario, idEndodontia, property.Name, newOdontometria.DiametroAnatomico);
    //                break;
    //            case nameof(ETipoOdontometria.DiametroCirurgico):
    //                await InsertOdontometriaDescricoes(idProntuario, idEndodontia, property.Name, newOdontometria.DiametroCirurgico);
    //                break;
    //            case nameof(ETipoOdontometria.PontoDeReferenciaPontoDeReferencia):
    //                await InsertOdontometriaDescricoes(idProntuario, idEndodontia, property.Name, newOdontometria.PontoDeReferenciaPontoDeReferencia);
    //                break;
    //        }
    //    }
    //}

    //private async Task InsertOdontometriaDescricoes(int idProntuario, int idEndodontia ,string tipo, Dictionary<int, string> descricao)
    //{
    //    foreach(var key in descricao.Keys)
    //    {
    //        var odontometria = await _context.Odontometrias.FirstOrDefaultAsync(x => x.IdProntuario.Equals(idProntuario) && x.TipoOdontometria.Equals(tipo) && x.IndexDaColuna.Equals(key));
    //        if (odontometria == null)
    //        {
    //            odontometria = new OdontometriaEntity
    //            {
    //                IdProntuario = idProntuario,
    //                TipoOdontometria = tipo,
    //                IndexDaColuna = key,
    //                Descricao = descricao[key]
    //            };
    //            await _context.Odontometrias.AddAsync(odontometria);
    //        }

    //        odontometria.Descricao = descricao[key];
    //    }

    //    await _context.SaveChangesAsync();
    //}

    private async Task InsertDiagnosticoDente(DiagnosticosDente diagnosticosDente, int idProntuario)
    {
        if(diagnosticosDente == null)
            return;

        if (diagnosticosDente.Gengivite == null ||
            diagnosticosDente.PeriodontiteLeve == null ||
            diagnosticosDente.PeriodontiteGrave == null ||
            diagnosticosDente.EComplicada == null)
            return;

        Type typeDiag = typeof(DiagnosticosDente);
        foreach (var property in typeDiag.GetProperties())
        {                
            switch (property.Name)
            {
                case nameof(ETipoDiagnostico.Gengivite):
                    await InsertDiagnostigoDenteTipo(property.Name, idProntuario, diagnosticosDente.Gengivite);
                    break;
                case nameof(ETipoDiagnostico.PeriodontiteLeve):
                    await InsertDiagnostigoDenteTipo(property.Name, idProntuario, diagnosticosDente.PeriodontiteLeve);
                    break;
                case nameof(ETipoDiagnostico.PeriodontiteGrave):
                    await InsertDiagnostigoDenteTipo(property.Name, idProntuario, diagnosticosDente.PeriodontiteGrave);
                    break;
                case nameof(ETipoDiagnostico.EComplicada):
                    await InsertDiagnostigoDenteTipo(property.Name, idProntuario, diagnosticosDente.EComplicada);
                    break;
            }   
        }

        
    }

    private async Task InsertDiagnostigoDenteTipo(string tipo, int idProntuario, Dentes dentes)
    {
        var diagnosticoDentes = await _context.ProntuarioDiagnosticosDentes.FirstOrDefaultAsync(x => x.IdProntuario.Equals(idProntuario) && x.TipoDiagnostico.Equals(tipo));
        if (diagnosticoDentes == null)
        {
            diagnosticoDentes = new ProntuarioDiagnosticosDente
            {
                IdProntuario = idProntuario,
                TipoDiagnostico = tipo,
            };
            await _context.ProntuarioDiagnosticosDentes.AddAsync(diagnosticoDentes);
        }

        string checks = "";
        Type type = typeof(Dentes);
        foreach (var property in type.GetProperties())
        {
            var denteCheck = (bool)dentes.GetType().GetProperty(property.Name).GetValue(dentes);
            if (denteCheck)
                checks += property.Name + ",";
        }
        if(checks.Length > 1)
            checks = checks.Remove(checks.Length - 1);
        diagnosticoDentes.Dentes = checks;

        await _context.SaveChangesAsync();
    }

    private async Task InsertDescricaoDentes(DescricaoDente descricaoDente, int idProntuario)
    {
        Type type = typeof(DescricaoDente);
        Dictionary<string, string> propertyNames = new Dictionary<string, string>();

        foreach (var property in type.GetProperties())
        {
            if (descricaoDente != null && !string.IsNullOrEmpty((string)descricaoDente.GetType().GetProperty(property.Name).GetValue(descricaoDente)))
                propertyNames.Add(property.Name, descricaoDente.GetType().GetProperty(property.Name).GetValue(descricaoDente).ToString());
        }
        propertyNames.Remove("Observacoes");


        ProntuarioDescricaoDente prontuarioDescricaoDente = null;
        foreach (var denteDesc in propertyNames.Keys)
        {
            prontuarioDescricaoDente = await _context.ProntuarioDescricaoDentes.FirstOrDefaultAsync(x => x.IdProntuario.Equals(idProntuario) && x.NumeroDente.Equals(denteDesc));
            if (prontuarioDescricaoDente == null)
            {
                prontuarioDescricaoDente = new ProntuarioDescricaoDente
                {
                    IdProntuario = idProntuario,
                };
                await _context.ProntuarioDescricaoDentes.AddAsync(prontuarioDescricaoDente);
            }

            prontuarioDescricaoDente.DescricaoDente = propertyNames[denteDesc];
            prontuarioDescricaoDente.NumeroDente = denteDesc;
        }

        await _context.SaveChangesAsync();
    }
    
    private Prontuario InsertDataProntuario(PostCadastrarProntuarioRequest request)
    {
        var prontuario = new Prontuario
        {
            QueixaPrincipal = request.QueixaPrincipal,
            HistoriaDoencaAtual = request.HistoriaDoencaAtual,
            VisitasMedicas = request.UsoMedicamentos.VisitasMedicas,
            Hospitalizacoes = request.UsoMedicamentos.Hospitalizacoes,
            Observacoes = request.UsoMedicamentos.Observacoes,
            DadosRelevantesHistoriaMedica = request.UsoMedicamentos.DadosRelevantesHistoriaMedica,
            PlanoCronologicoTratamento = request.PlanoCronologicoTratamento,
            RestauracaoDefinitivaDoDente = request.RestauracaoDefinitivaDoDente,
            NumeroDeSessoesRealizadas = request.NumeroDeSessoesRealizadas,
            TeveCatapora = request.HistoriaMedicaPregressaEAtual.DoencaInfancia.Catapora.ConvertBoolForIntNull(),
            TeveCaxumba = request.HistoriaMedicaPregressaEAtual.DoencaInfancia.Caxumba.ConvertBoolForIntNull(),
            TeveSarampo = request.HistoriaMedicaPregressaEAtual.DoencaInfancia.Sarampo.ConvertBoolForIntNull(),
            TeveAmigdalite = request.HistoriaMedicaPregressaEAtual.DoencaInfancia.Amigdalite.ConvertBoolForIntNull(),
            OutrasDoencaInfancia = request.HistoriaMedicaPregressaEAtual.DoencaInfancia.Outras,
            TeveFebreReumatica = request.HistoriaMedicaPregressaEAtual.DistubiosCardiovasculares.FebreReumatica.ConvertBoolForIntNull(),
            TeveSopros = request.HistoriaMedicaPregressaEAtual.DistubiosCardiovasculares.Sopros.ConvertBoolForIntNull(),
            TevePatologiasDeValvulas = request.HistoriaMedicaPregressaEAtual.DistubiosCardiovasculares.PatologiasValvulas.ConvertBoolForIntNull(),
            TeveAnomaliasCongenitasCardiacas = request.HistoriaMedicaPregressaEAtual.DistubiosCardiovasculares.AnomaliasCongenitasCardiacas.ConvertBoolForIntNull(),
            TeveHipertensao = request.HistoriaMedicaPregressaEAtual.DistubiosCardiovasculares.Hirpertensao.ConvertBoolForIntNull(),
            TeveArritmias = request.HistoriaMedicaPregressaEAtual.DistubiosCardiovasculares.Arritmias.ConvertBoolForIntNull(),
            TeveInfartoDoMiocardio = request.HistoriaMedicaPregressaEAtual.DistubiosCardiovasculares.InfartoMiocardio.ConvertBoolForIntNull(),
            TeveAnginaOuDorTorax = request.HistoriaMedicaPregressaEAtual.DistubiosCardiovasculares.AngiaOuDorNoTorax.ConvertBoolForIntNull(),
            FezCirurgiasCardiacas = request.HistoriaMedicaPregressaEAtual.DistubiosCardiovasculares.CirurgiasCardiacas.ConvertBoolForIntNull(),
            MarcaPasso = request.HistoriaMedicaPregressaEAtual.DistubiosCardiovasculares.MarcaPasso.ConvertBoolForIntNull(),
            TeveAVC = request.HistoriaMedicaPregressaEAtual.DistubiosCardiovasculares.AVC.ConvertBoolForIntNull(),
            OutrosDisturbiosCardiovasculares = request.HistoriaMedicaPregressaEAtual.DistubiosCardiovasculares.Outras,
            Asma = request.HistoriaMedicaPregressaEAtual.DistubiosRespiratorios.Asma.ConvertBoolForIntNull(),
            DoencaPulmonares = request.HistoriaMedicaPregressaEAtual.DistubiosRespiratorios.DoencaPulmonares.ConvertBoolForIntNull(),
            Sinusite = request.HistoriaMedicaPregressaEAtual.DistubiosRespiratorios.Sinusite.ConvertBoolForIntNull(),
            Rinite = request.HistoriaMedicaPregressaEAtual.DistubiosRespiratorios.Rinite.ConvertBoolForIntNull(),
            OutrosDisturbiosRespiratorios = request.HistoriaMedicaPregressaEAtual.DistubiosRespiratorios.Outras,
            Diabetes = request.HistoriaMedicaPregressaEAtual.DistubiosEndocrinos.Diabetes.ConvertBoolForIntNull(),
            DisfuncaoTireoide = request.HistoriaMedicaPregressaEAtual.DistubiosEndocrinos.DisfuncaoTireoide.ConvertBoolForIntNull(),
            Menarca = request.HistoriaMedicaPregressaEAtual.DistubiosEndocrinos.Menarca,
            Menopausa = request.HistoriaMedicaPregressaEAtual.DistubiosEndocrinos.Menopausa,
            Gravidez = request.HistoriaMedicaPregressaEAtual.DistubiosEndocrinos.Gravidez,
            Partos = request.HistoriaMedicaPregressaEAtual.DistubiosEndocrinos.Partos,
            OutrosDisturbiosEndocrinos = request.HistoriaMedicaPregressaEAtual.DistubiosEndocrinos.Outras,
            Desmaios = request.HistoriaMedicaPregressaEAtual.DisturbiosNeurologicos.Desmaios.ConvertBoolForIntNull(),
            Convulsoes = request.HistoriaMedicaPregressaEAtual.DisturbiosNeurologicos.Convulsoes.ConvertBoolForIntNull(),
            Enxaquecas = request.HistoriaMedicaPregressaEAtual.DisturbiosNeurologicos.Enxaquecas.ConvertBoolForIntNull(),
            Cefaleias = request.HistoriaMedicaPregressaEAtual.DisturbiosNeurologicos.Cefaleias.ConvertBoolForIntNull(),
            NevralgiaNaFace = request.HistoriaMedicaPregressaEAtual.DisturbiosNeurologicos.NevralgiaNaFace.ConvertBoolForIntNull(),
            OutrosDisturbiosNeurologicos = request.HistoriaMedicaPregressaEAtual.DisturbiosNeurologicos.Outras,
            Anemia = request.HistoriaMedicaPregressaEAtual.DisturbiosHematologicos.Anemia.ConvertBoolForIntNull(),
            Hemorragia = request.HistoriaMedicaPregressaEAtual.DisturbiosHematologicos.Hemorragia.ConvertBoolForIntNull(),
            Hemofilia = request.HistoriaMedicaPregressaEAtual.DisturbiosHematologicos.Hemofilia.ConvertBoolForIntNull(),
            Leucemia = request.HistoriaMedicaPregressaEAtual.DisturbiosHematologicos.Leucemia.ConvertBoolForIntNull(),
            OutrosDisturbiosHematologicos = request.HistoriaMedicaPregressaEAtual.DisturbiosHematologicos.Outras,
            DataDoacaoSangue = request.HistoriaMedicaPregressaEAtual.DisturbiosHematologicos.DataDoacaoSangue,
            TratamentoPsiquiatrico = request.HistoriaMedicaPregressaEAtual.DisturbiosPsiquiatricos.TratamentoPsiquiatrico.ConvertBoolForIntNull(),
            Depressao = request.HistoriaMedicaPregressaEAtual.DisturbiosPsiquiatricos.Depressao.ConvertBoolForIntNull(),
            Ansiedade = request.HistoriaMedicaPregressaEAtual.DisturbiosPsiquiatricos.Ansiedade.ConvertBoolForIntNull(),
            OutrosDisturbiosPsiquiatricos = request.HistoriaMedicaPregressaEAtual.DisturbiosPsiquiatricos.Outras,
            JaSofreuTraumatismoNaFace = request.HistoriaMedicaPregressaEAtual.DisturbiosArticulacoesOuOssos.JaSofreuTraumatismoNaFace.ConvertBoolForIntNull(),
            Artrite = request.HistoriaMedicaPregressaEAtual.DisturbiosArticulacoesOuOssos.Artrite.ConvertBoolForIntNull(),
            Reumatismo = request.HistoriaMedicaPregressaEAtual.DisturbiosArticulacoesOuOssos.Reumatismo.ConvertBoolForIntNull(),
            Osteoporose = request.HistoriaMedicaPregressaEAtual.DisturbiosArticulacoesOuOssos.Osteoporose.ConvertBoolForIntNull(),
            OutrosDisturbiosArticulacoesOuOssos = request.HistoriaMedicaPregressaEAtual.DisturbiosArticulacoesOuOssos.Outros,
            BruxismoCentrico = request.HistoriaMedicaPregressaEAtual.DisturbiosArticulacaoTemporamandibular.BruxismoCentrico.ConvertBoolForIntNull(),
            BruxismoExcentrico = request.HistoriaMedicaPregressaEAtual.DisturbiosArticulacaoTemporamandibular.BruxismoExcentrico.ConvertBoolForIntNull(),
            MastigacaoUnilateral = request.HistoriaMedicaPregressaEAtual.DisturbiosArticulacaoTemporamandibular.MastigacaoUnilateral.ConvertBoolForIntNull(),
            DorRegiaoDosOuvidos = request.HistoriaMedicaPregressaEAtual.DisturbiosArticulacaoTemporamandibular.DorRegiaoDosOuvidos.ConvertBoolForIntNull(),
            EstalidoNaAberturaEFechamentoBucal = request.HistoriaMedicaPregressaEAtual.DisturbiosArticulacaoTemporamandibular.EstalidoNaAberturaEFechamentoBucal.ConvertBoolForIntNull(),
            OutrosDisturbiosArticulacaoTemporamandibular = request.HistoriaMedicaPregressaEAtual.DisturbiosArticulacaoTemporamandibular.Outros,
            Hepatite = request.HistoriaMedicaPregressaEAtual.DoencaTransmissiveis.Hepatite.ConvertBoolForIntNull(),
            Herpes = request.HistoriaMedicaPregressaEAtual.DoencaTransmissiveis.Herpes.ConvertBoolForIntNull(),
            HIV = request.HistoriaMedicaPregressaEAtual.DoencaTransmissiveis.HIV.ConvertBoolForIntNull(),
            Tuberculose = request.HistoriaMedicaPregressaEAtual.DoencaTransmissiveis.Tuberculose.ConvertBoolForIntNull(),
            DoencaSexualmenteTransmissivel = request.HistoriaMedicaPregressaEAtual.DoencaTransmissiveis.DoencaSexualmenteTransmissivel.ConvertBoolForIntNull(),
            QuaisDoencaTransmissiveis = request.HistoriaMedicaPregressaEAtual.DoencaTransmissiveis.Quais,
            OutrasDoencasTransmissiveis = request.HistoriaMedicaPregressaEAtual.DoencaTransmissiveis.Outras,
            Anestesia = request.HistoriaMedicaPregressaEAtual.Alergias.Anestesia.ConvertBoolForIntNull(),
            Alimentos = request.HistoriaMedicaPregressaEAtual.Alergias.Alimentos.ConvertBoolForIntNull(),
            Cosmeticos = request.HistoriaMedicaPregressaEAtual.Alergias.Cosmeticos.ConvertBoolForIntNull(),
            Urticaria = request.HistoriaMedicaPregressaEAtual.Alergias.Urticaria.ConvertBoolForIntNull(),
            QuaisAlergias = request.HistoriaMedicaPregressaEAtual.Alergias.Quais,
            Medicamentos = request.HistoriaMedicaPregressaEAtual.Alergias.Medicamentos.ConvertBoolForIntNull(),
            QuaisMedicamentos = request.HistoriaMedicaPregressaEAtual.Alergias.QuaisMedicamentos,
            OutrasAlergias = request.HistoriaMedicaPregressaEAtual.Alergias.Outras,
            FazUsoDeMedicamentos = request.UsoMedicamentos.FazUsoDeMedicamentos.ConvertBoolForIntNull(),
            NomeComercial = request.UsoMedicamentos.NomeComercial,
            NomeGenerico = request.UsoMedicamentos.NomeGenerico,
            Dosagem = request.UsoMedicamentos.Dosagem,
            FrequenciaUso = request.UsoMedicamentos.FrequenciaUso,
            Pai = request.HistoriaFamiliar.Pai,
            Mae = request.HistoriaFamiliar.Mae,
            Irmaos = request.HistoriaFamiliar.Irmaos,
            Cardiopatias = request.TendenciasHereditarias.Cardiopatias.ConvertBoolForIntNull(),
            Hipertensao = request.TendenciasHereditarias.Hipertensao.ConvertBoolForIntNull(),
            DiabeteHereditaria = request.TendenciasHereditarias.Diabete.ConvertBoolForIntNull(),
            AsmaHereditaria = request.TendenciasHereditarias.Asma.ConvertBoolForIntNull(),
            DisturbioSangramento = request.TendenciasHereditarias.DisturbioSangramento.ConvertBoolForIntNull(),
            AlergiasHereditaria = request.TendenciasHereditarias.Alergias.ConvertBoolForIntNull(),
            NeoplastiasMalignas = request.TendenciasHereditarias.NeoplasiasMalignas.ConvertBoolForIntNull(),
            DoencaNeurologicas = request.TendenciasHereditarias.DoencaNeurologicas.ConvertBoolForIntNull(),
            TuberculoseHereditaria = request.TendenciasHereditarias.Tuberculose.ConvertBoolForIntNull(),
            Complemento = request.TendenciasHereditarias.Complemento,
            OutrasDoencasHereditarias = request.TendenciasHereditarias.OutrasDoencas,
            HabitoAlcool = request.Habitos.Alcool.ConvertBoolForIntNull(),
            FrequenciaAlcool = request.Habitos.FrequenciaAlcool,
            HabitoFumo = request.Habitos.Fumo.ConvertBoolForIntNull(),
            FrequenciaFumo = request.Habitos.FrequenciaFumo,
            OutrosHabitosNocivos = request.Habitos.OutrosHabitosNocivos,
            Escovacao = request.HabitoHigieneBucal.Escovacao,
            FioDental = request.HabitoHigieneBucal.FioDental,
            EnxaguatorioBucal = request.HabitoHigieneBucal.EnxaguatorioBucal,
            CurativoSessao1 = request.Curativos.PrimeiraSessao,
            CurativoSessao2 = request.Curativos.SegundaSessao,
            CurativoSessao3 = request.Curativos.TerceiraSessao,
            CurativoSessao4 = request.Curativos.QuartaSessao,
            CurativoSessao5 = request.Curativos.QuintaSessao,
            CurativoSessao6 = request.Curativos.SextaSessao,
            DoouOuRecebeuSangue = request.HistoriaMedicaPregressaEAtual.DisturbiosHematologicos.DoouOuRecebeuSangue.ConvertBoolForIntNull(),
            ObservacoesDentes = request.DescricaoDente.Observacoes,
            ObservacoesDiagnosticoDentes = request.DiagnosticosDente.Observacoes,
            Cirrose = request.HistoriaMedicaPregressaEAtual.DisturbiosGastrointestinais.Cirrose.ConvertBoolForIntNull(),
            Gastrite = request.HistoriaMedicaPregressaEAtual.DisturbiosGastrointestinais.Gastrite.ConvertBoolForIntNull(),
            Ulceras = request.HistoriaMedicaPregressaEAtual.DisturbiosGastrointestinais.Ulceras.ConvertBoolForIntNull(),
            OutrosDisturbiosGastrointestinais = request.HistoriaMedicaPregressaEAtual.DisturbiosGastrointestinais.Outras,
            DoencaGinecologicas = request.HistoriaMedicaPregressaEAtual.DistubiosGenitourinarias.DoencasGionecologicas.ConvertBoolForIntNull(),
            Nefrite = request.HistoriaMedicaPregressaEAtual.DistubiosGenitourinarias.DoencasRenais.Nefrite.ConvertBoolForIntNull(),
            FazHemodialise = request.HistoriaMedicaPregressaEAtual.DistubiosGenitourinarias.DoencasRenais.FazHemodialise.ConvertBoolForIntNull(),
            InfeccoesDoTratoUrinario = request.HistoriaMedicaPregressaEAtual.DistubiosGenitourinarias.InfeccoesTratoUrinario.ConvertBoolForIntNull(),
            InsuficienciaRenal = request.HistoriaMedicaPregressaEAtual.DistubiosGenitourinarias.DoencasRenais.InsuficienciaRenal.ConvertBoolForIntNull(),
            OutrosDisturbiosGenitourinarias = request.HistoriaMedicaPregressaEAtual.DistubiosGenitourinarias.Outras,
            QuaisHemodialises = request.HistoriaMedicaPregressaEAtual.DistubiosGenitourinarias.DoencasRenais.Quais,
            Pulso = request.ExameFisico.Pulso,
            DataPedidoAvaliacaoMedica = request.ExameFisico.DataPedidoAvaliacaoMedica,
            PedidoAvaliacaoMedica = request.ExameFisico.PedidoAvaliacaoMedica,
            PressaoArterial = request.ExameFisico.PressaoArterial,
            TemperaturaAxiliar = request.ExameFisico.TemperaturaAxiliar,
            Ectoscopia = request.ExameFisico.Ectoscopia,
            ExamesComplementaresSolicitados = request.ExameFisico.ExamesComplementaresSolicitados,
            FrequenciaRespiratoria = request.ExameFisico.FrequenciaRespiratoria,
            Motivo = request.ExameFisico.Motivo,
            Oroscopia = request.ExameFisico.Oroscopia,
            NecessitaDeCuidadosEspeciaisRelacao = request.ExameFisico.NecessitaDeCuidadosEspeciaisRelacao,
            ObservacoesExameFisico = request.ExameFisico.Observacoes,
            PacientePortadorDe = request.ExameFisico.PacientePortadorDe,
            ParecerMedico = request.ExameFisico.ParecerMedico,
        };

        return prontuario;
    }

    private EndodontiaEntity InsertDataEndodontia(Endodontia endo)
    {
        var endodontia = new EndodontiaEntity()
{
            Dente = endo.Dente,
            NumeroCanais = endo.NumeroDeCanais,
            DiagnosticoPulparNormal = endo.ExameClinico.DiagnosticoPulpar.Normal.ConvertBoolForIntNull(),
            PulpiteIrreversivel = endo.ExameClinico.DiagnosticoPulpar.PulpiteIrreversivel.ConvertBoolForIntNull(),
            PulpiteReversivel = endo.ExameClinico.DiagnosticoPulpar.PulpiteReversivel.ConvertBoolForIntNull(),
            Necrose = endo.ExameClinico.DiagnosticoPulpar.Necrose.ConvertBoolForIntNull(),
            DenteJaTratado = endo.ExameClinico.DiagnosticoPulpar.DenteJaTratado.ConvertBoolForIntNull(),
            Insesivel = endo.ExameClinico.TesteDePercussao.Insesivel.ConvertBoolForIntNull(),
            Sensivel = endo.ExameClinico.TesteDePercussao.Sensivel.ConvertBoolForIntNull(),
            MuitoSensivel = endo.ExameClinico.TesteDePercussao.MuitoSensivel.ConvertBoolForIntNull(),
            PresencaDeAbcesso = endo.ExameClinico.PresencaDeAbcesso.Presente.ConvertBoolForIntNull(),
            IntraBucal = endo.ExameClinico.PresencaDeAbcesso.IntraBucal.ConvertBoolForIntNull(),
            ExtraBucal = endo.ExameClinico.PresencaDeAbcesso.Extrabucal.ConvertBoolForIntNull(),
            ComFistula = endo.ExameClinico.PresencaDeAbcesso.ComFistula.ConvertBoolForIntNull(),
            SemFistula = endo.ExameClinico.PresencaDeAbcesso.SemFistula.ConvertBoolForIntNull(),
            RegioPeriapicalNormal = endo.ExameClinico.ExameRadiografico.RegiaoPeriapical.Normal.ConvertBoolForIntNull(),
            ComLesao = endo.ExameClinico.ExameRadiografico.RegiaoPeriapical.ComLesao.ConvertBoolForIntNull(),
            Difusa = endo.ExameClinico.ExameRadiografico.RegiaoPeriapical.Difusa.ConvertBoolForIntNull(),
            Circunscrita = endo.ExameClinico.ExameRadiografico.RegiaoPeriapical.Circunscrita.ConvertBoolForIntNull(),
            Ausente = endo.ExameClinico.ExsudatoNosCanais.Ausente.ConvertBoolForIntNull(),
            Claro = endo.ExameClinico.ExsudatoNosCanais.Claro.ConvertBoolForIntNull(),
            Hemorragico = endo.ExameClinico.ExsudatoNosCanais.Hemorragico.ConvertBoolForIntNull(),
            Purulento = endo.ExameClinico.ExsudatoNosCanais.Purulento.ConvertBoolForIntNull(),
            DorEntreAsSessoes = endo.ExameClinico.DorEntreAsSessoes.ConvertBoolForIntNull(),
            HipocloritoDeSodioPorcentagem = endo.ExameClinico.SolucaoIrrigadora.HipocloritoDeSodioAPorcentagem.ConvertBoolForIntNull(),
            OutrasSolucaoIrrigadora = endo.ExameClinico.SolucaoIrrigadora.Outra,
            CimentoObturador = endo.ExameClinico.CimentoObturador,
            CondensacaoLateral = endo.ExameClinico.TecnicaDeObturacao.CondensacaoLateral.ConvertBoolForIntNull(),
            OutraTecnicaDeObturação = endo.ExameClinico.TecnicaDeObturacao.Outra,
            MaterialRestauradorProvisorio = endo.ExameClinico.MaterialRestauradorProvisorio,
            QuantidadeDeSodioAPorcentagem = endo.ExameClinico.SolucaoIrrigadora.QuantidadeDeSodioAPorcentagem,
            InicioTratamento = endo.InicioTratamento,
            TerminoTratamento = endo.TerminoTratamento,
        };

        return endodontia;
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

        var usuario = await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == request.IdUsuario);

        if (usuario == null)
            return BadRequest("Erro de usuario");

        Professor professor = null;
        Estudante estudante = null;
        if (usuario.IdTipoUsuario == 1 || usuario.IdTipoUsuario == 2)
            professor = await _context.Professors.FirstOrDefaultAsync(x => x.IdUsuario == usuario.Id);
        else
            estudante = await _context.Estudantes.FirstOrDefaultAsync(x => x.IdUsuario == usuario.Id);


        triagem.EncaminharPeriodo = request.EncaminharPeriodo;
        triagem.EspecializacaoCirurgia = request.EspecializacaoCirurgia ? 1 : 0;
        triagem.EspecializacaoProteseImplante = request.EspecializacaoProteseImplante ? 1 : 0;
        triagem.OutrasEspecializacoes = request.OutrasEspecializacoes;
        triagem.IdEstudanteAssinatura = estudante != null ? estudante.Id : triagem.IdEstudanteAssinatura;
        triagem.IdProfessorAssinatura = professor != null ? professor.Id : triagem.IdProfessorAssinatura;
        triagem.Status = request.Status.ToString();

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

    public async Task<IActionResult> GetTriagem(PatchBuscarTriagemRequeste filtro, int pageNumber, int pageSize, string nomePaciente)
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

        // Aplicando filtros adicionais, se fornecidos
        if (filtro.IdProntuario.HasValue)
        {
            query = query.Where(x => x.Id == filtro.IdProntuario.Value);
        }

        if (filtro.IdEstudante.HasValue)
        {
            query = query.Where(x => x.IdEstudanteAssinatura == filtro.IdEstudante.Value);
        }

        if (filtro.IdProfessor.HasValue)
        {
            query = query.Where(x => x.IdProfessorAssinatura == filtro.IdProfessor.Value);
        }

        if (filtro.DataCadastro.HasValue)
        {
            query = query.Where(x => x.DataCadastro.Date == filtro.DataCadastro.Value.Date);
        }

        if (!string.IsNullOrEmpty(filtro.Status))
        {
            query = query.Where(x => x.Status == filtro.Status);
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
            Status = x.Status
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
        response.Status = triagem.Status.ToString();

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

        var prontuario = await _context.Prontuarios.FirstOrDefaultAsync(x => x.IdPaciente.Equals(idPaciente));
        if(prontuario == null)
            return BadRequest(OdonTrackErrors.ProntuarioNotFound);

        var reavaliacoesAnamnese = await _context.ReavaliacaoAnamneses.Where(x => x.IdProntuario.Equals(prontuario.Id))
                                                                    .OrderByDescending(x => x.Id)
                                                                    .Skip((pageNumber - 1) * pageSize)
                                                                    .Take(pageSize)
                                                                    .ToListAsync();

        var reavaliacaoAnamneseCount = await _context.ReavaliacaoAnamneses.Where(x => x.IdProntuario.Equals(prontuario.Id)).CountAsync(x => x.IdProntuario.Equals(prontuario.Id));

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

    public async Task<IActionResult> GetProntuarioDetails(int idProntuario)
    {
        var prontuario = await _context.Prontuarios.FirstOrDefaultAsync(x => x.Id.Equals(idProntuario));
        if (prontuario == null)
            return BadRequest(OdonTrackErrors.ProntuarioNotFound);

        var paciente = await _context.Pacientes.FirstOrDefaultAsync(x => x.Id.Equals(prontuario.IdPaciente));
        if(paciente == null)
            return BadRequest(OdonTrackErrors.PacienteNotFound);

        var endodontia = await _context.Endodontias.Where(x => x.IdProntuario.Equals(idProntuario)).ToListAsync();

        var descricaoDentes = await _context.ProntuarioDescricaoDentes.Where(x => x.IdProntuario.Equals(idProntuario)).ToListAsync();

        var diagnosticoDentes = await _context.ProntuarioDiagnosticosDentes.Where(x => x.IdProntuario.Equals(idProntuario)).ToListAsync();

        var reavaliacaoAnamnese = await _context.ReavaliacaoAnamneses.Where(x => x.IdProntuario.Equals(idProntuario)).ToListAsync();

        var data = CreateResponseProntuaruiDetails(prontuario);

        data.Paciente = new()
        {
            Id = paciente.Id,
            Nome = paciente.Nome,
        };

        data = await EndodontiaData(idProntuario, data, endodontia);

        data = DescricaoDentes(data, descricaoDentes);

        data = DiagnosticoDentes(data, diagnosticoDentes);

        data.ReavaliacaoAnamnese = ReavaliacaoDeAnamnesesProntuario(reavaliacaoAnamnese);

        return Ok(data);
    }

    private List<ReavaliacaoDeAnamnese> ReavaliacaoDeAnamnesesProntuario(List<ReavaliacaoAnamnese> reavaliacaoAnamneses)
    {
        if (reavaliacaoAnamneses.Count == 0)
            return new List<ReavaliacaoDeAnamnese>();

        List<ReavaliacaoDeAnamnese> reavaliacoes = new();
        foreach (var reavaliacao in reavaliacaoAnamneses)
        {
            reavaliacoes.Add(new ReavaliacaoDeAnamnese
            {
                Id = reavaliacao.Id,
                DataReavaliacao = reavaliacao.Data,
                PressaoArterial = reavaliacao.PressaoArterial,
                Pulso = reavaliacao.Pulso,
                FrequenciaRespiratoria = reavaliacao.FrequenciaRespiratoria,
                TemperaturaAxilar = reavaliacao.TemperaturaAxilar,
                Medicamentos = reavaliacao.Medicamentos,
                Observacoes = reavaliacao.Observacoes,
            });
        }

        return reavaliacoes;
    }

    private PostCadastrarProntuarioRequest DiagnosticoDentes(PostCadastrarProntuarioRequest data, List<ProntuarioDiagnosticosDente> diagnosticosDentes)
    {
        data.DiagnosticosDente.Gengivite = GetGengivite(diagnosticosDentes);
        data.DiagnosticosDente.PeriodontiteLeve = GetPeriodontiteLeve(diagnosticosDentes);
        data.DiagnosticosDente.PeriodontiteGrave = GetPeriodontiteGrave(diagnosticosDentes);
        data.DiagnosticosDente.EComplicada = GetEComplicada(diagnosticosDentes);

        return data;
    }

    private Dentes GetGengivite(List<ProntuarioDiagnosticosDente> diagnosticosDentes)
    {
        DiagnosticosDente data = new();
        var diag = diagnosticosDentes.FirstOrDefault(x => x.TipoDiagnostico.Equals("Gengivite"));
        foreach(var dente in diag.Dentes.Split(","))
        {
            if(string.IsNullOrEmpty(dente))
                continue;

            var property = typeof(Dentes).GetProperty(dente);
            property.SetValue(data.Gengivite, true);
        }

        return data.Gengivite;
    }

    private Dentes GetPeriodontiteLeve(List<ProntuarioDiagnosticosDente> diagnosticosDentes)
    {
        DiagnosticosDente data = new();
        var diag = diagnosticosDentes.FirstOrDefault(x => x.TipoDiagnostico.Equals("PeriodontiteLeve"));
        foreach (var dente in diag.Dentes.Split(","))
        {
            if (string.IsNullOrEmpty(dente))
                continue;

            var property = typeof(Dentes).GetProperty(dente);
            property.SetValue(data.PeriodontiteLeve, true);
        }

        return data.PeriodontiteLeve;
    }

    private Dentes GetPeriodontiteGrave(List<ProntuarioDiagnosticosDente> diagnosticosDentes)
    {
        DiagnosticosDente data = new();
        var diag = diagnosticosDentes.FirstOrDefault(x => x.TipoDiagnostico.Equals("PeriodontiteGrave"));
        foreach (var dente in diag.Dentes.Split(","))
        {
            if (string.IsNullOrEmpty(dente))
                continue;

            var property = typeof(Dentes).GetProperty(dente);
            property.SetValue(data.PeriodontiteGrave, true);
        }

        return data.PeriodontiteGrave;
    }

    private Dentes GetEComplicada(List<ProntuarioDiagnosticosDente> diagnosticosDentes)
    {
        DiagnosticosDente data = new();
        var diag = diagnosticosDentes.FirstOrDefault(x => x.TipoDiagnostico.Equals("EComplicada"));
        foreach (var dente in diag.Dentes.Split(","))
        {
            if (string.IsNullOrEmpty(dente))
                continue;

            var property = typeof(Dentes).GetProperty(dente);
            property.SetValue(data.EComplicada, true);
        }

        return data.EComplicada;
    }

    private PostCadastrarProntuarioRequest DescricaoDentes(PostCadastrarProntuarioRequest data, List<ProntuarioDescricaoDente> descricaoDente)
    {
        foreach (var dente in descricaoDente)
        {
            var property = data.DescricaoDente.GetType().GetProperty(dente.NumeroDente);
            property.SetValue(data.DescricaoDente, dente.DescricaoDente);
        }

        return data;
    }

    private async Task<PostCadastrarProntuarioRequest> EndodontiaData(int idProntuario, PostCadastrarProntuarioRequest data, List<EndodontiaEntity> endodontias)
    {
        data.Endodontia = new List<Endodontia>();
        foreach(var endo in endodontias)
        {
            var endodontia = new Endodontia
            {
                Id = endo.Id,
                Dente = endo.Dente,
                NumeroDeCanais = endo.NumeroCanais,
                InicioTratamento = endo.InicioTratamento,
                TerminoTratamento = endo.TerminoTratamento,
                ExameClinico = new()
                {
                    DorEntreAsSessoes = endo.DorEntreAsSessoes.ConvertIntNullForBool(),
                    PresencaDeAbcesso = new()
                    {
                        ComFistula = endo.ComFistula.ConvertIntNullForBool(),
                        Extrabucal = endo.ExtraBucal.ConvertIntNullForBool(),
                        IntraBucal = endo.IntraBucal.ConvertIntNullForBool(),
                        SemFistula = endo.SemFistula.ConvertIntNullForBool(),
                        Presente = endo.PresencaDeAbcesso.ConvertIntNullForBool()
                    },
                    CimentoObturador = endo.CimentoObturador,
                    DiagnosticoPulpar = new()
                    {
                        DenteJaTratado = endo.DenteJaTratado.ConvertIntNullForBool(),
                        Necrose = endo.Necrose.ConvertIntNullForBool(),
                        Normal = endo.DiagnosticoPulparNormal.ConvertIntNullForBool(),
                        PulpiteIrreversivel = endo.PulpiteIrreversivel.ConvertIntNullForBool(),
                        PulpiteReversivel = endo.PulpiteReversivel.ConvertIntNullForBool(),
                    },
                    ExameRadiografico = new()
                    {
                        RegiaoPeriapical = new()
                        {
                            Circunscrita = endo.Circunscrita.ConvertIntNullForBool(),
                            ComLesao = endo.ComLesao.ConvertIntNullForBool(),
                            Difusa = endo.Difusa.ConvertIntNullForBool(),
                            Normal = endo.RegioPeriapicalNormal.ConvertIntNullForBool(),
                        }
                    },
                    ExsudatoNosCanais = new()
                    {
                        Ausente = endo.Ausente.ConvertIntNullForBool(),
                        Claro = endo.Claro.ConvertIntNullForBool(),
                        Hemorragico = endo.Hemorragico.ConvertIntNullForBool(),
                        Purulento = endo.Purulento.ConvertIntNullForBool(),
                    },
                    MaterialRestauradorProvisorio = endo.MaterialRestauradorProvisorio,
                    SolucaoIrrigadora = new()
                    {
                        HipocloritoDeSodioAPorcentagem = endo.HipocloritoDeSodioPorcentagem.ConvertIntNullForBool(),
                        QuantidadeDeSodioAPorcentagem = endo.QuantidadeDeSodioAPorcentagem,
                        Outra = endo.OutrasSolucaoIrrigadora,
                    },
                    TecnicaDeObturacao = new()
                    {
                        CondensacaoLateral = endo.CondensacaoLateral.ConvertIntNullForBool(),
                        Outra = endo.OutraTecnicaDeObturação,
                    },  
                    TesteDePercussao = new()
                    {
                        Insesivel = endo.Insesivel.ConvertIntNullForBool(),
                        MuitoSensivel = endo.MuitoSensivel.ConvertIntNullForBool(),
                        Sensivel = endo.Sensivel.ConvertIntNullForBool(),
                    }
                }
            };

            var odontometria = await _context.Odontometrias.Where(x => x.IdProntuario.Equals(idProntuario) && x.IdEndodontia.Equals(endo.Id)).ToListAsync();
            endodontia.Odontometria = new List<Odontometria>();
            foreach(var odonto in odontometria)
            {
                endodontia.Odontometria.Add(new Odontometria
                {
                    Id = odonto.Id,
                    CAD = odonto.CAD,
                    CRD = odonto.CRD,
                    CRT = odonto.CRT,
                    Canal = odonto.Canal,
                    DiametroAnatomico = odonto.DiametroAnatomico,
                    DiametroCirurgico = odonto.DiametroCirurgico,
                    PontoDeReferenciaPontoDeReferencia = odonto.PontoDeRefencia,
                });
            }

            var retornos = await _context.RetornosEntity.Where(x => x.IdEndodontia.Equals(endo.Id)).ToListAsync();
            endodontia.Retornos = new List<Retorno>();
            foreach (var retorno in retornos)
            {
                endodontia.Retornos.Add(new Retorno
                {
                    Id = retorno.Id,
                    DataRetorno = retorno.DataRetorno,
                });
            }

            data.Endodontia.Add(endodontia);
        }

        return data;
    }

    private PostCadastrarProntuarioRequest CreateResponseProntuaruiDetails(Prontuario prontuario)
    {
        var request = new PostCadastrarProntuarioRequest
        {
            IdProntuario = prontuario.Id,
            Status = prontuario.IdProntuarioStatus.ToString(),
            QueixaPrincipal = prontuario.QueixaPrincipal,
            HistoriaDoencaAtual = prontuario.HistoriaDoencaAtual,
            PlanoCronologicoTratamento = prontuario.PlanoCronologicoTratamento,
            RestauracaoDefinitivaDoDente = prontuario.RestauracaoDefinitivaDoDente,
            NumeroDeSessoesRealizadas = prontuario.NumeroDeSessoesRealizadas,
            ExameFisico = new()
            {
                DataPedidoAvaliacaoMedica = prontuario.DataPedidoAvaliacaoMedica,
                PedidoAvaliacaoMedica = prontuario.PedidoAvaliacaoMedica,
                PressaoArterial = prontuario.PressaoArterial,
                TemperaturaAxiliar = prontuario.TemperaturaAxiliar,
                Ectoscopia = prontuario.Ectoscopia,
                ExamesComplementaresSolicitados = prontuario.ExamesComplementaresSolicitados,
                FrequenciaRespiratoria = prontuario.FrequenciaRespiratoria,
                Motivo = prontuario.Motivo,
                NecessitaDeCuidadosEspeciaisRelacao = prontuario.NecessitaDeCuidadosEspeciaisRelacao,
                Observacoes = prontuario.ObservacoesExameFisico,
                Oroscopia = prontuario.Oroscopia,
                PacientePortadorDe = prontuario.PacientePortadorDe,
                ParecerMedico = prontuario.ParecerMedico,
                Pulso = prontuario.Pulso
            },
            HistoriaMedicaPregressaEAtual = new HistoriaMedicaPregressaEAtual
            {
                DoencaInfancia = new DoencaInfancia
                {
                    Catapora = prontuario.TeveCatapora.ConvertIntNullForBool(),
                    Caxumba = prontuario.TeveCaxumba.ConvertIntNullForBool(),
                    Sarampo = prontuario.TeveSarampo.ConvertIntNullForBool(),
                    Amigdalite = prontuario.TeveAmigdalite.ConvertIntNullForBool(),
                    Outras = prontuario.OutrasDoencaInfancia
                },
                DistubiosCardiovasculares = new DistubiosCardiovasculares
                {
                    FebreReumatica = prontuario.TeveFebreReumatica.ConvertIntNullForBool(),
                    Sopros = prontuario.TeveSopros.ConvertIntNullForBool(),
                    PatologiasValvulas = prontuario.TevePatologiasDeValvulas.ConvertIntNullForBool(),
                    AnomaliasCongenitasCardiacas = prontuario.TeveAnomaliasCongenitasCardiacas.ConvertIntNullForBool(),
                    Hirpertensao = prontuario.TeveHipertensao.ConvertIntNullForBool(),
                    Arritmias = prontuario.TeveArritmias.ConvertIntNullForBool(),
                    InfartoMiocardio = prontuario.TeveInfartoDoMiocardio.ConvertIntNullForBool(),
                    AngiaOuDorNoTorax = prontuario.TeveAnginaOuDorTorax.ConvertIntNullForBool(),
                    CirurgiasCardiacas = prontuario.FezCirurgiasCardiacas.ConvertIntNullForBool(),
                    MarcaPasso = prontuario.MarcaPasso.ConvertIntNullForBool(),
                    AVC = prontuario.TeveAVC.ConvertIntNullForBool(),
                    Outras = prontuario.OutrosDisturbiosCardiovasculares
                },
                DistubiosRespiratorios = new DistubiosRespiratorios
                {
                    Asma = prontuario.Asma.ConvertIntNullForBool(),
                    DoencaPulmonares = prontuario.DoencaPulmonares.ConvertIntNullForBool(),
                    Sinusite = prontuario.Sinusite.ConvertIntNullForBool(),
                    Rinite = prontuario.Rinite.ConvertIntNullForBool(),
                    Outras = prontuario.OutrosDisturbiosRespiratorios
                },
                DistubiosEndocrinos = new DistubiosEndocrinos
                {
                    Diabetes = prontuario.Diabetes.ConvertIntNullForBool(),
                    DisfuncaoTireoide = prontuario.DisfuncaoTireoide.ConvertIntNullForBool(),
                    Menarca = prontuario.Menarca,
                    Menopausa = prontuario.Menopausa,
                    Gravidez = prontuario.Gravidez,
                    Partos = prontuario.Partos,
                    Outras = prontuario.OutrosDisturbiosEndocrinos
                },
                DisturbiosNeurologicos = new DisturbiosNeurologicos
                {
                    Desmaios = prontuario.Desmaios.ConvertIntNullForBool(),
                    Convulsoes = prontuario.Convulsoes.ConvertIntNullForBool(),
                    Enxaquecas = prontuario.Enxaquecas.ConvertIntNullForBool(),
                    Cefaleias = prontuario.Cefaleias.ConvertIntNullForBool(),
                    NevralgiaNaFace = prontuario.NevralgiaNaFace.ConvertIntNullForBool(),
                    Outras = prontuario.OutrosDisturbiosNeurologicos
                },
                DisturbiosHematologicos = new DisturbiosHematologicos
                {
                    Anemia = prontuario.Anemia.ConvertIntNullForBool(),
                    Hemorragia = prontuario.Hemorragia.ConvertIntNullForBool(),
                    Hemofilia = prontuario.Hemofilia.ConvertIntNullForBool(),
                    Leucemia = prontuario.Leucemia.ConvertIntNullForBool(),
                    Outras = prontuario.OutrosDisturbiosHematologicos,
                    DataDoacaoSangue = prontuario.DataDoacaoSangue,
                    DoouOuRecebeuSangue = prontuario.DoouOuRecebeuSangue.ConvertIntNullForBool()
                },
                DisturbiosPsiquiatricos = new DisturbiosPsiquiatricos
                {
                    TratamentoPsiquiatrico = prontuario.TratamentoPsiquiatrico.ConvertIntNullForBool(),
                    Depressao = prontuario.Depressao.ConvertIntNullForBool(),
                    Ansiedade = prontuario.Ansiedade.ConvertIntNullForBool(),
                    Outras = prontuario.OutrosDisturbiosPsiquiatricos
                },
                DisturbiosArticulacoesOuOssos = new DisturbiosArticulacoesOuOssos
                {
                    JaSofreuTraumatismoNaFace = prontuario.JaSofreuTraumatismoNaFace.ConvertIntNullForBool(),
                    Artrite = prontuario.Artrite.ConvertIntNullForBool(),
                    Reumatismo = prontuario.Reumatismo.ConvertIntNullForBool(),
                    Osteoporose = prontuario.Osteoporose.ConvertIntNullForBool(),
                    Outros = prontuario.OutrosDisturbiosArticulacoesOuOssos
                },
                DisturbiosArticulacaoTemporamandibular = new DisturbiosArticulacaoTemporamandibular
                {
                    BruxismoCentrico = prontuario.BruxismoCentrico.ConvertIntNullForBool(),
                    BruxismoExcentrico = prontuario.BruxismoExcentrico.ConvertIntNullForBool(),
                    MastigacaoUnilateral = prontuario.MastigacaoUnilateral.ConvertIntNullForBool(),
                    DorRegiaoDosOuvidos = prontuario.DorRegiaoDosOuvidos.ConvertIntNullForBool(),
                    EstalidoNaAberturaEFechamentoBucal = prontuario.EstalidoNaAberturaEFechamentoBucal.ConvertIntNullForBool(),
                    Outros = prontuario.OutrosDisturbiosArticulacaoTemporamandibular
                },
                DisturbiosGastrointestinais = new()
                {
                    Cirrose = prontuario.Cirrose.ConvertIntNullForBool(),
                    Gastrite = prontuario.Gastrite.ConvertIntNullForBool(),
                    Ulceras = prontuario.Ulceras.ConvertIntNullForBool(),
                    Outras = prontuario.OutrosDisturbiosGastrointestinais
                },
                DistubiosGenitourinarias = new()
                {
                    InfeccoesTratoUrinario = prontuario.InfeccoesDoTratoUrinario.ConvertIntNullForBool(),
                    DoencasGionecologicas = prontuario.DoencaGinecologicas.ConvertIntNullForBool(),
                    Outras = prontuario.OutrosDisturbiosGenitourinarias,
                    DoencasRenais = new()
                    {
                        FazHemodialise = prontuario.FazHemodialise.ConvertIntNullForBool(),
                        InsuficienciaRenal = prontuario.InsuficienciaRenal.ConvertIntNullForBool(),
                        Nefrite = prontuario.Nefrite.ConvertIntNullForBool(),
                        Quais = prontuario.QuaisHemodialises,
                    }
                },
                DoencaTransmissiveis = new DoencaTransmissiveis
                {
                    Hepatite = prontuario.Hepatite.ConvertIntNullForBool(),
                    Herpes = prontuario.Herpes.ConvertIntNullForBool(),
                    HIV = prontuario.HIV.ConvertIntNullForBool(),
                    Tuberculose = prontuario.Tuberculose.ConvertIntNullForBool(),
                    DoencaSexualmenteTransmissivel = prontuario.DoencaSexualmenteTransmissivel.ConvertIntNullForBool(),
                    Quais = prontuario.QuaisDoencaTransmissiveis,
                    Outras = prontuario.OutrasDoencasTransmissiveis
                },
                Alergias = new Alergias
                {
                    Anestesia = prontuario.Anestesia.ConvertIntNullForBool(),
                    Alimentos = prontuario.Alimentos.ConvertIntNullForBool(),
                    Cosmeticos = prontuario.Cosmeticos.ConvertIntNullForBool(),
                    Urticaria = prontuario.Urticaria.ConvertIntNullForBool(),
                    Quais = prontuario.QuaisAlergias,
                    Medicamentos = prontuario.Medicamentos.ConvertIntNullForBool(),
                    QuaisMedicamentos = prontuario.QuaisMedicamentos,
                    Outras = prontuario.OutrasAlergias
                }
            },
            UsoMedicamentos = new UsoMedicamentos
            {
                FazUsoDeMedicamentos = prontuario.FazUsoDeMedicamentos.ConvertIntNullForBool(),
                NomeComercial = prontuario.NomeComercial,
                NomeGenerico = prontuario.NomeGenerico,
                Dosagem = prontuario.Dosagem,
                FrequenciaUso = prontuario.FrequenciaUso,
                VisitasMedicas = prontuario.VisitasMedicas,
                Hospitalizacoes = prontuario.Hospitalizacoes,
                Observacoes = prontuario.Observacoes,
                DadosRelevantesHistoriaMedica = prontuario.DadosRelevantesHistoriaMedica,
            },
            HistoriaFamiliar = new HistoriaFamiliar
            {
                Pai = prontuario.Pai,
                Mae = prontuario.Mae,
                Irmaos = prontuario.Irmaos
            },
            TendenciasHereditarias = new TendenciasHereditarias
            {
                Cardiopatias = prontuario.Cardiopatias.ConvertIntNullForBool(),
                Hipertensao = prontuario.Hipertensao.ConvertIntNullForBool(),
                Diabete = prontuario.DiabeteHereditaria.ConvertIntNullForBool(),
                Asma = prontuario.AsmaHereditaria.ConvertIntNullForBool(),
                DisturbioSangramento = prontuario.DisturbioSangramento.ConvertIntNullForBool(),
                Alergias = prontuario.AlergiasHereditaria.ConvertIntNullForBool(),
                NeoplasiasMalignas = prontuario.NeoplastiasMalignas.ConvertIntNullForBool(),
                DoencaNeurologicas = prontuario.DoencaNeurologicas.ConvertIntNullForBool(),
                Tuberculose = prontuario.TuberculoseHereditaria.ConvertIntNullForBool(),
                Complemento = prontuario.Complemento,
                OutrasDoencas = prontuario.OutrasDoencasHereditarias
            },
            Habitos = new Habitos
            {
                Alcool = prontuario.HabitoAlcool.ConvertIntNullForBool(),
                FrequenciaAlcool = prontuario.FrequenciaAlcool,
                Fumo = prontuario.HabitoFumo.ConvertIntNullForBool(),
                FrequenciaFumo = prontuario.FrequenciaFumo,
                OutrosHabitosNocivos = prontuario.OutrosHabitosNocivos
            },
            HabitoHigieneBucal = new HabitoHigieneBucal
            {
                Escovacao = prontuario.Escovacao,
                FioDental = prontuario.FioDental,
                EnxaguatorioBucal = prontuario.EnxaguatorioBucal
            },
            Curativos = new Curativos
            {
                PrimeiraSessao = prontuario.CurativoSessao1,
                SegundaSessao = prontuario.CurativoSessao2,
                TerceiraSessao = prontuario.CurativoSessao3,
                QuartaSessao = prontuario.CurativoSessao4,
                QuintaSessao = prontuario.CurativoSessao5,
                SextaSessao = prontuario.CurativoSessao6,
            },
            DescricaoDente = new DescricaoDente
            {
                Observacoes = prontuario.ObservacoesDentes
            },
            DiagnosticosDente = new DiagnosticosDente
            {
                Observacoes = prontuario.ObservacoesDiagnosticoDentes
            }
        };

        return request;
    }

    public async Task<IActionResult> PostUploadImagem(PostUploadImagemRequest request)
    {
        if(request.IdProntuario <= 0)
            return BadRequest(OdonTrackErrors.ProntuarioNotFound);

        if (request.Imagem == null || request.Imagem.Length <= 0)
            return BadRequest(OdonTrackErrors.ImagemEmpty);

        var prontuario = await _context.Prontuarios.AnyAsync(x => x.Id.Equals(request.IdProntuario));
        if (!prontuario)
            return BadRequest(OdonTrackErrors.ProntuarioNotFound);

        var permittedExtensions = new[] { ".jpg", ".jpeg", ".png" };
        var ext = Path.GetExtension(request.Imagem.FileName).ToLowerInvariant();
        if (string.IsNullOrEmpty(ext) || !permittedExtensions.Contains(ext))
            return BadRequest(OdonTrackErrors.ImagemInvalid);

        string fileName = $"{request.IdProntuario}_{request.TipoImagem.ToString()}_{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}.{request.Imagem.ContentType.Replace("image/", "")}";

        var path = Path.Combine("/app/imagens-prontuario/", fileName);
        if (!Directory.Exists(Path.Combine("/app", "imagens-prontuario")))
            Directory.CreateDirectory(Path.Combine("/app/imagens-prontuario"));

        using (var strem = new FileStream(path, FileMode.Create))
        {
            await request.Imagem.CopyToAsync(strem);
        }

        await _context.ImagensProntuarios.AddAsync(new()
        {
            IdProntuario = request.IdProntuario,
            Path = path,
            TipoImagem = request.TipoImagem.ToString(),
            Filename = fileName,
            ContentType = request.Imagem.ContentType
        });
        await _context.SaveChangesAsync();

        return Created();
    }

    public async Task<IActionResult> GetImagensProntuario(int idProntuario, string tipoImagem = "")
    {
        if (idProntuario <= 0)
            return BadRequest(OdonTrackErrors.ProntuarioNotFound);

        var prontuario = await _context.Prontuarios.AnyAsync(x => x.Id.Equals(idProntuario));
        if (!prontuario)
            return BadRequest(OdonTrackErrors.ProntuarioNotFound);

        if (!string.IsNullOrEmpty(tipoImagem))
        {
            var imagensTipo = await _context.ImagensProntuarios.Where(x => x.IdProntuario.Equals(idProntuario) && x.TipoImagem.Equals(tipoImagem)).ToListAsync();
            if (imagensTipo.Count == 0)
                return NoContent();

            var imagensResponseTipo = new List<GetImagensProntuarioResponse>();
            foreach (var imagem in imagensTipo)
            {
                var imagemPath = Path.Combine("/app", imagem.Path);
                if (!File.Exists(imagemPath))
                    continue;

                var imagemBytes = File.ReadAllBytes(imagemPath);
                var base64String = Convert.ToBase64String(imagemBytes);
                imagensResponseTipo.Add(new()
                {
                    IdImagem = imagem.Id,
                    TipoImagem = imagem.TipoImagem,
                    ContentType = imagem.ContentType,
                    Filename = imagem.Filename,
                    Imagem = base64String,
                });
            }

            return Ok(new { Imagens = imagensResponseTipo });
        }

        var imagens = await _context.ImagensProntuarios.Where(x => x.IdProntuario.Equals(idProntuario)).ToListAsync();
        if(imagens.Count == 0)
            return NoContent();

        var imagensResponse = new List<GetImagensProntuarioResponse>();
        foreach(var imagem in imagens)
        {
            var imagemPath = Path.Combine("/app", imagem.Path);
            if(!File.Exists(imagemPath))
                continue;

            var imagemBytes = File.ReadAllBytes(imagemPath);
            var base64String = Convert.ToBase64String(imagemBytes);
            imagensResponse.Add(new()
            {
                IdImagem = imagem.Id,
                TipoImagem = imagem.TipoImagem,
                ContentType = imagem.ContentType,
                Filename = imagem.Filename,
                Imagem = base64String,
            });
        }

        return Ok(new { Imagens = imagensResponse });
    }

    public async Task<IActionResult> DeleteImagemProntuario(int idImagem)
    {
        if (idImagem <= 0)
            return BadRequest(OdonTrackErrors.ImagemNotFound);

        var imagem = await _context.ImagensProntuarios.FirstOrDefaultAsync(x => x.Id.Equals(idImagem));
        if (imagem == null)
            return BadRequest(OdonTrackErrors.ImagemNotFound);

        var imagemPath = Path.Combine("/app", imagem.Path);
        if (!File.Exists(imagemPath))
            return BadRequest(OdonTrackErrors.ImagemNotFound);

        File.Delete(imagemPath);
        _context.ImagensProntuarios.Remove(imagem);
        await _context.SaveChangesAsync();

        return Deleted();
    }
}