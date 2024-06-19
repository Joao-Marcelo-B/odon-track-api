using Microsoft.AspNetCore.Http;

namespace Odon.Track.Application.Contract.Prontuarios
{
    public class PostCadastrarProntuarioRequest
    {
        public int IdPaciente { get; set; }
        public string QueixaPrincipal { get; set; }
        public string HistoriaDoencaAtual { get; set; }
        public HistoriaMedicaPregressaEAtual HistoriaMedicaPregressaEAtual { get; set; }
        public UsoMedicamentos UsoMedicamentos { get; set; }
        public string VisistasMedicas { get; set; }
        public string Hospitalizacoes { get; set; }
        public string Observacoes { get; set; }
        public string DadosRelevantesHistoriaMedica { get; set; }
        public HistoriaFamiliar HistoriaFamiliar { get; set; }
        public TendenciasHereditarias TendenciasHereditarias { get; set; }
        public Habitos Habitos { get; set; }
        public HabitoHigieneBucal HabitoHigieneBucal { get; set; }
        public DescricaoDente DescricaoDente { get; set; }
        public DiagnosticosDente DiagnosticosDente { get; set; }
        public string PlanoCronologicoTratamento { get; set; }
        public Endodontia Endodontia { get; set; }
        public Odontometria Odontometria { get; set; }
        public Curativos Curativos { get; set; }
        public string RestauracaoDefinitivaDoDente { get; set; }
        public int NumeroDeSessoesRealizadas { get; set; }
    }

    public class Curativos
    {
        public string PrimeiraSessao { get; set; }
        public string SegundaSessao { get; set; }
        public string TerceiraSessao { get; set; }
        public string QuartaSessao { get; set; }
        public string QuintaSessao { get; set; }
        public string SextaSessao { get; set; }
        public string Observacoes { get; set; }
    }

    public class Odontometria
    {
        public Canal Canal { get; set; }
        public CAD CAD { get; set; }
        public CRD CRD { get; set; }
        public CRT CRT { get; set; }
        public DiametroAnatomico DiametroAnatomico { get; set; }
        public DiametroCirurgico DiametroCirurgico { get; set; }
        public PontoDeReferenciaPontoDeReferencia PontoDeReferenciaPontoDeReferencia { get; set; }
    }

    public class PontoDeReferenciaPontoDeReferencia
    {
        public List<string> Descricao { get; set; }
    }

    public class DiametroCirurgico
    {
        public List<string> Descricao { get; set; }
    }

    public class DiametroAnatomico
    {
        public List<string> Descricao { get; set; }
    }

    public class CRT
    {
        public List<string> Descricao { get; set; }
    }

    public class CRD
    {
        public List<string> Descricao { get; set; }
    }

    public class Canal
    {
        public List<string> Descricao { get; set; }
    }

    public class CAD
    {
        public List<string> Descricao { get; set; }
    }

    public class Endodontia
    {
        public string Dente { get; set; }
        public int NumeroDeCanais { get; set; }
        public ExameClinico ExameClinico { get; set; }
    }

    public class  ExameClinico
    {
        public DiagnosticoPulpar DiagnosticoPulpar { get; set; }
        public TesteDePercussao TesteDePercussao { get; set; }
        public PresencaDeAbcesso PresencaDeAbcesso { get; set; }
        public ExameRadiografico ExameRadiografico { get; set; }
        public ExsudatoNosCanais ExsudatoNosCanais { get; set; }
        public DorEntreAsSessoes DorEntreAsSessoes { get; set; }
        public SolucaoIrrigadora SolucaoIrrigadora { get; set; }
        public string CimentoObturador { get; set; }
        public TecnicaDeObturacao TecnicaDeObturacao { get; set; }
        public string MaterialRestauradorProvisorio{ get; set; }
    }

    public class TecnicaDeObturacao
    {
        public bool CondensacaoLateral { get; set; }
        public string Outra { get; set; }
    }

    public class SolucaoIrrigadora
    {
        public bool HipocloritoDeSodioAPorcentagem { get; set; }
        public string Outra { get; set; }
    }

    public class DorEntreAsSessoes
    {
        public bool Sim { get; set; }
        public bool Nao { get; set; }
    }

    public class ExsudatoNosCanais
    {
        public bool Ausente { get; set; }
        public bool Claro { get; set; }
        public bool Hemorragico { get; set; }
        public bool Purulento { get; set; }
    }

    public class ExameRadiografico
    {
        public RegiaoPeriapical RegiaoPeriapical { get; set; }
    }

    public class RegiaoPeriapical
    {
        public bool Normal { get; set; }
        public bool ComLesao { get; set; }
        public bool Difusa { get; set; }
        public bool Circunscrita { get; set; }
    }

    public class PresencaDeAbcesso
    {
        public bool Nao { get; set; }
        public bool Sim { get; set; }
        public bool IntraBucal { get; set; }
        public bool Extrabucal { get; set; }
        public bool ComFistula { get; set; }
        public bool SemFistula { get; set; }
    }

    public class DiagnosticoPulpar
    {
        public bool Normal { get; set; }
        public bool PulpiteReversivel { get; set; }
        public bool PulpiteIrreversivel { get; set; }
        public bool Necrose { get; set; }
        public bool DenteJaTratado { get; set; }
    }

    public class TesteDePercussao
    {
        public bool Insesivel { get; set; }
        public bool Sensivel { get; set; }
        public bool MuitoSensivel { get; set; }
    }

    public class ControlePlacaBacteriana
    {
        public IFormFile ImagemControlePlacaBacteriana { get; set; }
        public string Observacao { get; set; }
    }

    public class DiagnosticosDente
    {
        public Gengivite Gengivite { get; set; }
        public PeriodontiteLeve PeriodontiteLeve { get; set; }
        public PeriodontiteGrave PeriodontiteGrave { get; set; }
        public EComplicada EComplicada { get; set; }
        public string Observacoes { get; set; }
    }

    public class Gengivite
    {
        public List<Dentes> Dentes { get; set; }
    }

    public class PeriodontiteLeve
    {
        public List<Dentes> Dentes { get; set; }
    }

    public class EComplicada
    {
        public List<Dentes> Dentes { get; set; }
    }

    public class PeriodontiteGrave
    {
        public List<Dentes> Dentes { get; set; }
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
        public string _18 { get; set; }
        public string _17 { get; set; }
        public string _16 { get; set; }
        public string _15_55 { get; set; }
        public string _14_54 { get; set; }
        public string _13_53 { get; set; }
        public string _12_52 { get; set; }
        public string _11_51 { get; set; }
        public string _21_61 { get; set; }
        public string _22_62 { get; set; }
        public string _23_63 { get; set; }
        public string _24_64 { get; set; }
        public string _25_65 { get; set; }
        public string _26 { get; set; }
        public string _27 { get; set; }
        public string _28 { get; set; }
        public string _38 { get; set; }
        public string _37 { get; set; }
        public string _36 { get; set; }
        public string _35_75 { get; set; }
        public string _34_74 { get; set; }
        public string _33_73 { get; set; }
        public string _32_72 { get; set; }
        public string _31_71 { get; set; }
        public string _41_81 { get; set; }
        public string _42_82 { get; set; }
        public string _43_83 { get; set; }
        public string _44_84 { get; set; }
        public string _45_85 { get; set; }
        public string _46 { get; set; }
        public string _47 { get; set; }
        public string _48 { get; set; }
        public string Observacoes { get; set; }
    }

    public class  ExameFisico
    {
        public string PressaoArterial { get; set; }
        public string FrequenciaRespiratoria { get; set; }
        public string Pulso { get; set; }
        public string TemperaturaAxiliar { get; set; }
        public string Ectoscopia { get; set; }
        public string Oroscopia { get; set; }
        public string ExamesComplementaresSolicitados { get; set; }
        public bool PedidoAvaliacaoMedica { get; set; }
        public string Motivo { get; set; }
        public DateTime DataPedidoAvaliacaoMedica { get; set; }
        public string ParecerMedico { get; set; }
        public string PacientePortadorDe { get; set; }
        public string NecessitaDeCuidadosEspeciaisRelacao { get; set; }
        public string Observacoes { get; set; }
    }

    public class HabitoHigieneBucal
    {
        public string Escovacao { get; set; }
        public string FioDental { get; set; }
        public string EnxaguatorioBucal { get; set; }
    }

    public class HistoriaFamiliar
    {
        public string Pai { get; set; }
        public string Mae { get; set; }
        public string Irmaos { get; set; }
    }

    public class Habitos
    {
        public bool Alcool { get; set; }
        public string InicioAlcool { get; set; }
        public string FrequenciaAlcool { get; set; }
        public bool Fumo { get; set; }
        public string InicioFumo { get; set; }
        public string FrequenciaFumo { get; set; }
        public string OutrosHabitosNocivos { get; set; }
    }

    public class TendenciasHereditarias
    {
        public bool Cardiopatis { get; set; }
        public bool Hipertensao { get; set; }
        public bool Diabete { get; set; }
        public bool Asma { get; set; }
        public bool DisturbioSangramento { get; set; }
        public bool Alergias { get; set; }
        public bool NeoplasiasMalignas { get; set; }
        public bool DoencaNeurologicas { get; set; }
        public bool Tuberculose { get; set; }
        public string Complemento { get; set; }
        public string OutrasDoencas { get; set; }
    }

    public class UsoMedicamentos
    {
        public bool FazUsoDeMedicamentos { get; set; }
        public string NomeComercial { get; set; }
        public string NomeGenerico { get; set; }
        public string Dosagem { get; set; }
        public string FrequenciaUso { get; set; }
    }

    public class HistoriaMedicaPregressaEAtual
    {
        public DoencaInfancia DoencaInfancia { get; set; }
        public DistubiosCardiovasculares DistubiosCardiovasculares { get; set; }
        public DistubiosRespiratorios DistubiosRespiratorios { get; set; }
        public DistubiosEndocrinos DistubiosEndocrinos { get; set; }
        public DisturbiosNeurologicos DisturbiosNeurologicos { get; set; }
        public DisturbiosHematologicos DisturbiosHematologicos { get; set; }
        public DisturbiosPsiquiatricos DisturbiosPsiquiatricos { get; set; }
        public DisturbioosArticulacoesOuOssos DisturbioosArticulacoesOuOssos { get; set; }
        public DisturbiosArticulacaoTemporamandibular DisturbiosArticulacaoTemporamandibular { get; set; }
        public DoencaTransmissiveis DoencaTransmissiveis { get; set; }
        public Alergias Alergias { get; set; }
    }

    public class  DoencaInfancia
    {
        public bool Catapora { get; set; }
        public bool Caxumba { get; set; }
        public bool Sarampo { get; set; }
        public bool Amigdalite { get; set; }
        public string Outras { get; set; }
    }

    public class DistubiosCardiovasculares
    {
        public bool FebreReumatica { get; set; }
        public bool Sopros { get; set; }
        public bool PatologiasValvulas { get; set; }
        public bool AnomaliasCongenitasCardiacas { get; set; }
        public bool Hirpertensao { get; set; }
        public bool Arritmias { get; set; }
        public bool InfartoMiocardio { get; set; }
        public bool AngiaOuDorNoTorax { get; set; }
        public bool CirurgiasCardiacas { get; set; }
        public bool MarcaPasso { get; set; }
        public bool AVC { get; set; }
        public string Outras { get; set; }
    }

    public class DistubiosRespiratorios
    {
        public bool Asma { get; set; }
        public bool DoencaPulmonares { get; set; }
        public bool Sinusite { get; set; }
        public bool Rinite { get; set; }
        public string Outras { get; set; }
    }

    public class DistubiosGenitourinarias
    {
        public bool InfeccoesTratoUrinario { get; set; }
        public bool DoencasGionecologicas { get; set; }
        public bool DoencasRenais { get; set; }
        public bool Nefrite { get; set; }
        public bool InsuficienciaRenal { get; set; }
        public bool FazHemodialise { get; set; }
        public string Quais { get; set; }
        public string Outras { get; set; }
    }

    public class DistubiosEndocrinos
    {
        public bool Diabetes { get; set; }
        public bool DisfuncaoTireoide { get; set; }
        public string Menarca { get; set; }
        public string Menopausa { get; set; }
        public string Gravidez { get; set; }
        public int Partos { get; set; }
        public string Outras { get; set; }
    }

    public class DisturbiosNeurologicos
    {
        public bool Desmaios { get; set; }
        public bool Convulsoes { get; set; }
        public bool Enxaquecas { get; set; }
        public bool Cefaleias { get; set; }
        public bool NevralgiaNaFace { get; set; }
        public string Outras { get; set; }
    }

    public class DisturbiosHematologicos
    {
        public bool Anemia { get; set; }
        public bool Hemorragia { get; set; }
        public bool Hemofilia { get; set; }
        public bool Leucemia { get; set; }
        public string Outras { get; set; }
        public bool DoouOuRecebeuSangue { get; set; }
        public DateTime DataDoacaoSangue { get; set; }
    }

    public class DisturbiosPsiquiatricos
    {
        public bool TratamentoPsiquiatrico { get; set; }
        public bool Depressao { get; set; }
        public bool Ansiedade { get; set; }
        public string Outras { get; set; }
    }

    public class DisturbioosArticulacoesOuOssos
    {
        public bool JaSofreuTraumatismoNaFace { get; set; }
        public bool Artrite { get; set; }
        public bool Reumatismo { get; set; }
        public bool Osteoporose { get; set; }
        public string Outros { get; set; }
    }

    public class DisturbiosArticulacaoTemporamandibular
    {
        public bool BruxismoCentrico { get; set; }
        public bool BruxismoExcentrico { get; set; }
        public bool MastigacaoUnilateral { get; set; }
        public bool DorRegiaoDosOuvidos { get; set; }
        public bool EstalidoNaAberturaEFechamentoBucal { get; set; }
        public string Outros { get; set; }
    }


    public class DoencaTransmissiveis
    {
        public bool Hepatite { get; set; }
        public bool Herpes { get; set; }
        public bool HIV { get; set; }
        public bool Turberculose { get; set; }
        public bool DoencaSexualmenteTransmissivel { get; set; }
        public string Quais { get; set; }
        public string Outras { get; set; }
    }

    public class  Alergias
    {
        public bool Anestesia { get; set; }
        public bool Alimentos { get; set; }
        public bool Cosmeticos { get; set; }
        public bool Urticaria { get; set; }
        public string Quais { get; set; }
        public bool Medicamentos { get; set; }
        public string QuaisMedicamentos { get; set; }
        public string Outras { get; set; }
    }
}