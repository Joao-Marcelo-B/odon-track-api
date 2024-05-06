using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Odon.Track.Application.Data.MySQL.Entity;

public partial class Estudante
{
    [Key, Column("id")]
    public int Id { get; set; }

    [Column("id_usuario")]
    public int IdUsuario { get; set; }

    [Column("nome")]
    public string Nome { get; set; } = null!;

    //[IgnoreDataMember]
    //public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
    //[IgnoreDataMember]
    //public virtual ICollection<PacienteEstudante> PacienteEstudantes { get; } = new List<PacienteEstudante>();
    //[IgnoreDataMember]
    //public virtual ICollection<ProntuarioPmEstudante> ProntuarioPmEstudantes { get; } = new List<ProntuarioPmEstudante>();
}
