using System;
using System.Collections.Generic;

namespace Odon.Track.Application.Data.MySQL.Entity;

public partial class PacienteStatus
{
    public int Id { get; set; }

    public string? Descricao { get; set; }

    public virtual ICollection<Paciente> Pacientes { get; } = new List<Paciente>();
}
