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
    public string Nome { get; set; }

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
    public string? CartaoRegionalSUS { get; set; }

    [Column("cartao_nacional_sus")]
    public string? CartaoNacionalSUS { get; set; }

    [Column("data_nascimento")]
    public DateTime DataNascimento { get; set; }

    [Column("data_cadastro")]
    public DateTime DataCadastro { get; set; }
    [Column("ativo")]
    public int Ativo { get; set; }

    [Column("precisa_responsavel")]
    public int? NecessitaResponsavel { get; set; }

    [Column("sexo")]
    public string? Sexo { get; set; }

    [Column("sexo_outro")]
    public string? SexoOutro { get; set; }

    [Column("grupo_etnico")]
    public string? GrupoEtnico { get; set; }

    [Column("data_expedicao_rg")]
    public DateTime? DataExpedicaoRG { get; set; }

    [Column("estado_civil")]
    public string? EstadoCivil { get; set; }

    [Column("mora_com")]
    public string? MoraCom {  get; set; }

    [Column("mora_com_outro")]
    public string? MoraComOutro { get; set; }

    [Column("escola")]
    public string? Escola {  get; set; }

    [Column("serie")]
    public string? Serie {  get; set; }

    [Column("turno")]
    public string? Turno { get; set; }

    [Column("indicacao")]
    public string Indicacao { get; set; }

    public virtual ICollection<Endereco> Enderecos { get; } = new List<Endereco>();

    [ForeignKey(nameof(IdPacienteStatus))]
    public virtual PacienteStatus IdPacienteStatusNavigation { get; set; } = null!;

    public virtual ICollection<PacienteEstudante> PacienteEstudantes { get; } = new List<PacienteEstudante>();

    public virtual ICollection<ProntuarioProntoAtendimento> ProntuarioProntoAtendimentos { get; } = new List<ProntuarioProntoAtendimento>();

    public virtual ICollection<Prontuario> Prontuarios { get; } = new List<Prontuario>();

    public virtual ICollection<ProntuarioMenor> ProntuarioMenor { get; } = new List<ProntuarioMenor>();
}
