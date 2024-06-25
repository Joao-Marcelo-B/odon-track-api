using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("respostas_abertas")]
public class RespostasAbertas
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("id_prontuario")]
    public int IdProntuario { get; set; }

    [Column("id_pergunta")]
    public int IdPergunta { get; set; }

    [Column("resposta")]
    public string Resposta { get; set; }
}
