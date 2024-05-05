using System;
using System.Collections.Generic;

namespace WebApplication1;

public partial class Paciente
{
    public int Id { get; set; }

    public int IdPacienteStatus { get; set; }

    public int IdTriagem { get; set; }

    public string Naturalidade { get; set; } = null!;

    public string UfNaturalidade { get; set; } = null!;

    public string Profissao { get; set; } = null!;

    public string Cpf { get; set; } = null!;

    public string Rg { get; set; } = null!;

    public string? NomePai { get; set; }

    public string? NomeMae { get; set; }

    public string? Telefone { get; set; }

    public string? CartaoRegionalSus { get; set; }

    public string? CartaoNacionalSus { get; set; }

    public DateTime DataNascimento { get; set; }

    public virtual ICollection<Endereco> Enderecos { get; } = new List<Endereco>();

    public virtual PacienteStatus IdPacienteStatusNavigation { get; set; } = null!;

    public virtual ICollection<PacienteEstudante> PacienteEstudantes { get; } = new List<PacienteEstudante>();

    public virtual ICollection<ProntuarioProntoAtendimento> ProntuarioProntoAtendimentos { get; } = new List<ProntuarioProntoAtendimento>();

    public virtual ICollection<Prontuario> Prontuarios { get; } = new List<Prontuario>();

    public virtual ICollection<ReavaliacaoAnamnese> ReavaliacaoAnamneses { get; } = new List<ReavaliacaoAnamnese>();

    public virtual ICollection<Triagem> Triagems { get; } = new List<Triagem>();
}
