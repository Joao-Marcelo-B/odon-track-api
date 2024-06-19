namespace Odon.Track.Application.Contract.Prontuarios
{
    public class PostCadastrarProntuarioRequest
    {
        public int? IdPaciente { get; set; } = null;
        public string QueixaPrincipal { get; set; } = null;
        public string HistoriaDoencaAtual { get; set; } = null;
        public HistoriaMedicaPregressaEAtual HistoriaMedicaPregressaEAtual { get; set; } = null;
        public UsoMedicamentos UsoMedicamentos { get; set; } = null;
        public string VisistasMedicas { get; set; } = null;
        public string Hospitalizacoes { get; set; } = null;
        public string Observacoes { get; set; } = null;
        public string DadosRelevantesHistoriaMedica { get; set; } = null;
        public HistoriaFamiliar HistoriaFamiliar { get; set; } = null;
        public TendenciasHereditarias TendenciasHereditarias { get; set; } = null;
        public Habitos Habitos { get; set; } = null;
        public HabitoHigieneBucal HabitoHigieneBucal { get; set; } = null;
    }

    public class  ExameFisico
    {
        public string PressaoArterial { get; set; } = null;
        public string FrequenciaRespiratoria { get; set; } = null;
        public string Pulso { get; set; } = null;
        public string TemperaturaAxiliar { get; set; } = null;
        public string Ectoscopia { get; set; } = null;
        public string Oroscopia { get; set; } = null;
        public string ExamesComplementaresSolicitados { get; set; } = null;
        public bool? PedidoAvaliacaoMedica { get; set; } = null;
        public string Motivo { get; set; } = null;
        public DateTime? DataPedidoAvaliacaoMedica { get; set; } = null;
        public string ParecerMedico { get; set; } = null;
        public string PacientePortadorDe { get; set; } = null;
        public string NecessitaDeCuidadosEspeciaisRelacao { get; set; } = null;
        public string Observacoes { get; set; } = null;
    }

    public class HabitoHigieneBucal
    {
        public string Escovacao { get; set; } = null;
        public string FioDental { get; set; } = null;
        public string EnxaguatorioBucal { get; set; } = null;
    }

    public class HistoriaFamiliar
    {
        public string Pai { get; set; } = null;
        public string Mae { get; set; } = null;
        public string Irmaos { get; set; } = null;
    }

    public class Habitos
    {
        public bool? Alcool { get; set; } = null;
        public string InicioAlcool { get; set; } = null;
        public string FrequenciaAlcool { get; set; } = null;
        public bool? Fumo { get; set; } = null;
        public string InicioFumo { get; set; } = null;
        public string FrequenciaFumo { get; set; } = null;
        public string OutrosHabitosNocivos { get; set; } = null;
    }

    public class TendenciasHereditarias
    {
        public bool? Cardiopatis { get; set; } = null;
        public bool? Hipertensao { get; set; } = null;
        public bool? Diabete { get; set; } = null;
        public bool? Asma { get; set; } = null;
        public bool? DisturbioSangramento { get; set; } = null;
        public bool? Alergias { get; set; } = null;
        public bool? NeoplasiasMalignas { get; set; } = null;
        public bool? DoencaNeurologicas { get; set; } = null;
        public bool? Tuberculose { get; set; } = null;
        public string Complemento { get; set; } = null;
        public string OutrasDoencas { get; set; } = null;
    }

    public class UsoMedicamentos
    {
        public bool? FazUsoDeMedicamentos { get; set; } = null;
        public string NomeComercial { get; set; } = null;
        public string NomeGenerico { get; set; } = null;
        public string Dosagem { get; set; } = null;
        public string FrequenciaUso { get; set; } = null;
    }

    public class HistoriaMedicaPregressaEAtual
    {
        public DoencaInfancia DoencaInfancia { get; set; } = null;
        public DistubiosCardiovasculares DistubiosCardiovasculares { get; set; } = null;
        public DistubiosRespiratorios DistubiosRespiratorios { get; set; } = null;
        public DistubiosEndocrinos DistubiosEndocrinos { get; set; } = null;
        public DisturbiosNeurologicos DisturbiosNeurologicos { get; set; } = null;
        public DisturbiosHematologicos DisturbiosHematologicos { get; set; } = null;
        public DisturbiosPsiquiatricos DisturbiosPsiquiatricos { get; set; } = null;
        public DisturbioosArticulacoesOuOssos DisturbioosArticulacoesOuOssos { get; set; } = null;
        public DisturbiosArticulacaoTemporamandibular DisturbiosArticulacaoTemporamandibular { get; set; } = null;
        public DoencaTransmissiveis DoencaTransmissiveis { get; set; } = null;
        public Alergias Alergias { get; set; } = null;
    }

    public class  DoencaInfancia
    {
        public bool? Catapora { get; set; } = null;
        public bool? Caxumba { get; set; } = null;
        public bool? Sarampo { get; set; } = null;
        public bool? Amigdalite { get; set; } = null;
        public string Outras { get; set; } = null;
    }

    public class DistubiosCardiovasculares
    {
        public bool? FebreReumatica { get; set; } = null;
        public bool? Sopros { get; set; } = null;
        public bool? PatologiasValvulas { get; set; } = null;
        public bool? AnomaliasCongenitasCardiacas { get; set; } = null;
        public bool? Hirpertensao { get; set; } = null;
        public bool? Arritmias { get; set; } = null;
        public bool? InfartoMiocardio { get; set; } = null;
        public bool? AngiaOuDorNoTorax { get; set; } = null;
        public bool? CirurgiasCardiacas { get; set; } = null;
        public bool? MarcaPasso { get; set; } = null;
        public bool? AVC { get; set; } = null;
        public string Outras { get; set; } = null;
    }

    public class DistubiosRespiratorios
    {
        public bool? Asma { get; set; } = null;
        public bool? DoencaPulmonares { get; set; } = null;
        public bool? Sinusite { get; set; } = null;
        public bool? Rinite { get; set; } = null;
        public string Outras { get; set; } = null;
    }

    public class DistubiosGenitourinarias
    {
        public bool? InfeccoesTratoUrinario { get; set; } = null;
        public bool? DoencasGionecologicas { get; set; } = null;
        public bool? DoencasRenais { get; set; } = null;
        public bool? Nefrite { get; set; } = null;
        public bool? InsuficienciaRenal { get; set; } = null;
        public bool? FazHemodialise { get; set; } = null;
        public string Quais { get; set; } = null;
        public string Outras { get; set; } = null;
    }

    public class DistubiosEndocrinos
    {
        public bool? Diabetes { get; set; } = null;
        public bool? DisfuncaoTireoide { get; set; } = null;
        public string Menarca { get; set; } = null;
        public string Menopausa { get; set; } = null;
        public string Gravidez { get; set; } = null;
        public int? Partos { get; set; } = null;
        public string Outras { get; set; } = null;
    }

    public class DisturbiosNeurologicos
    {
        public bool? Desmaios { get; set; } = null;
        public bool? Convulsoes { get; set; } = null;
        public bool? Enxaquecas { get; set; } = null;
        public bool? Cefaleias { get; set; } = null;
        public bool? NevralgiaNaFace { get; set; } = null;
        public string Outras { get; set; } = null;
    }

    public class DisturbiosHematologicos
    {
        public bool? Anemia { get; set; } = null;
        public bool? Hemorragia { get; set; } = null;
        public bool? Hemofilia { get; set; } = null;
        public bool? Leucemia { get; set; } = null;
        public string Outras { get; set; } = null;
        public bool? DoouOuRecebeuSangue { get; set; } = null;
        public DateTime? DataDoacaoSangue { get; set; } = null;
    }

    public class DisturbiosPsiquiatricos
    {
        public bool? TratamentoPsiquiatrico { get; set; } = null;
        public bool? Depressao { get; set; } = null;
        public bool? Ansiedade { get; set; } = null;
        public string Outras { get; set; } = null;
    }

    public class DisturbioosArticulacoesOuOssos
    {
        public bool? JaSofreuTraumatismoNaFace { get; set; } = null;
        public bool? Artrite { get; set; } = null;
        public bool? Reumatismo { get; set; } = null;
        public bool? Osteoporose { get; set; } = null;
        public string Outros { get; set; } = null;
    }

    public class DisturbiosArticulacaoTemporamandibular
    {
        public bool? BruxismoCentrico { get; set; } = null;
        public bool? BruxismoExcentrico { get; set; } = null;
        public bool? MastigacaoUnilateral { get; set; } = null;
        public bool? DorRegiaoDosOuvidos { get; set; } = null;
        public bool? EstalidoNaAberturaEFechamentoBucal { get; set; } = null;
        public string Outros { get; set; } = null;
    }


    public class DoencaTransmissiveis
    {
        public bool? Hepatite { get; set; } = null;
        public bool? Herpes { get; set; } = null;
        public bool? HIV { get; set; } = null;
        public bool? Turberculose { get; set; } = null;
        public bool? DoencaSexualmenteTransmissivel { get; set; } = null;
        public string Quais { get; set; } = null;
        public string Outras { get; set; } = null;
    }

    public class  Alergias
    {
        public bool? Anestesia { get; set; } = null;
        public bool? Alimentos { get; set; } = null;
        public bool? Cosmeticos { get; set; } = null;
        public bool? Urticaria { get; set; } = null;
        public string Quais { get; set; } = null;
        public bool? Medicamentos { get; set; } = null;
        public string QuaisMedicamentos { get; set; } = null;
        public string Outras { get; set; } = null;
    }
}