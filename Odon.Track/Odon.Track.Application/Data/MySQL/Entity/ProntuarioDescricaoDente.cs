using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Odon.Track.Application.Data.MySQL.Entity
{
    [Table("prontuario_descricao_dente")]
    public class ProntuarioDescricaoDente
    {
        [Key, Column("id")]
        public int Id { get; set; }
        [Column("id_prontuario")]
        public int IdProntuario { get; set; }
        [Column("numero_dente")]
        public string NumeroDente { get; set; }
        [Column("descricao_dente")]
        public string DescricaoDente { get; set; }
    }
}
