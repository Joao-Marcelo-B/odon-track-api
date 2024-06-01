using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Odon.Track.Application.Data.MySQL.Entity;

[Table("paciente")]
public partial class Paciente
{
    [Key, Column("id")]
    public int Id { get; set; }

    [Column("id_paciente_status")]
    public int IdPacienteStatus { get; set; }

    [Column("id_usuario_cadastro")]
    public int IdUsuarioCadastro { get; set; }

    [Column("nome")]
    public string? Nome { get; set; }

    [Column("naturalidade")]
    public string Naturalidade { get; set; } = null!;

    [Column("uf_naturalidade")]
    public string UFNaturalidade { get; set; } = null!;

    [Column("profissao")]
    public string Profissao { get; set; } = null!;

    [Column("cpf")]
    public string CPF { get; set; } = null!;

    [Column("rg")]
    public string RG { get; set; } = null!;

    [Column("nome_pai")]
    public string? NomePai { get; set; }

    [Column("nome_mae")]
    public string? NomeMae { get; set; }

    [Column("telefone")]
    public string? Telefone { get; set; }

    [Column("cartao_regional_sus")]
    public string? CartaoRegionalSus { get; set; }

    [Column("cartao_nacional_sus")]
    public string? CartaoNacionalSus { get; set; }

    [Column("data_nascimento")]
    public DateTime DataNascimento { get; set; }

    [Column("data_cadastro")]
    public DateTime DataCadastro { get; set; }
    [Column("ativo")]
    public int Ativo { get; set; } = 1;
    public virtual ICollection<Endereco> Enderecos { get; } = new List<Endereco>();

    [ForeignKey(nameof(IdPacienteStatus))]
    public virtual PacienteStatus IdPacienteStatusNavigation { get; set; } = null!;

    public virtual ICollection<PacienteEstudante> PacienteEstudantes { get; } = new List<PacienteEstudante>();

    public virtual ICollection<ProntuarioProntoAtendimento> ProntuarioProntoAtendimentos { get; } = new List<ProntuarioProntoAtendimento>();

    public virtual ICollection<Prontuario> Prontuarios { get; } = new List<Prontuario>();

    public virtual ICollection<ReavaliacaoAnamnese> ReavaliacaoAnamneses { get; } = new List<ReavaliacaoAnamnese>();
}
