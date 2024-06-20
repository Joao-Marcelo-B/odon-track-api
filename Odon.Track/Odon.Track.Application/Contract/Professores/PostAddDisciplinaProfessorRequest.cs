using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odon.Track.Application.Contract.Professores
{
    public class PostAddDisciplinaProfessorRequest
    {
        public int idDisciplina { get; set; }
        public int idProfessor { get; set; }
    }
}
