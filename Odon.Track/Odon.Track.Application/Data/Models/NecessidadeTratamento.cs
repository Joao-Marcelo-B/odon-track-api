using System;
using System.Collections.Generic;

namespace WebApplication1;

public partial class NecessidadeTratamento
{
    public int Id { get; set; }

    public int IdTriagem { get; set; }

    public string Endodontia { get; set; } = null!;

    public string Periodontia { get; set; } = null!;

    public string Dentistica { get; set; } = null!;

    public string Cirurgia { get; set; } = null!;

    public string Protese { get; set; } = null!;

    public virtual Triagem IdTriagemNavigation { get; set; } = null!;
}
