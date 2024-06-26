using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Odon.Track.Application.Data.MySQL.Entity
{
    [Table("prontuario_menor")]
    public class ProntuarioMenor
    {
        [Key, Column("id")]
        public int Id { get; set; }
        [Column("id_paciente")]
        public int? IdPaciente { get; set; }
        [Column("id_estudante_vinculado")]
        public int? IdEstudanteVinculado { get; set; }
        [Column("id_professor_vinculado")]
        public int? IdProfessorVinculado { get; set; }
        [Column("id_prontuario_status")]
        public int? IdProntuarioStatus { get; set; }
        [Column("data_cadastro")]
        public DateTime? DataCadastro { get; set; }

        [ForeignKey("IdPaciente")]
        public Paciente Paciente { get; set; }
        [ForeignKey("IdEstudanteVinculado")]
        public Professor ProfessorVinculado { get; set; }
        [ForeignKey("IdProfessorVinculado")]
        public Estudante EstudanteVinculado { get; set; }
    }
}
