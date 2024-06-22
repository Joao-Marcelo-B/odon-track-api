using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Odon.Track.Application.Data.MySQL.Entity
{
    [Table("prontuario_diagnostico_dentes")]
    public class ProntuarioDiagnosticosDente
    {
        [Key, Column("id")]
        public int Id { get; set; }
        [Column("id_prontuario")]
        public int IdProntuario { get; set; }
        [Column("tipo_diagnostico")]
        public string TipoDiagnostico { get; set; }
        [Column("dentes")]
        public string Dentes { get; set; }
    }
}
