using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odon.Track.Application.Contract.Professores
{
    public class PatchUpdateProfessorRequest
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public bool Ativo { get; set; }
    }
}
