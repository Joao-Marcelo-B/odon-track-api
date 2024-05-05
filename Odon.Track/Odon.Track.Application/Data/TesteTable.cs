using System.ComponentModel.DataAnnotations.Schema;

namespace Odon.Track.Application.Data
{
    [Table("teste_table")]
    public class TesteTable
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("label_teste")]
        public string? LabelTeste { get; set; }
    }
}
