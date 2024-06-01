using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odon.Track.Application.Data.MySQL.Entity
{
    [Table("codigo_seguranca")]
    public class CodigoSeguranca
    {
        [Key, Column("id")]
        public int Id { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("codigo")]
        public int Codigo { get; set; }
        [Column("validade")]
        public DateTime Validade { get; set; }
    }
}
