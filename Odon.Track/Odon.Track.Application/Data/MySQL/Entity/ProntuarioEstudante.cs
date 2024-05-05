using System;
using System.Collections.Generic;

namespace Odon.Track.Application.Data.MySQL.Entity;

public partial class ProntuarioEstudante
{
    public int Id { get; set; }

    public int IdProntuario { get; set; }

    public int IdEstudante { get; set; }

    public virtual Prontuario IdProntuarioNavigation { get; set; } = null!;
}
