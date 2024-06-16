using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odon.Track.Application.Data.MySQL.Entity
{
    [Table("endereco_responsavel")]
    public partial class EnderecoResponsavel
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Column("id_responsavel")]
        public int IdResponsavel { get; set; }

        [Column("numero_casa")]
        public string NumeroCasa { get; set; } = null!;
        [Column("logradouro")]
        public string Logradouro { get; set; } = null!;

        [Column("bairro")]
        public string Bairro { get; set; } = null!;

        [Column("cidade")]
        public string Cidade { get; set; } = null!;

        [Column("uf")]
        public string UF { get; set; } = null!;

        [Column("cep")]
        public string CEP { get; set; } = null!;
        [Column("id_paciente")]
        public int IdPaciente { get; set; }

        [ForeignKey(nameof(IdResponsavel))]
        public virtual Responsavel IdResponsavelNavigation { get; set; } = null!;
    }
}
