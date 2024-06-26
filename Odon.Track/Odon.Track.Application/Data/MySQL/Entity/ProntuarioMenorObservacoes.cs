using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Odon.Track.Application.Data.MySQL.Entity
{
    [Table("prontuario_menor_observacoes")]
    public class ProntuarioMenorObservacoes
    {
        [Key, Column("id")]
        public int Id { get; set; }
        [Column("id_prontuario")]
        public int IdProntuario { get; set; }
    }
}
