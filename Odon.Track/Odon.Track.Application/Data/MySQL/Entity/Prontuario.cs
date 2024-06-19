using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Odon.Track.Application.Data.MySQL.Entity;

[Table("prontuario")]
public partial class Prontuario
{
    [Column("id")]
    public int? Id { get; set; } = null;

    [Column("id_paciente")]
    public int? IdPaciente { get; set; } = null;

    [Column("id_professor_vinculado")]
    public int? IdProfessorVinculado { get; set; } = null;
    [Column("id_estudante_vinculado")]
    public int? IdEstudanteVinculado { get; set; } = null;

    [Column("id_prontuario_status")]
    public int? IdProntuarioStatus { get; set; } = null;
    [Column("assinado_professor")]
    public int? AssinadoProfessor { get; set; } = null;

    [Column("queixa_principal")]
    public string QueixaPrincipal { get; set; } = null;

    [Column("historia_doenca_atual")]
    public string HistoriaDoencaAtual { get; set; } = null;

    [Column("teve_catapora")]
    public int? TeveCatapora { get; set; } = null;

    [Column("teve_sarampo")]
    public int? TeveSarampo { get; set; } = null;

    [Column("teve_amigdalite")]
    public int? TeveAmigdalite { get; set; } = null;

    [Column("outras_doenca_infancia")]
    public string OutrasDoencaInfancia { get; set; } = null;

    [Column("teve_febre_reumatica")]
    public int? TeveFebreReumatica { get; set; } = null;

    [Column("teve_sopros")]
    public int? TeveSopros { get; set; } = null;

    [Column("teve_patologias_de_valvulas")]
    public int? TevePatologiasDeValvulas { get; set; } = null;

    [Column("teve_anomalias_congenitas_cardiacas")]
    public int? TeveAnomaliasCongenitasCardiacas { get; set; } = null;

    [Column("teve_hipertensao")]
    public int? TeveHipertensao { get; set; } = null;

    [Column("teve_arritmias")]
    public int? TeveArritmias { get; set; } = null;

    [Column("teve_infarto_do_miocardio")]
    public int? TeveInfartoDoMiocardio { get; set; } = null;

    [Column("teve_angina_ou_dor_torax")]
    public int? TeveAnginaOuDorTorax { get; set; } = null;

    [Column("fez_cirurgias_cardiacas")]
    public int? FezCirurgiasCardiacas { get; set; } = null;

    [Column("tem_alergia_medicamentos")]
    public int? TemAlergiaMedicamentos { get; set; } = null;

    [Column("quais_medicamentos")]
    public string QuaisMedicamentos { get; set; } = null;

    [Column("outras_alergias")]
    public string OutrasAlergias { get; set; } = null;

    [Column("faz_uso_medicamento")]
    public int? FazUsoMedicamento { get; set; } = null;

    [Column("descricao_medicamento_usado")]
    public string DescricaoMedicamentoUsado { get; set; } = null;

    [Column("visitas_medicas")]
    public string VisitasMedicas { get; set; } = null;

    [Column("observacoes")]
    public string Observacoes { get; set; } = null;

    [Column("dados_relevantes_historia_medica")]
    public string DadosRelevantesHistoriaMedica { get; set; } = null;

    [Column("hereditario_pai")]
    public string HereditarioPai { get; set; } = null;

    [Column("hereditario_mae")]
    public string HereditarioMae { get; set; } = null; 

    [Column("hereditario_irmaos")]
    public string HereditarioIrmaos { get; set; } = null; 

    [Column("habito_alcool")]
    public int? HabitoAlcool { get; set; } = null;

    [Column("habito_alcool_inicio")]
    public DateTime? HabitoAlcoolInicio { get; set; } = null;

    [Column("habito_alcool_frequencia")]
    public string HabitoAlcoolFrequencia { get; set; } = null;

    [Column("habito_fumo")]
    public int? HabitoFumo { get; set; } = null;

    [Column("habito_fumo_inicio")]
    public DateTime? HabitoFumoInicio { get; set; } = null;

    [Column("habito_fumo_frequencia")]
    public string HabitoFumoFrequencia { get; set; } = null; 

    [Column("outros_habitos_nocivos")]
    public string OutrosHabitosNocivos { get; set; } = null; 

    [Column("caminho_mapa_periodental")]
    public string CaminhoMapaPeriodental { get; set; } = null; 

    [Column("data_cadastro")]
    public DateTime? DataCadastro { get; set; } = null;


    [ForeignKey(nameof(IdPaciente))]
    public Paciente Paciente { get; set; } = null;

    [ForeignKey(nameof(IdProfessorVinculado))]
    public Professor ProfessorVinculado { get; set; } = null;

    [ForeignKey(nameof(IdEstudanteVinculado))]
    public Estudante EstudanteVinculado { get; set; } = null;

    //public ICollection<ProntuarioEstudante> ProntuarioEstudantes { get; } = new List<ProntuarioEstudante>();

    //public ICollection<ProntuarioStatus> ProntuarioStatuses { get; } = new List<ProntuarioStatus>();
}
