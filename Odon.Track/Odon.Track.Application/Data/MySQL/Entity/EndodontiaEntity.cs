using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Odon.Track.Application.Data.MySQL.Entity
{
    [Table("endodontia")]
    public class EndodontiaEntity
    {
        [Key, Column("id")] public int Id { get; set; }
        [Column("id_prontuario")] public int IdProntuario { get; set; }
        [Column("dente")] public string Dente { get; set; } = null;
        [Column("numero_de_canais")] public int? NumeroCanais { get; set; } = null;
        [Column("diagnostico_pulpar_normal")] public int? DiagnosticoPulparNormal { get; set; } = null;
        [Column("pulpite_reversivel")] public int? PulpiteReversivel { get; set; } = null;
        [Column("pulpite_irreversivel")] public int? PulpiteIrreversivel { get; set; } = null;
        [Column("necrose")] public int? Necrose { get; set; } = null;
        [Column("dente_ja_tratado")] public int? DenteJaTratado { get; set; } = null;
        [Column("insensivel")] public int? Insensivel { get; set; } = null;
        [Column("sensivel")] public int? Sensivel { get; set; } = null;
        [Column("muito_sensivel")] public int? MuitoSensivel { get; set; } = null;
        [Column("presenca_de_abcesso")] public int? PresencaDeAbcesso { get; set; } = null;
        [Column("intra_bucal")] public int? IntraBucal { get; set; } = null;
        [Column("extra_bucal")] public int? ExtraBucal { get; set; } = null;
        [Column("com_fistula")] public int? ComFistula { get; set; } = null;
        [Column("sem_fistula")] public int? SemFistula { get; set; } = null;
        [Column("regio_periapical_normal")] public int? RegioPeriapicalNormal { get; set; } = null;
        [Column("com_lesao")] public int? ComLesao { get; set; } = null;
        [Column("difusa")] public int? Difusa { get; set; } = null;
        [Column("circunscrita")] public int? Circunscrita { get; set; } = null;
        [Column("ausente")] public int? Ausente { get; set; } = null;
        [Column("claro")] public int? Claro { get; set; } = null;
        [Column("hemorragico")] public int? Hemorragico { get; set; } = null;
        [Column("purulento")] public int? Purulento { get; set; } = null;
        [Column("dor_entre_as_sessoes")] public int? DorEntreAsSessoes { get; set; } = null;
        [Column("hipoclorito_de_sodio_porcentagem")] public int? HipocloritoDeSodioPorcentagem { get; set; } = null;
        [Column("outras_solucao_irrigadora")] public string OutrasSolucaoIrrigadora { get; set; } = null;
        [Column("cimento_obturador")] public string CimentoObturador { get; set; } = null;
        [Column("condensacao_lateral")] public int? CondensacaoLateral { get; set; } = null;
        [Column("outra_tecnica_de_obturacao")] public string OutraTecnicaDeObturação { get; set; } = null;
        [Column("material_restaurador_provisorio")] public string MaterialRestauradorProvisorio { get; set; } = null;
        [Column("quantidade_de_sodio_a_porcentagem")] public string QuantidadeDeSodioAPorcentagem { get; set; } = null;
        [Column("inicio_tratamento")] public DateTime? InicioTratamento { get; set; } = null;
        [Column("termino_tratamento")] public DateTime? TerminoTratamento { get; set; } = null;
    }
}
