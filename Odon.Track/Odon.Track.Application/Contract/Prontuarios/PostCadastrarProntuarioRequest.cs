namespace Odon.Track.Application.Contract.Prontuarios
{
    public class PostCadastrarProntuarioRequest
    {
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