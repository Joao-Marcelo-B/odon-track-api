using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Odon.Track.Application.Data.MySQL.Entity;
[Table("estudante")]
public class Estudante
{
    [Key, Column("id")]
    public int Id { get; set; }

    [Column("id_usuario")]
    public int IdUsuario { get; set; }

    [Column("nome")]
    public string Nome { get; set; } = null!;
    [Column("periodo_atual")]
    public int PeriodoAtual { get; set; } = 1;

    [ForeignKey(nameof(IdUsuario))]
    public virtual Usuario Usuario { get; set; } = null!;
    public virtual ICollection<PacienteEstudante> PacienteEstudantes { get; } = new List<PacienteEstudante>();
    public virtual ICollection<ProntuarioPmEstudante> ProntuarioPmEstudantes { get; } = new List<ProntuarioPmEstudante>();
}
