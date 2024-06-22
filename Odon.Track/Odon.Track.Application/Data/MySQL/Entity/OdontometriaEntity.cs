using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Odon.Track.Application.Data.MySQL.Entity
{
    [Table("odontometria")]
    public class OdontometriaEntity
    {
        [Key, Column("id")]
        public int Id { get; set; }
        [Column("id_prontuario")]
        public int IdProntuario { get; set; }
        [Column("tipo_odontometria")]
        public string TipoOdontometria { get; set; }
        [Column("index_da_coluna")]
        public int IndexDaColuna { get; set; }
        [Column("descricao")]
        public string Descricao { get; set; }
    }
}
