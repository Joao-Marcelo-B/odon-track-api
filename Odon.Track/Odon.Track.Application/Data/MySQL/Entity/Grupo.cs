using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("grupo")]
public class Grupo
{
    
    [Key, Column("id")]
    public int Id { get; set; }

    [Column("nome")]
    public string Nome { get; set; }
}
