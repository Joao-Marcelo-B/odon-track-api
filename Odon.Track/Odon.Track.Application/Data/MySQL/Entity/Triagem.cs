using System.ComponentModel.DataAnnotations.Schema;

namespace Odon.Track.Application.Data.MySQL.Entity;

[Table("triagem")]
public partial class Triagem
{
    [Column("id")]
    public int Id { get; set; }
    [Column("id_paciente")]
    public int IdPaciente { get; set; }
    [Column("id_professor_assinatura")]
    public int IdProfessorAssinatura { get; set; }
    [Column("id_estudante_assinatura")]
    public int IdEstudanteAssinatura { get; set; }

    [Column("encaminhar_periodo")]
    public int EncaminharPeriodo { get; set; }

    [Column("especializacao_cirurgia")]
    public int EspecializacaoCirurgia { get; set; }

    [Column("especializacao_protese_implante")]
    public int EspecializacaoProteseImplante { get; set; }

    [Column("outras_especializacoes")]
    public string OutrasEspecializacoes { get; set; } = null!;

    [Column("data_cadastro")]
    public DateTime DataCadastro { get; set; }

    private Professor IdProfessorVinculadoNavigation { get; set; } = null!;

    private ICollection<NecessidadeTratamento> NecessidadeTratamentos { get; } = new List<NecessidadeTratamento>();
}
