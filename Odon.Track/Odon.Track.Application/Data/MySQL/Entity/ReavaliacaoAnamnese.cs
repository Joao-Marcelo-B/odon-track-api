using System.ComponentModel.DataAnnotations.Schema;

namespace Odon.Track.Application.Data.MySQL.Entity;

[Table("reavaliacao_anamnese")]
public partial class ReavaliacaoAnamnese
{
    [Column("id")]
    public int Id { get; set; }

    [Column("id_professor_responsavel")]
    public int IdProfessorResponsavel { get; set; }
    [Column("id_prontuario")]
    public int IdProntuario { get; set; }

    [Column("data")]
    public DateTime Data { get; set; }

    [Column("pressao_arterial")]
    public string PressaoArterial{ get; set; }

    [Column("frequencia_respiratoria")]
    public string FrequenciaRespiratoria { get; set; }

    [Column("temperatura_axilar")]
    public string TemperaturaAxilar { get; set; }

    [Column("pulso")]
    public string Pulso { get; set; }

    [Column("medicamentos")]
    public string Medicamentos { get; set; } = null!;

    [Column("observacoes")]
    public string Observacoes { get; set; } = null!;

    [ForeignKey(nameof(IdPaciente))]
    public Paciente Paciente{ get; set; } = null!;

    [ForeignKey(nameof(IdProfessorResponsavel))]
    public Professor Professor { get; set; } = null!;
}
