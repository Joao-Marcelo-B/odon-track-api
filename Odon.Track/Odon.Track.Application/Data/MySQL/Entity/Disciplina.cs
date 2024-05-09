using System;
using System.Collections.Generic;

namespace Odon.Track.Application.Data.MySQL.Entity;

public partial class Disciplina
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    //public virtual ICollection<Professor> IdProfessors { get; } = new List<Professor>();
}
