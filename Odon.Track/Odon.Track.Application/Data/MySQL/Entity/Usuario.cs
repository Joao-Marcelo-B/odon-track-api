using System;
using System.Collections.Generic;

namespace Odon.Track.Application.Data.MySQL.Entity;

public partial class Usuario
{
    public int Id { get; set; }

    public int IdTipoUsuario { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Estudante> Estudantes { get; } = new List<Estudante>();

    public virtual TipoUsuario IdTipoUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<Professor> Professors { get; } = new List<Professor>();
}
