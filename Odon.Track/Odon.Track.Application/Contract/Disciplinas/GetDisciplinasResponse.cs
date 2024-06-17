using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odon.Track.Application.Data.MySQL.Entity;

namespace Odon.Track.Application.Contract.Disciplinas
{
    public class GetDisciplinasResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<string> Professores { get; set; }
    }
}
