using System.ComponentModel.DataAnnotations.Schema;

namespace Odon.Track.Application.Data.MySQL.Entity;

[Table("prontuario_pronto_atendimento")]
public partial class ProntuarioProntoAtendimento
{
    [Column("id")]
    public int? Id { get; set; }

    [Column("id_paciente")]
    public int? IdPaciente { get; set; }

    [Column("id_professor_vinculado")]
    public int? IdProfessorVinculado { get; set; }

    //[Column("id_estudante_vinculado")]
    //public int? IdEstudanteVinculado { get; set; }

    [Column("queixa_principal")]
    public string QueixaPrincipal { get; set; } = null!;

    [Column("historia_molestia_atual")]
    public string HistoriaMolestiaAtual { get; set; } = null!;

    [Column("ja_tomou_anestesia_odontologica")]
    public int? JaTomouAnestesiaOdontologica { get; set; }

    [Column("teve_alguma_reacao_indesejavel")]
    public int? TeveAlgumaReacaoIndesejavel { get; set; }

    [Column("esta_sob_tratamento_medico")]
    public int? EstaSobTratamentoMedico { get; set; }

    [Column("motivo_tratamento_medico")]
    public string MotivoTratamentoMedico { get; set; }

    [Column("esta_tomando_algum_medicamento")]
    public int? EstaTomandoAlgumMedicamento { get; set; }

    [Column("qual_medicamento")]
    public string QualMedicamento { get; set; }

    [Column("alergia_algum_medicamento_substancia")]
    public int? AlergiaAlgumMedicamentoSubstancia { get; set; }

    [Column("qual_medicamento_substancia")]
    public string QualMedicamentoSubstancia { get; set; }

    [Column("e_diabetico")]
    public int? EDiabetico { get; set; }

    [Column("esta_gravida")]
    public int? EstaGravida { get; set; }

    [Column("sofre_disturbios_cardiovasculares")]
    public int? SofreDisturbiosCardiovasculares { get; set; }

    [Column("qual_disturbio_cardiovascular")]
    public string QualDisturbioCardiovascular { get; set; }

    [Column("tem_hipertensao")]
    public int? TemHipertensao { get; set; }

    [Column("faz_uso_protese_cardiaca")]
    public int? FazUsoProteseCardiaca { get; set; }

    [Column("outros")]
    public string Outros { get; set; }

    [Column("apresenta_historia_hemorragia")]
    public int? ApresentaHistoriaHemorragia { get; set; }

    [Column("apresenta_historia_febre_reumatica")]
    public int? ApresentaHistoriaFebreReumatica { get; set; }

    [Column("bronquite")]
    public int? Bronquite { get; set; }

    [Column("asma")]
    public int? Asma { get; set; }

    [Column("outros_disturbios_respiratorios")]
    public string OutrosDisturbiosRespiratorios { get; set; }

    [Column("sofre_disturbio_gastro_intestinal")]
    public int? SofreDisturbioGastroIntestinal { get; set; }

    [Column("gastrite")]
    public int? Gastrite { get; set; }

    [Column("ulcera")]
    public int? Ulcera { get; set; }

    [Column("hepatite")]
    public int? Hepatite { get; set; }

    [Column("cirrose")]
    public int? Cirrose { get; set; }

    [Column("teve_doenca_infecto_contagiosa")]
    public int? TeveDoencaInfectoContagiosa { get; set; }

    [Column("qual_doenca_infecto_contagiosa")]
    public string QualDoencaInfectoContagiosa { get; set; }

    [Column("existe_doenca_predominante_familia")]
    public int? ExisteDoencaPredominanteFamilia { get; set; }

    [Column("qual_doenca_predominante")]
    public string QualDoencaPredominante { get; set; }

    [Column("outras_informacoes_habitos_vicios")]
    public string OutrasInformacoesHabitosVicios { get; set; }

    [Column("observacoes")]
    public string Observacoes { get; set; }

    [Column("pressao_arterial_mm_mmHg")]
    public string PressaoArterialMmMmHg { get; set; } = null!;

    [Column("diagnostico")]
    public string Diagnostico { get; set; } = null!;

    [Column("aluno_assinou")]
    public int? AlunoAssinou { get; set; }

    [Column("cidade_ficha_feita")]
    public string CidadeFichaFeita { get; set; } = null!;

    [Column("data_ficha_feita")]
    public DateTime DataFichaFeita { get; set; }

    [Column("professor_assinou")]
    public int? ProfessorAssinou { get; set; }

    [Column("paciente_assinou")]
    public int? PacienteAssinou { get; set; }

    public ICollection<CondutaProntoAtendimento> CondutaProntoAtendimentos { get; } = new List<CondutaProntoAtendimento>();

    [ForeignKey(nameof(IdPaciente))]
    public Paciente Paciente { get; set; } = null!;

    [ForeignKey(nameof(IdProfessorVinculado))]
    public Professor ProfessorVinculado { get; set; } = null!;

    //[ForeignKey(nameof(IdEstudanteVinculado))]
    //public Estudante EstudanteVinculado { get; set; } = null!;

    public ICollection<ProntuarioPmEstudante> ProntuarioPmEstudantes { get; } = new List<ProntuarioPmEstudante>();
}
