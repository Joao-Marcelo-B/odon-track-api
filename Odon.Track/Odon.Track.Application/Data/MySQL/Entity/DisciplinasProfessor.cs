using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odon.Track.Application.Data.MySQL.Entity
{
    [Table("disciplinas_professor")]
    public class DisciplinasProfessor
    {
        [Column("id_disciplinas")]
        public int Id_Disciplinas { get; set; }
        [Column("id_professor")]
        public int Id_Professor { get; set; }
        public virtual Disciplina Disciplina { get; set; }
        public virtual Professor Professor { get; set; }
    }
}
