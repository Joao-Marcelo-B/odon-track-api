using System;
using System.Collections.Generic;

namespace Odon.Track.Application.Data.MySQL.Entity;

public partial class Triagem
{
    public int Id { get; set; }

    public string EncaminharPeriodo { get; set; } = null!;

    public sbyte EspecializacaoCirurgia { get; set; }

    public sbyte EspecializacaoProteseImplante { get; set; }

    public string OutrasEspecializacoes { get; set; } = null!;

    public int IdProfessorVinculado { get; set; }

    public string Triagemcol { get; set; } = null!;

    public int IdPaciente { get; set; }

    public virtual ICollection<HorarioDisponivelAtendimento> HorarioDisponivelAtendimentos { get; } = new List<HorarioDisponivelAtendimento>();

    public virtual Paciente IdPacienteNavigation { get; set; } = null!;

    public virtual Professor IdProfessorVinculadoNavigation { get; set; } = null!;

    public virtual ICollection<NecessidadeTratamento> NecessidadeTratamentos { get; } = new List<NecessidadeTratamento>();
}
