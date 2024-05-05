using System;
using System.Collections.Generic;

namespace WebApplication1;

public partial class ProntuarioProntoAtendimento
{
    public int Id { get; set; }

    public int IdPaciente { get; set; }

    public int IdProfessorVinculado { get; set; }

    public string QueixaPrincipal { get; set; } = null!;

    public string HistoriaMolestiaAtual { get; set; } = null!;

    public sbyte JaTomouAnestesiaOdontologica { get; set; }

    public sbyte TeveAlgumaReacaoIndesejavel { get; set; }

    public sbyte EstaSobTratamentoMedico { get; set; }

    public string? MotivoTratamentoMedico { get; set; }

    public sbyte EstaTomandoAlgumMedicamento { get; set; }

    public string? QualMedicamento { get; set; }

    public sbyte AlergiaAlgumMedicamentoSubstancia { get; set; }

    public string? QualMedicamentoSubstancia { get; set; }

    public sbyte EDiabetico { get; set; }

    public sbyte EstaGravida { get; set; }

    public sbyte SofreDisturbiosCardiovasculares { get; set; }

    public string? QualDisturbioCardiovascular { get; set; }

    public sbyte TemHipertensao { get; set; }

    public sbyte FazUsoProteseCardiaca { get; set; }

    public string? Outros { get; set; }

    public sbyte ApresentaHistoriaHemorragia { get; set; }

    public sbyte ApresentaHistoriaFebreReumatica { get; set; }

    public sbyte Bronquite { get; set; }

    public sbyte Asma { get; set; }

    public string? OutrosDisturbiosRespiratorios { get; set; }

    public sbyte SofreDisturbioGastroIntestinal { get; set; }

    public sbyte Gastrite { get; set; }

    public sbyte Ulcera { get; set; }

    public sbyte Hepatite { get; set; }

    public sbyte Cirrose { get; set; }

    public sbyte TeveDoencaInfectoContagiosa { get; set; }

    public string? QualDoencaInfectoContagiosa { get; set; }

    public sbyte ExisteDoencaPredominanteFamilia { get; set; }

    public string? QualDoencaPredominante { get; set; }

    public string? OutrasInformacoesHabitosVicios { get; set; }

    public string? Observacoes { get; set; }

    public string PressaoArterialMmMmHg { get; set; } = null!;

    public string Diagnostico { get; set; } = null!;

    public sbyte AlunoAssinou { get; set; }

    public string CidadeFichaFeita { get; set; } = null!;

    public DateTime DataFichaFeita { get; set; }

    public sbyte ProfessorAssinou { get; set; }

    public sbyte PacienteAssinou { get; set; }

    public virtual ICollection<CondutaProntoAtendimento> CondutaProntoAtendimentos { get; } = new List<CondutaProntoAtendimento>();

    public virtual Paciente IdPacienteNavigation { get; set; } = null!;

    public virtual Professor IdProfessorVinculadoNavigation { get; set; } = null!;

    public virtual ICollection<ProntuarioPmEstudante> ProntuarioPmEstudantes { get; } = new List<ProntuarioPmEstudante>();
}
