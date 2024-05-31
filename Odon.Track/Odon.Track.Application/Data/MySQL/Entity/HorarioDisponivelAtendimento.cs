using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Odon.Track.Application.Data.MySQL.Entity
{
    [Table("horario_disponivel_atendimento")]
    public class HorarioDisponivelAtendimento
    {
        [Key, Column("id")]
        public int Id { get; set; }
        [Column("id_triagem")]
        public int IdTriagem { get; set; }
        [Column("sete_meia")]
        public int SeteMeia { get; set; }
        [Column("nove_meia")]
        public int NoveMeia { get; set; }
        [Column("uma_meia")]
        public int UmaMeia { get; set; }
        [Column("tres_meia")]
        public int TresMeia { get; set; }
    }
}
