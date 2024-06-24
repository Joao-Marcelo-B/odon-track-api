using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Odon.Track.Application.Data.MySQL.Entity
{
    [Table("retorno")]
    public class RetornoEntity
    {
        [Key, Column("id")]
        public int Id { get; set; }
        [Column("id_endodontia")]
        public int IdEndodontia { get; set; }
        [Column("data_retorno")]
        public DateTime? DataRetorno { get; set; } = null;
    }
}
