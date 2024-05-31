using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Odon.Track.Application.Data.MySQL.Entity;

[Table("usuario")]
public partial class Usuario
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Column("id_tipo_usuario")]
    public int IdTipoUsuario { get; set; }

    [Column("identificador_unifenas")]
    public string IdentificadorUnifenas { get; set; }

    [Column("email")]
    public string Email { get; set; } = null!;
    [Column("blocked")]
    public int Blocked { get; set; }
    [Column("login_failed")]
    public int LoginFailed { get; set; }
    [Column("password_hash")]
    public byte[] PasswordHash { get; set; } = null!;
    [Column("password_salt")]
    public byte[] PasswordSalt { get; set; }
    public virtual ICollection<Estudante> Estudantes { get; } = new List<Estudante>();
    [ForeignKey(nameof(IdTipoUsuario))]
    public virtual TipoUsuario TipoUsuario { get; set; } = null!;
    public virtual ICollection<Professor> Professors { get; } = new List<Professor>();
}
