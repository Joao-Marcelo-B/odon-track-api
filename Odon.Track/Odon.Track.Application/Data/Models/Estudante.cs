using System;
using System.Collections.Generic;

namespace WebApplication1;

public partial class Estudante
{
    public int Id { get; set; }

    public int IdUsuario { get; set; }

    public string Nome { get; set; } = null!;

    public string Matricula { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<PacienteEstudante> PacienteEstudantes { get; } = new List<PacienteEstudante>();

    public virtual ICollection<ProntuarioPmEstudante> ProntuarioPmEstudantes { get; } = new List<ProntuarioPmEstudante>();
}
