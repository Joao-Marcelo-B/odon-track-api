using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Odon.Track.Application.Data.MySQL.Entity
{
    [Table("roles_modulo")] 
    public class RolesModulo
    {
        [Key, Column("id")]
        public int Id { get; set; }
        [Column("id_role")]
        public int IdRole { get; set; }
        [Column("modulo")]
        public int Modulo { get; set; }
    }
}
