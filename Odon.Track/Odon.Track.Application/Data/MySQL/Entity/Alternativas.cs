using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("alternativas")]
public class Alternativas
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("id_pergunta")]
    public int IdPergunta { get; set; }

    [Column("alternativa")]
    public string Alternativa { get; set; }

}
