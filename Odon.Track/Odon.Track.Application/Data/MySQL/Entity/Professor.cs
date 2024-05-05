using System;
using System.Collections.Generic;

namespace Odon.Track.Application.Data.MySQL.Entity;

public partial class Professor
{
    public int Id { get; set; }

    public int IdUsuario { get; set; }

    public string Nome { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<ProntuarioProntoAtendimento> ProntuarioProntoAtendimentos { get; } = new List<ProntuarioProntoAtendimento>();

    public virtual ICollection<Prontuario> Prontuarios { get; } = new List<Prontuario>();

    public virtual ICollection<Triagem> Triagems { get; } = new List<Triagem>();

    public virtual ICollection<Disciplina> IdDisciplinas { get; } = new List<Disciplina>();
}
