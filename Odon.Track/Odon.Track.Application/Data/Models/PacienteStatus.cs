using System;
using System.Collections.Generic;

namespace WebApplication1;

public partial class PacienteStatus
{
    public int Id { get; set; }

    public string? Descricao { get; set; }

    public virtual ICollection<Paciente> Pacientes { get; } = new List<Paciente>();
}
