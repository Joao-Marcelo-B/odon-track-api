using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Odon.Track.Application.Data.MySQL.Entity;

[Table("endereco")]
public partial class Endereco
{
    [Key, Column("id")]
    public int Id { get; set; }

    [Column("id_paciente")]
    public int IdPaciente { get; set; }

    [Column("numero_casa")]
    public string NumeroCasa { get; set; } = null!;
    [Column("logradouro")]
    public string Logradouro { get; set; } = null!;

    [Column("bairro")]
    public string Bairro { get; set; } = null!;

    [Column("cidade")]
    public string Cidade { get; set; } = null!;

    [Column("uf")]
    public string UF { get; set; } = null!;

    [Column("cep")]
    public string CEP { get; set; } = null!;

    [ForeignKey(nameof(IdPaciente))]
    public virtual Paciente IdPacienteNavigation { get; set; } = null!;
}