using System.ComponentModel.DataAnnotations.Schema;

namespace Odon.Track.Application.Data.MySQL.Entity;

[Table("necessidade_tratamento")]
public class NecessidadeTratamento
{
    [Column("id")]
    public int Id { get; set; }


    [Column("id_triagem")]
    public int IdTriagem { get; set; }

    [Column("tratamento")]
    public string Tratamento { get; set; }

    [Column("descricao")]
    public string Descricao { get; set; }

    [ForeignKey(nameof(IdTriagem))]
    public Triagem Triagem { get; set; } = null!;
}
