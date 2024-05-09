using System;
using System.Collections.Generic;

namespace Odon.Track.Application.Data.MySQL.Entity;

public partial class ReavaliacaoAnamnese
{
    public int Id { get; set; }

    public int IdPaciente { get; set; }

    public DateTime Data { get; set; }

    public int PressaoArterialSistolica { get; set; }

    public int PressaoArterialDiastolica { get; set; }

    public int FrequenciaRespiratoria { get; set; }

    public int TemperaturaAxilar { get; set; }

    public int Pulso { get; set; }

    public string Medicamentos { get; set; } = null!;

    public string Observacoes { get; set; } = null!;

    public int IdProfessorResponsavel { get; set; }

    public virtual Paciente IdPacienteNavigation { get; set; } = null!;
}
