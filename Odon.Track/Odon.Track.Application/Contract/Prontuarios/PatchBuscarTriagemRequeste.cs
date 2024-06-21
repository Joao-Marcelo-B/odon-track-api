using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odon.Track.Application.Contract.Prontuarios
{
    public class PatchBuscarTriagemRequeste
    {
        public int? IdProntuario { get; set; }
        public int? IdEstudante { get; set; }
        public int? IdProfessor { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string Status {  get; set; }
    }
}
