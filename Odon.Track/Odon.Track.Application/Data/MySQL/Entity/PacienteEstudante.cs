using System;
using System.Collections.Generic;

namespace Odon.Track.Application.Data.MySQL.Entity;

public partial class PacienteEstudante
{
    public int Id { get; set; }

    public int IdEstudante { get; set; }

    public int IdPaciente { get; set; }

    public virtual Estudante IdEstudanteNavigation { get; set; } = null!;

    public virtual Paciente IdPacienteNavigation { get; set; } = null!;
}
