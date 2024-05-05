using System;
using System.Collections.Generic;

namespace Odon.Track.Application.Data.MySQL.Entity;

public partial class ProntuarioStatus
{
    public int Id { get; set; }

    public int IdProntuario { get; set; }

    public string Descricao { get; set; } = null!;

    public virtual Prontuario IdProntuarioNavigation { get; set; } = null!;
}
