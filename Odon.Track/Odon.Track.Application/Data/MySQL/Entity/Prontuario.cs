using System;
using System.Collections.Generic;

namespace Odon.Track.Application.Data.MySQL.Entity;

public partial class Prontuario
{
    public int Id { get; set; }

    public int IdPaciente { get; set; }

    public int IdProfessorVinculado { get; set; }

    public string QueixaPrincipal { get; set; } = null!;

    public string HistoriaDoencaAtual { get; set; } = null!;

    public sbyte TeveCatapora { get; set; }

    public sbyte TeveSarampo { get; set; }

    public sbyte TeveAmigdalite { get; set; }

    public string? OutrasDoencaInfancia { get; set; }

    public sbyte TeveFebreReumatica { get; set; }

    public sbyte TeveSopros { get; set; }

    public sbyte TevePatologiasDeValvulas { get; set; }

    public sbyte TeveAnomaliasCongenitasCardiacas { get; set; }

    public sbyte TeveHipertensao { get; set; }

    public sbyte TeveArritmias { get; set; }

    public sbyte TeveInfartoDoMiocardio { get; set; }

    public sbyte TeveAnginaOuDorTorax { get; set; }

    public sbyte FezCirurgiasCardiacas { get; set; }

    public sbyte TemAlergiaMedicamentos { get; set; }

    public string? QuaisMedicamentos { get; set; }

    public string OutrasAlergias { get; set; } = null!;

    public sbyte FazUsoMedicamento { get; set; }

    public string? DescricaoMedicamentoUsado { get; set; }

    public string VisitasMedicas { get; set; } = null!;

    public string Observacoes { get; set; } = null!;

    public string DadosRelevantesHistoriaMedica { get; set; } = null!;

    public string HereditarioPai { get; set; } = null!;

    public string HereditarioMae { get; set; } = null!;

    public string HereditarioIrmaos { get; set; } = null!;

    public sbyte HabitoAlcool { get; set; }

    public DateTime HabitoAlcoolInicio { get; set; }

    public string HabitoAlcoolFrequencia { get; set; } = null!;

    public sbyte HabitoFumo { get; set; }

    public DateTime HabitoFumoInicio { get; set; }

    public string HabitoFumoFrequencia { get; set; } = null!;

    public string OutrosHabitosNocivos { get; set; } = null!;

    public string CaminhoMapaPeriodental { get; set; } = null!;

    public virtual Paciente IdPacienteNavigation { get; set; } = null!;

    public virtual Professor IdProfessorVinculadoNavigation { get; set; } = null!;

    public virtual ICollection<ProntuarioEstudante> ProntuarioEstudantes { get; } = new List<ProntuarioEstudante>();

    public virtual ICollection<ProntuarioStatus> ProntuarioStatuses { get; } = new List<ProntuarioStatus>();
}
