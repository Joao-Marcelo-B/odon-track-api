using System;
using System.Collections.Generic;

namespace Odon.Track.Application.Data.MySQL.Entity;

public partial class ProntuarioPmEstudante
{
    public int Id { get; set; }

    public int IdEstudante { get; set; }

    public int IdProntuarioPm { get; set; }

    public virtual Estudante IdEstudanteNavigation { get; set; } = null!;

    public virtual ProntuarioProntoAtendimento IdProntuarioPmNavigation { get; set; } = null!;
}
