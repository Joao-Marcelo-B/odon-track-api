using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odon.Track.Application.Contract.Estudantes
{
    public class PathEstudantesRequest
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Periodo { get; set; }
    }
}
