using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Odon.Track.Application.Data.MySQL.Entity;

public partial class ReavaliacaoAnamnese
{
    [Column("id")]
    public int Id { get; set; }

    [Column("id_paciente")]
    public int IdPaciente { get; set; }

    [Column("data")]
    public DateTime Data { get; set; }

    [Column("pressao_arterial_sistolica")]
    public int PressaoArterialSistolica { get; set; }

    [Column("pressao_arterial_diastolica")]
    public int PressaoArterialDiastolica { get; set; }

    [Column("frequencia_respiratoria")]
    public int FrequenciaRespiratoria { get; set; }

    [Column("temperatura_axilar")]
    public int TemperaturaAxilar { get; set; }

    [Column("pulso")]
    public int Pulso { get; set; }

    [Column("medicamentos")]
    public string Medicamentos { get; set; } = null!;

    [Column("observacoes")]
    public string Observacoes { get; set; } = null!;

    [Column("id_professor_responsavel")]
    public int IdProfessorResponsavel { get; set; }

    [ForeignKey(nameof(IdPaciente))]
    public Paciente Paciente{ get; set; } = null!;

    [ForeignKey(nameof(IdProfessorResponsavel))]
    public Professor Professor { get; set; } = null!;
}
