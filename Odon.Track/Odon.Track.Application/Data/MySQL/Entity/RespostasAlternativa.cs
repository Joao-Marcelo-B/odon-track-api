using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("respostas_alternativa")]
public class RespostasAlternativa
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("id_prontuario")]
    public int IdProntuario { get; set; }

    [Column("id_pergunta")]
    public int IdPergunta { get; set; }

    [Column("id_alternativa")]
    public int IdAlternativa { get; set; }

    [Column("checked")]
    public bool Checked { get; set; }
}
