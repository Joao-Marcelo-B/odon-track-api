using System.ComponentModel.DataAnnotations.Schema;

namespace Odon.Track.Application.Data.MySQL.Entity;

[Table("prontuario")]
public partial class Prontuario
{
    [Column("id")]
    public int? Id { get; set; }

    [Column("id_paciente")]
    public int? IdPaciente { get; set; }

    [Column("id_professor_vinculado")]
    public int? IdProfessorVinculado { get; set; }
    [Column("id_estudante_vinculado")]
    public int? IdEstudanteVinculado { get; set; }

    [Column("id_prontuario_status")]
    public int? IdProntuarioStatus { get; set; }

    [Column("queixa_principal")]
    public string QueixaPrincipal { get; set; }

    [Column("historia_doenca_atual")]
    public string HistoriaDoencaAtual { get; set; }

    [Column("teve_catapora")]
    public int? TeveCatapora { get; set; }

    [Column("teve_sarampo")]
    public int? TeveSarampo { get; set; }

    [Column("teve_amigdalite")]
    public int? TeveAmigdalite { get; set; }

    [Column("outras_doenca_infancia")]
    public string OutrasDoencaInfancia { get; set; }

    [Column("teve_febre_reumatica")]
    public int? TeveFebreReumatica { get; set; }

    [Column("teve_sopros")]
    public int? TeveSopros { get; set; }

    [Column("teve_patologias_de_valvulas")]
    public int? TevePatologiasDeValvulas { get; set; }

    [Column("teve_anomalias_congenitas_cardiacas")]
    public int? TeveAnomaliasCongenitasCardiacas { get; set; }

    [Column("teve_hipertensao")]
    public int? TeveHipertensao { get; set; }

    [Column("teve_arritmias")]
    public int? TeveArritmias { get; set; }

    [Column("teve_infarto_do_miocardio")]
    public int? TeveInfartoDoMiocardio { get; set; }

    [Column("teve_angina_ou_dor_torax")]
    public int? TeveAnginaOuDorTorax { get; set; }

    [Column("fez_cirurgias_cardiacas")]
    public int? FezCirurgiasCardiacas { get; set; }

    [Column("tem_alergia_medicamentos")]
    public int? TemAlergiaMedicamentos { get; set; }

    [Column("quais_medicamentos")]
    public string QuaisMedicamentos { get; set; }

    [Column("outras_alergias")]
    public string OutrasAlergias { get; set; }

    [Column("faz_uso_medicamento")]
    public int? FazUsoMedicamento { get; set; }

    [Column("descricao_medicamento_usado")]
    public string DescricaoMedicamentoUsado { get; set; }

    [Column("visitas_medicas")]
    public string VisitasMedicas { get; set; }

    [Column("observacoes")]
    public string Observacoes { get; set; }

    [Column("dados_relevantes_historia_medica")]
    public string DadosRelevantesHistoriaMedica { get; set; }

    [Column("hereditario_pai")]
    public string HereditarioPai { get; set; }

    [Column("hereditario_mae")]
    public string HereditarioMae { get; set; } 

    [Column("hereditario_irmaos")]
    public string HereditarioIrmaos { get; set; } 

    [Column("habito_alcool")]
    public int? HabitoAlcool { get; set; }

    [Column("habito_alcool_inicio")]
    public DateTime? HabitoAlcoolInicio { get; set; }

    [Column("habito_alcool_frequencia")]
    public string HabitoAlcoolFrequencia { get; set; }

    [Column("habito_fumo")]
    public int? HabitoFumo { get; set; }

    [Column("habito_fumo_inicio")]
    public DateTime? HabitoFumoInicio { get; set; }

    [Column("habito_fumo_frequencia")]
    public string HabitoFumoFrequencia { get; set; } 

    [Column("outros_habitos_nocivos")]
    public string OutrosHabitosNocivos { get; set; } 

    [Column("caminho_mapa_periodental")]
    public string CaminhoMapaPeriodental { get; set; } 

    [Column("data_cadastro")]
    public DateTime? DataCadastro { get; set; }


    [ForeignKey(nameof(IdPaciente))]
    public Paciente Paciente { get; set; } = null!;

    [ForeignKey(nameof(IdProfessorVinculado))]
    public Professor ProfessorVinculado { get; set; } = null!;

    [ForeignKey(nameof(IdEstudanteVinculado))]
    public Estudante EstudanteVinculado { get; set; } = null!;

    public ICollection<ProntuarioEstudante> ProntuarioEstudantes { get; } = new List<ProntuarioEstudante>();

    public ICollection<ProntuarioStatus> ProntuarioStatuses { get; } = new List<ProntuarioStatus>();
}
