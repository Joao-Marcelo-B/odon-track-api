using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("perguntas")]
public class Perguntas
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("id_grupo")]
    public int IdGrupo { get; set; }

    [Column("tipo_pergunta")]
    public string TipoPergunta { get; set; }

    [Column("pergunta")]
    public string Pergunta { get; set; }
}
    