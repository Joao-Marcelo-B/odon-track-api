using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Odon.Track.Application.Data.MySQL.Entity
{
    [Table("prontuario_assinatura_usuario")]
    public class ProntuarioAssinaturaUsuario
    {
        [Key, Column("id")] 
        public int Id { get; set; }
        [Column("id_prontuario")]
        public int IdProntuario { get; set; }
        [Column("id_usuario")]
        public int IdUsuario { get; set; }
    }
}
