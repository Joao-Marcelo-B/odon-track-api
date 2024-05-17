using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Odon.Track.Application.Data.MySQL.Entity;
[Table("disciplina")]
public partial class Disciplina
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Column("nome")]
    public string Nome { get; set; } = null!;

    public virtual ICollection<DisciplinasProfessor> DisciplinasProfessores { get; set; } = new List<DisciplinasProfessor>();
}
