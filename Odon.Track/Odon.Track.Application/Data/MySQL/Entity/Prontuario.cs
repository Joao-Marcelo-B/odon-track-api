using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Odon.Track.Application.Data.MySQL.Entity;

[Table("prontuario")]
public partial class Prontuario
{
    [Column("id")] public int Id { get; set; }
    [Column("id_paciente")] public int? IdPaciente { get; set; } = null;
    [Column("id_professor_vinculado")] public int? IdProfessorVinculado { get; set; } = null;
    [Column("id_estudante_vinculado")] public int? IdEstudanteVinculado { get; set; } = null;
    [Column("id_prontuario_status")] public int? IdProntuarioStatus { get; set; } = null;
    [Column("data_cadastro")] public DateTime? DataCadastro { get; set; } = null;
    [Column("queixa_principal")] public string QueixaPrincipal { get; set; } = null;
    [Column("historia_doenca_atual")] public string HistoriaDoencaAtual { get; set; } = null;
    [Column("teve_catapora")] public int? TeveCatapora { get; set; } = null;
    [Column("teve_caxumba")] public int? TeveCaxumba { get; set; } = null;
    [Column("teve_sarampo")] public int? TeveSarampo { get; set; } = null;
    [Column("teve_amigdalite")] public int? TeveAmigdalite { get; set; } = null;
    [Column("outras_doenca_infancia")] public string OutrasDoencaInfancia { get; set; } = null;
    [Column("teve_febre_reumatica")] public int? TeveFebreReumatica { get; set; } = null;
    [Column("teve_sopros")] public int? TeveSopros { get; set; } = null;
    [Column("teve_patologias_de_valvulas")] public int? TevePatologiasDeValvulas { get; set; } = null;
    [Column("teve_anomalias_congenitas_cardiacas")] public int? TeveAnomaliasCongenitasCardiacas { get; set; } = null;
    [Column("teve_hipertensao")] public int? TeveHipertensao { get; set; } = null;
    [Column("teve_arritmias")] public int? TeveArritmias { get; set; } = null;
    [Column("teve_infarto_do_miocardio")] public int? TeveInfartoDoMiocardio { get; set; } = null;
    [Column("teve_angina_ou_dor_torax")] public int? TeveAnginaOuDorTorax { get; set; } = null;
    [Column("fez_cirurgias_cardiacas")] public int? FezCirurgiasCardiacas { get; set; } = null;
    [Column("marca_passo")] public int? MarcaPasso { get; set; } = null;
    [Column("teve_avc")] public int? TeveAVC { get; set; } = null;
    [Column("outros_disturbios_cardiovasculares")] public string OutrosDisturbiosCardiovasculares { get; set; } = null;
    [Column("asma")] public int? Asma { get; set; } = null;
    [Column("doenca_pulmonares")] public int? DoencaPulmonares { get; set; } = null;
    [Column("sinusite")] public int? Sinusite { get; set; } = null;
    [Column("rinite")] public int? Rinite { get; set; } = null;
    [Column("outros_disturbios_respiratorios")] public string OutrosDisturbiosRespiratorios { get; set; } = null;
    [Column("diabetes")] public int? Diabetes { get; set; } = null;
    [Column("disfuncao_tireoide")] public int? DisfuncaoTireoide { get; set; } = null;
    [Column("menarca")] public int? Menarca { get; set; } = null;
    [Column("menopausa")] public int? Menopausa { get; set; } = null;
    [Column("gravidez")] public int? Gravidez { get; set; } = null;
    [Column("partos")] public int? Partos { get; set; } = null;
    [Column("outros_disturbios_endocrinos")] public string OutrosDisturbiosEndocrinos { get; set; } = null;
    [Column("desmaios")] public int? Desmaios { get; set; } = null;
    [Column("convulsoes")] public int? Convulsoes { get; set; } = null;
    [Column("enxaquecas")] public int? Enxaquecas { get; set; } = null;
    [Column("cefaleias")] public int? Cefaleias { get; set; } = null;
    [Column("nevralgia_na_face")] public int? NevralgiaNaFace { get; set; } = null;
    [Column("outros_disturbios_neurologicos")] public string OutrosDisturbiosNeurologicos { get; set; } = null;
    [Column("anemia")] public int? Anemia { get; set; } = null;
    [Column("hemorragia")] public int? Hemorragia { get; set; } = null;
    [Column("hemofilia")] public int? Hemofilia { get; set; } = null;
    [Column("leucemia")] public int? Leucemia { get; set; } = null;
    [Column("outros_disturbios_hematologicos")] public string OutrosDisturbiosHematologicos { get; set; } = null;
    [Column("doou_ou_recebeu_sangue")] public int? DoouOuRecebeuSangue { get; set; } = null;
    [Column("data_doacao_sangue")] public DateTime? DataDoacaoSangue { get; set; } = null;
    [Column("tratamento_psiquiatrico")] public int? TratamentoPsiquiatrico { get; set; } = null;
    [Column("depressao")] public int? Depressao { get; set; } = null;
    [Column("ansiedade")] public int? Ansiedade { get; set; } = null;
    [Column("outros_disturbios_psiquiatricos")] public string OutrosDisturbiosPsiquiatricos { get; set; } = null;
    [Column("ja_sofreu_traumatismo_na_face")] public int? JaSofreuTraumatismoNaFace { get; set; } = null;
    [Column("artrite")] public int? Artrite { get; set; } = null;
    [Column("reumatismo")] public int? Reumatismo { get; set; } = null;
    [Column("osteoporose")] public int? Osteoporose { get; set; } = null;
    [Column("outros_disturbios_articulacoes_ou_ossos")] public string OutrosDisturbiosArticulacoesOuOssos { get; set; } = null;
    [Column("bruxismo_centrico")] public int? BruxismoCentrico { get; set; } = null;
    [Column("bruxismo_excentrico")] public int? BruxismoExcentrico { get; set; } = null;
    [Column("mastigacao_unilateral")] public int? MastigacaoUnilateral { get; set; } = null;
    [Column("dor_regiao_dos_ouvidos")] public int? DorRegiaoDosOuvidos { get; set; } = null;
    [Column("estalido_na_abertura_e_fechamento_bucal")] public int? EstalidoNaAberturaEFechamentoBucal { get; set; } = null;
    [Column("outros_disturbios_articulacao_temporamandibular")] public string OutrosDisturbiosArticulacaoTemporamandibular { get; set; } = null;
    [Column("hepatite")] public int? Hepatite { get; set; } = null;
    [Column("herpes")] public int? Herpes { get; set; } = null;
    [Column("hiv")] public int? HIV { get; set; } = null;
    [Column("tuberculose")] public int? Tuberculose { get; set; } = null;
    [Column("doenca_sexualmente_transmissivel")] public int? DoencaSexualmenteTransmissivel { get; set; } = null;
    [Column("quais_doenca_transmissiveis")] public string QuaisDoencaTransmissiveis { get; set; } = null;
    [Column("outras_doencas_transmissiveis")] public string OutrasDoencasTransmissiveis { get; set; } = null;
    [Column("anestesia")] public int? Anestesia { get; set; } = null;
    [Column("alimentos")] public int? Alimentos { get; set; } = null;
    [Column("cosmeticos")] public int? Cosmeticos { get; set; } = null;
    [Column("urticaria")] public int? Urticaria { get; set; } = null;
    [Column("quais_alergias")] public string QuaisAlergias { get; set; } = null;
    [Column("medicamentos")] public int? Medicamentos { get; set; } = null;
    [Column("quais_medicamentos")] public string QuaisMedicamentos { get; set; } = null;
    [Column("outras_alergias")] public string OutrasAlergias { get; set; } = null;
    [Column("faz_uso_de_medicamentos")] public int? FazUsoDeMedicamentos { get; set; } = null;
    [Column("descricao_medicamentos")] public string DescricaoMedicamentos { get; set; } = null;
    [Column("visitas_medicas")] public string VisitasMedicas { get; set; } = null;
    [Column("hospitalizacoes")] public string Hospitalizacoes { get; set; } = null;
    [Column("observacoes")] public string Observacoes { get; set; } = null;
    [Column("dados_relevantes_historia_medica")] public string DadosRelevantesHistoriaMedica { get; set; } = null;
    [Column("pai")] public string Pai { get; set; } = null;
    [Column("mae")] public string Mae { get; set; } = null;
    [Column("irmaos")] public string Irmaos { get; set; } = null;
    [Column("cardiopatias")] public int? Cardiopatias { get; set; } = null;
    [Column("hipertensao")] public int? Hipertensao { get; set; } = null;
    [Column("diabete_hereditaria")] public int? DiabeteHereditaria { get; set; } = null;
    [Column("asma_hereditaria")] public int? AsmaHereditaria { get; set; } = null;
    [Column("disturbio_sangramento")] public int? DisturbioSangramento { get; set; } = null;
    [Column("alergias_hereditaria")] public int? AlergiasHereditaria { get; set; } = null;
    [Column("neoplastias_malignas")] public int? NeoplastiasMalignas { get; set; } = null;
    [Column("doenca_neurologicas")] public int? DoencaNeurologicas { get; set; } = null;
    [Column("tuberculose_hereditaria")] public int? TuberculoseHereditaria { get; set; } = null;
    [Column("complemento")] public string Complemento { get; set; } = null;
    [Column("outras_doencas_hereditarias")] public string OutrasDoencasHereditarias { get; set; } = null;
    [Column("habito_alcool")] public int? HabitoAlcool { get; set; } = null;
    [Column("frequencia_alcool")] public string FrequenciaAlcool { get; set; } = null;
    [Column("habito_fumo")] public int? HabitoFumo { get; set; } = null;
    [Column("frequencia_fumo")] public string FrequenciaFumo { get; set; } = null;
    [Column("outros_habitos_nocivos")] public string OutrosHabitosNocivos { get; set; } = null;
    [Column("escovacao")] public string Escovacao { get; set; } = null;
    [Column("fio_dental")] public string FioDental { get; set; } = null;
    [Column("enxaguatorio_bucal")] public string EnxaguatorioBucal { get; set; } = null;
    [Column("observacoes_dentes")] public string ObservacoesDentes { get; set; } = null;
    [Column("observacoes_diagnostico_dentes")] public string ObservacoesDiagnosticoDentes { get; set; } = null;
    [Column("plano_cronologico_tratamento")] public string PlanoCronologicoTratamento { get; set; } = null;
    [Column("gastrite")] public int? Gastrite { get; set; } = null;
    [Column("ulceras")] public int? Ulceras { get; set; } = null;
    [Column("cirrose")] public int? Cirrose { get; set; } = null;
    [Column("outros_disturbios_gastrointestinais")] public string OutrosDisturbiosGastrointestinais { get; set; } = null;
    [Column("infeccoes_do_trato_urinario")] public int? InfeccoesDoTratoUrinario { get; set; } = null;
    [Column("doenca_ginecologicas")] public int? DoencaGinecologicas { get; set; } = null;
    [Column("nefrite")] public int? Nefrite { get; set; } = null;
    [Column("insuficiencia_renal")] public int? InsuficienciaRenal { get; set; } = null;
    [Column("faz_hemodialise")] public int? FazHemodialise { get; set; } = null;
    [Column("quais_hemodialises")] public string QuaisHemodialises { get; set; } = null;
    [Column("outros_disturbios_genitourinarias")] public string OutrosDisturbiosGenitourinarias { get; set; } = null;
    [Column("pressao_arterial")]
    public string PressaoArterial { get; set; } = null;

    [Column("frequencia_respiratoria")]
    public string FrequenciaRespiratoria { get; set; } = null;

    [Column("pulso")]
    public string Pulso { get; set; } = null;

    [Column("temperatura_axilar")]
    public string TemperaturaAxilar { get; set; } = null;

    [Column("ectoscopia")]
    public string Ectoscopia { get; set; } = null;

    [Column("oroscopia")]
    public string Oroscopia { get; set; } = null;

    [Column("exames_complementares_solicitados")]
    public string ExamesComplementaresSolicitados { get; set; } = null;

    [Column("pedido_avaliacao_medica")]
    public bool? PedidoAvaliacaoMedica { get; set; } = null;

    [Column("motivo")]
    public string Motivo { get; set; } = null;

    [Column("data_pedido_avaliacao_medica")]
    public DateTime? DataPedidoAvaliacaoMedica { get; set; } = null;

    [Column("parecer_medico")]
    public string ParecerMedico { get; set; } = null;

    [Column("paciente_portador_de")]
    public string PacientePortadorDe { get; set; } = null;

    [Column("necessita_de_cuidados_especiais_relacao")]
    public string NecessitaDeCuidadosEspeciaisRelacao { get; set; } = null;

    [Column("observacoes_exame_fisico")]
    public string ObservacoesExameFisico { get; set; } = null;

    [ForeignKey(nameof(IdPaciente))]
    public Paciente Paciente { get; set; } = null;

    [ForeignKey(nameof(IdProfessorVinculado))]
    public Professor ProfessorVinculado { get; set; } = null;

    [ForeignKey(nameof(IdEstudanteVinculado))]
    public Estudante EstudanteVinculado { get; set; } = null;

    //public ICollection<ProntuarioEstudante> ProntuarioEstudantes { get; } = new List<ProntuarioEstudante>();

    //public ICollection<ProntuarioStatus> ProntuarioStatuses { get; } = new List<ProntuarioStatus>();
}
