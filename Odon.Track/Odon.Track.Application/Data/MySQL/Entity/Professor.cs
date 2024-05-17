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

    [ForeignKey(nameof(IdUsuario))]
    public virtual Usuario Usuario { get; set; } = null!;

    //public virtual ICollection<ProntuarioProntoAtendimento> ProntuarioProntoAtendimentos { get; } = new List<ProntuarioProntoAtendimento>();

    //public virtual ICollection<Prontuario> Prontuarios { get; } = new List<Prontuario>();

    //public virtual ICollection<Triagem> Triagems { get; } = new List<Triagem>();

    public virtual ICollection<DisciplinasProfessor> DisciplinasProfessores { get; set; } = new List<DisciplinasProfessor>();
}
