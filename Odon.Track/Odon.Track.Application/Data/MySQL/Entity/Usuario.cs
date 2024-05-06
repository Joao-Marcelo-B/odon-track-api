using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

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

    [Column("password_hash")]
    public byte[] PasswordHash { get; set; } = null!;
    [Column("password_salt")]
    public byte[] PasswordSalt { get; set; }
    //[IgnoreDataMember]
    //public virtual ICollection<Estudante> Estudantes { get; } = new List<Estudante>();
    //[IgnoreDataMember]
    //public virtual TipoUsuario IdTipoUsuarioNavigation { get; set; } = null!;
    //[IgnoreDataMember]
    //public virtual ICollection<Professor> Professors { get; } = new List<Professor>();
}
