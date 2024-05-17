using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Odon.Track.Application.Data.MySQL.Entity
{
    [Table("roles")]
    public class Roles
    {
        [Key, Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("descricao")]
        public string Descricao { get; set; }
        public ICollection<RolesSemestre> RolesSemestre { get; set; }
    }
}
