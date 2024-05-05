using System;
using System.Collections.Generic;

namespace WebApplication1;

public partial class PacienteEstudante
{
    public int Id { get; set; }

    public int IdEstudante { get; set; }

    public int IdPaciente { get; set; }

    public virtual Estudante IdEstudanteNavigation { get; set; } = null!;

    public virtual Paciente IdPacienteNavigation { get; set; } = null!;
}
