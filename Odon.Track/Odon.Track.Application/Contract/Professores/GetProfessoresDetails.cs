using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odon.Track.Application.Contract.Professores
{
    internal class GetProfessoresDetails
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public List<string> NomeDisciplina { get; set; }

        public string IdentificadorUnifenas { get; set; }
        public string Email { get; set; }

    }
}
