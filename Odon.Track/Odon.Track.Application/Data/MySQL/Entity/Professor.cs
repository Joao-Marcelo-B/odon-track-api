using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Odon.Track.Application.Data.MySQL.Entity;

[Table("professor")]
public partial class Professor
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
    //public virtual ICollection<ProntuarioProntoAtendimento> ProntuarioProntoAtendimentos { get; } = new List<ProntuarioProntoAtendimento>();
    //[IgnoreDataMember]
    //public virtual ICollection<Prontuario> Prontuarios { get; } = new List<Prontuario>();
    //[IgnoreDataMember]
    //public virtual ICollection<Triagem> Triagems { get; } = new List<Triagem>();
    //[IgnoreDataMember]
    //public virtual ICollection<Disciplina> IdDisciplinas { get; } = new List<Disciplina>();
}
