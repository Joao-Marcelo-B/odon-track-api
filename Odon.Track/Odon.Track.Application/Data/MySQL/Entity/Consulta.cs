using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odon.Track.Application.Data.MySQL.Entity
{
    [Table("consulta")]
    public partial class Consulta
    {
        [Key, Column("id")]
        public int Id { get; set; }
        [Column("id_paciente")]
        public int IdPaciente { get; set; }
        [Column("data_hora_consulta")]
        public DateTime DataHoraConsulta { get; set; }
        [Column("data_cadastro")]
        public DateTime DataCadastro {  get; set; }
        [Column("descricao")]
        public string Descricao { get; set; }
        [Column("realizacao")]
        public string Realizacao { get; set; }

        [Column("bloqueada")]
        public int Bloqueada { get; set; }
        [ForeignKey(nameof(IdPaciente))]
        public virtual Paciente IdPacienteNavigation { get; set; } = null!;
    }
}
