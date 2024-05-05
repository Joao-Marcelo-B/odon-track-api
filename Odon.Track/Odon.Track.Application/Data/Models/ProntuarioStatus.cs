using System;
using System.Collections.Generic;

namespace WebApplication1;

public partial class ProntuarioStatus
{
    public int Id { get; set; }

    public int IdProntuario { get; set; }

    public string Descricao { get; set; } = null!;

    public virtual Prontuario IdProntuarioNavigation { get; set; } = null!;
}
