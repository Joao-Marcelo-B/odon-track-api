﻿using System;
using System.Collections.Generic;

namespace WebApplication1;

public partial class TipoUsuario
{
    public int Id { get; set; }

    public string? Descricao { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; } = new List<Usuario>();
}
