using System;
using System.Collections.Generic;

namespace WebApplication1;

public partial class HorarioDisponivelAtendimento
{
    public int Id { get; set; }

    public int IdTriagem { get; set; }

    public sbyte? SeteMeia { get; set; }

    public sbyte? NoveMeia { get; set; }

    public sbyte? UmaMeia { get; set; }

    public sbyte? TresMeia { get; set; }

    public virtual Triagem IdTriagemNavigation { get; set; } = null!;
}
