namespace Odon.Track.Application.Data.MySQL.Entity;
public partial class PostProntuarioProntoAtendimentoRequest
{
    public int? Id { get; set; }
    public int? IdPaciente { get; set; }
    public int? IdProfessorVinculado { get; set; }
    public int? IdEstudanteVinculado { get; set; }
    public string QueixaPrincipal { get; set; } = null!;
    public string HistoriaMolestiaAtual { get; set; } = null!;
    public int? JaTomouAnestesiaOdontologica { get; set; }
    public int? TeveAlgumaReacaoIndesejavel { get; set; }
    public int? EstaSobTratamentoMedico { get; set; }
    public string MotivoTratamentoMedico { get; set; }
    public int? EstaTomandoAlgumMedicamento { get; set; }
    public string QualMedicamento { get; set; }
    public int? AlergiaAlgumMedicamentoSubstancia { get; set; }
    public string QualMedicamentoSubstancia { get; set; }
    public int? EDiabetico { get; set; }
    public int? EstaGravida { get; set; }
    public int? SofreDisturbiosCardiovasculares { get; set; }
    public string QualDisturbioCardiovascular { get; set; }
    public int? TemHipertensao { get; set; }
    public int? FazUsoProteseCardiaca { get; set; }
    public string OutrosDisturbiosCardiovascular { get; set; }
    public int? ApresentaHistoriaHemorragia { get; set; }
    public int? ApresentaHistoriaFebreReumatica { get; set; }
    public int? Bronquite { get; set; }
    public int? Asma { get; set; }
    public string OutrosDisturbiosRespiratorios { get; set; }
    public int? SofreDisturbioGastroIntestinal { get; set; }
    public int? Gastrite { get; set; }
    public int? Ulcera { get; set; }
    public int? Hepatite { get; set; }
    public int? Cirrose { get; set; }
    public int? TeveDoencaInfectoContagiosa { get; set; }
    public string QualDoencaInfectoContagiosa { get; set; }
    public int? ExisteDoencaPredominanteFamilia { get; set; }
    public string QualDoencaPredominante { get; set; }
    public string OutrasInformacoesHabitosVicios { get; set; }
    public string Observacoes { get; set; }
    public string PressaoArterialMmMmHg { get; set; } = null!;
    public string Diagnostico { get; set; } = null!;
    public string CidadeFichaFeita { get; set; } = null!;
    public DateTime DataFichaFeita { get; set; }
    public List<CondutaProntoAtendimento> CondutaProntoAtendimentos { get; set; } = new List<CondutaProntoAtendimento>();
}

public partial class RequestCondutaProntoAtendimento
{
    public int Id { get; set; }
    public int IdProntuarioProntoAtendimento { get; set; }
    public string CodSus { get; set; } = null!;
    public string Conduta { get; set; } = null!;
}
