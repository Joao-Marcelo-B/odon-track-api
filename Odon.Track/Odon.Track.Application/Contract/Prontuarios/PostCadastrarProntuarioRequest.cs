using Microsoft.AspNetCore.Http;
using System.Text.Json.Serialization;

namespace Odon.Track.Application.Contract.Prontuarios;

public class PostCadastrarProntuarioRequest
{
    public PostCadastrarProntuarioRequest()
    {
        HistoriaMedicaPregressaEAtual = new();
        UsoMedicamentos = new();
        HistoriaFamiliar = new();
        TendenciasHereditarias = new();
        Habitos = new();
        HabitoHigieneBucal = new();
        DescricaoDente = new();
        DiagnosticosDente = new();
        ExameFisico = new();
        Endodontia = new();
        Curativos = new();
    }

    [JsonIgnore]
    public int? IdProntuario { get; set; } = null;
    public int? IdPaciente { get; set; } = null;
    public string Status { get; set; } = null;
    public string QueixaPrincipal { get; set; } = null;
    public string HistoriaDoencaAtual { get; set; } = null;
    public string RestauracaoDefinitivaDoDente { get; set; } = null;
    public int? NumeroDeSessoesRealizadas { get; set; } = null;
    public string PlanoCronologicoTratamento { get; set; } = null;
    public HistoriaMedicaPregressaEAtual HistoriaMedicaPregressaEAtual { get; set; } = null;
    public UsoMedicamentos UsoMedicamentos { get; set; } = null;
    public HistoriaFamiliar HistoriaFamiliar { get; set; } = null;
    public TendenciasHereditarias TendenciasHereditarias { get; set; } = null;
    public Habitos Habitos { get; set; } = null;
    public HabitoHigieneBucal HabitoHigieneBucal { get; set; } = null;
    public DescricaoDente DescricaoDente { get; set; } = null;
    public DiagnosticosDente DiagnosticosDente { get; set; } = null;
    public ExameFisico ExameFisico { get; set; } = null;
    public List<Endodontia> Endodontia { get; set; } = null;
    public Curativos Curativos { get; set; } = null;

}

public class Curativos
{
    public string PrimeiraSessao { get; set; } = null;
    public string SegundaSessao { get; set; } = null;
    public string TerceiraSessao { get; set; } = null;
    public string QuartaSessao { get; set; } = null;
    public string QuintaSessao { get; set; } = null;
    public string SextaSessao { get; set; } = null;
}


public class Odontometria
{
    public int Id { get; set; }
    public string Canal { get; set; } = null;
    public string CAD { get; set; } = null;
    public string CRD { get; set; } = null;
    public string CRT { get; set; } = null;
    public string DiametroAnatomico { get; set; } = null;
    public string DiametroCirurgico { get; set; } = null;
    public string PontoDeReferenciaPontoDeReferencia { get; set; } = null;
}

public enum ETipoOdontometria
{
    Canal,
    CAD,
    CRD,
    CRT,
    DiametroAnatomico,
    DiametroCirurgico,
    PontoDeReferenciaPontoDeReferencia
}

public class Endodontia
{
    public int? Id { get; set; } = null;
    public string Dente { get; set; } = null;
    public int? NumeroDeCanais { get; set; } = null;
    public ExameClinico ExameClinico { get; set; } = new();
    public List<Odontometria> Odontometria { get; set; } = new();
    public  List<Retorno> Retornos { get; set; } = new();
}

public class Retorno
{
    public int? Id { get; set; } = null;
    public DateTime? DataRetorno { get; set; } = null;
}

public class  ExameClinico
{
    public string MaterialRestauradorProvisorio { get; set; } = null;
    public bool? DorEntreAsSessoes { get; set; } = null;
    public string CimentoObturador { get; set; } = null;
    public DiagnosticoPulpar DiagnosticoPulpar { get; set; } = new();
    public TesteDePercussao TesteDePercussao { get; set; } = new();
    public PresencaDeAbcesso PresencaDeAbcesso { get; set; } = new();
    public ExameRadiografico ExameRadiografico { get; set; } = new();
    public ExsudatoNosCanais ExsudatoNosCanais { get; set; } = new();
    public SolucaoIrrigadora SolucaoIrrigadora { get; set; } = new();
    public TecnicaDeObturacao TecnicaDeObturacao { get; set; } = new();
   
}

public class TecnicaDeObturacao
{
    public bool? CondensacaoLateral { get; set; } = null;
    public string Outra { get; set; } = null;
}

public class SolucaoIrrigadora
{
    public bool? HipocloritoDeSodioAPorcentagem { get; set; } = null;
    public string QuantidadeDeSodioAPorcentagem { get; set; } = null;
    public string Outra { get; set; } = null;
}

public class ExsudatoNosCanais
{
    public bool? Ausente { get; set; } = null;
    public bool? Claro { get; set; } = null;
    public bool? Hemorragico { get; set; } = null;
    public bool? Purulento { get; set; } = null;
}

public class ExameRadiografico
{
    public ExameRadiografico()
    {
        RegiaoPeriapical = new();
    }
    public RegiaoPeriapical RegiaoPeriapical { get; set; } = null;
}

public class RegiaoPeriapical
{
    public bool? Normal { get; set; } = null;
    public bool? ComLesao { get; set; } = null;
    public bool? Difusa { get; set; } = null;
    public bool? Circunscrita { get; set; } = null;
}

public class PresencaDeAbcesso
{
    public bool? Presente { get; set; } = null;
    public bool? IntraBucal { get; set; } = null;
    public bool? Extrabucal { get; set; } = null;
    public bool? ComFistula { get; set; } = null;
    public bool? SemFistula { get; set; } = null;
}

public class DiagnosticoPulpar
{
    public bool? Normal { get; set; } = null;
    public bool? PulpiteReversivel { get; set; } = null;
    public bool? PulpiteIrreversivel { get; set; } = null;
    public bool? Necrose { get; set; } = null;
    public bool? DenteJaTratado { get; set; } = null;
}

public class TesteDePercussao
{
    public bool? Insesivel { get; set; } = null;
    public bool? Sensivel { get; set; } = null;
    public bool? MuitoSensivel { get; set; } = null;
}

public class DiagnosticosDente
{
    public DiagnosticosDente()
    {
        Gengivite = new Dentes();
        PeriodontiteLeve = new Dentes();
        PeriodontiteGrave = new Dentes();
        EComplicada = new Dentes();
    }
    public Dentes Gengivite { get; set; }
    public Dentes PeriodontiteLeve { get; set; }
    public Dentes PeriodontiteGrave { get; set; }
    public Dentes EComplicada { get; set; }
    public string Observacoes { get; set; }
}

public enum ETipoDiagnostico
{
    Gengivite,
    PeriodontiteLeve,
    PeriodontiteGrave,
    EComplicada
}

public class Dentes
{
    public bool _18 { get; set; }
    public bool _17 { get; set; }
    public bool _16 { get; set; }
    public bool _15 { get; set; }
    public bool _14 { get; set; }
    public bool _13 { get; set; }
    public bool _12 { get; set; }
    public bool _11 { get; set; }
    public bool _21 { get; set; }
    public bool _22 { get; set; }
    public bool _23 { get; set; }
    public bool _24 { get; set; }
    public bool _25 { get; set; }
    public bool _26 { get; set; }
    public bool _27 { get; set; }
    public bool _28 { get; set; }
    public bool _48 { get; set; }
    public bool _47 { get; set; }
    public bool _46 { get; set; }
    public bool _45 { get; set; }
    public bool _44 { get; set; }
    public bool _43 { get; set; }
    public bool _42 { get; set; }
    public bool _41 { get; set; }
    public bool _31 { get; set; }
    public bool _32 { get; set; }
    public bool _33 { get; set; }
    public bool _34 { get; set; }
    public bool _35 { get; set; }
    public bool _36 { get; set; }
    public bool _37 { get; set; }
    public bool _38 { get; set; }
}

public class DescricaoDente
{
    public string _18 { get; set; } = null;
    public string _17 { get; set; } = null;
    public string _16 { get; set; } = null;
    public string _15_55 { get; set; } = null;
    public string _14_54 { get; set; } = null;
    public string _13_53 { get; set; } = null;
    public string _12_52 { get; set; } = null;
    public string _11_51 { get; set; } = null;
    public string _21_61 { get; set; } = null;
    public string _22_62 { get; set; } = null;
    public string _23_63 { get; set; } = null;
    public string _24_64 { get; set; } = null;
    public string _25_65 { get; set; } = null;
    public string _26 { get; set; } = null;
    public string _27 { get; set; } = null;
    public string _28 { get; set; } = null;
    public string _38 { get; set; } = null;
    public string _37 { get; set; } = null;
    public string _36 { get; set; } = null;
    public string _35_75 { get; set; } = null;
    public string _34_74 { get; set; } = null;
    public string _33_73 { get; set; } = null;
    public string _32_72 { get; set; } = null;
    public string _31_71 { get; set; } = null;
    public string _41_81 { get; set; } = null;
    public string _42_82 { get; set; } = null;
    public string _43_83 { get; set; } = null;
    public string _44_84 { get; set; } = null;
    public string _45_85 { get; set; } = null;
    public string _46 { get; set; } = null;
    public string _47 { get; set; } = null;
    public string _48 { get; set; } = null;
    public string Observacoes { get; set; } = null;
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
    public string FrequenciaAlcool { get; set; } = null;
    public bool? Fumo { get; set; } = null;
    public string FrequenciaFumo { get; set; } = null;
    public string OutrosHabitosNocivos { get; set; } = null;
}

public class TendenciasHereditarias
{
    public bool? Cardiopatias { get; set; } = null;
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
    public string VisitasMedicas { get; set; } = null;
    public string Hospitalizacoes { get; set; } = null;
    public string Observacoes { get; set; } = null;
    public string DadosRelevantesHistoriaMedica { get; set; } = null;
}

public class HistoriaMedicaPregressaEAtual
{
    public HistoriaMedicaPregressaEAtual()
    {
        DoencaInfancia = new();
        DistubiosCardiovasculares = new();
        DistubiosGenitourinarias = new();
        DisturbiosGastrointestinais = new();
        DistubiosRespiratorios = new();
        DistubiosEndocrinos = new();
        DisturbiosNeurologicos = new();
        DisturbiosHematologicos = new();
        DisturbiosPsiquiatricos = new();
        DisturbiosArticulacoesOuOssos = new();
        DisturbiosArticulacaoTemporamandibular = new();
        DoencaTransmissiveis = new();
        Alergias = new();
    }
    public DoencaInfancia DoencaInfancia { get; set; } = null;
    public DistubiosCardiovasculares DistubiosCardiovasculares { get; set; } = null;
    public DistubiosGenitourinarias DistubiosGenitourinarias { get; set; } = null;
    public DisturbiosGastrointestinais DisturbiosGastrointestinais { get; set; } = null;
    public DistubiosRespiratorios DistubiosRespiratorios { get; set; } = null;
    public DistubiosEndocrinos DistubiosEndocrinos { get; set; } = null;
    public DisturbiosNeurologicos DisturbiosNeurologicos { get; set; } = null;
    public DisturbiosHematologicos DisturbiosHematologicos { get; set; } = null;
    public DisturbiosPsiquiatricos DisturbiosPsiquiatricos { get; set; } = null;
    public DisturbiosArticulacoesOuOssos DisturbiosArticulacoesOuOssos { get; set; } = null;
    public DisturbiosArticulacaoTemporamandibular DisturbiosArticulacaoTemporamandibular { get; set; } = null;
    public DoencaTransmissiveis DoencaTransmissiveis { get; set; } = null;
    public Alergias Alergias { get; set; } = null;
}

public class DisturbiosGastrointestinais
{
    public bool? Gastrite { get; set; } = null;
    public bool? Ulceras { get; set; } = null;
    public bool? Cirrose { get; set; } = null;
    public string Outras { get; set; } = null;

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
    public DistubiosGenitourinarias()
    {
        DoencasRenais = new();
    }
    public bool? InfeccoesTratoUrinario { get; set; } = null;
    public bool? DoencasGionecologicas { get; set; } = null;
    public DoencasRenais DoencasRenais { get; set; } = null;
    public string Outras { get; set; } = null;
}

public class DoencasRenais
{
    public bool? Nefrite { get; set; } = null;
    public bool? InsuficienciaRenal { get; set; } = null;
    public bool? FazHemodialise { get; set; } = null;
    public string Quais { get; set; } = null;
}

public class DistubiosEndocrinos
{
    public bool? Diabetes { get; set; } = null;
    public bool? DisfuncaoTireoide { get; set; } = null;
    public int? Menarca { get; set; } = null;
    public int? Menopausa { get; set; } = null;
    public int? Gravidez { get; set; } = null;
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

public class DisturbiosArticulacoesOuOssos
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
    public bool? Tuberculose { get; set; } = null;
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
