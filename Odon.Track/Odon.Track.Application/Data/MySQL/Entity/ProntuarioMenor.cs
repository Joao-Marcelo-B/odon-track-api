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
        public int IdPaciente { get; set; }
        [Column("data_cadastro")]
        public DateTime DataCadastro { get; set; }
    }
}
