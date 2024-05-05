using System;
using System.Collections.Generic;

namespace Odon.Track.Application.Data.MySQL.Entity;

public partial class Endereco
{
    public int Id { get; set; }

    public int IdPaciente { get; set; }

    public string NumeroCasa { get; set; } = null!;

    public string Rua { get; set; } = null!;

    public string Bairro { get; set; } = null!;

    public string Cidade { get; set; } = null!;

    public string Uf { get; set; } = null!;

    public string Cep { get; set; } = null!;

    public virtual Paciente IdPacienteNavigation { get; set; } = null!;
}
