using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odon.Track.Application.Contract.Consultas
{
    public class PostCadastrarConsultaResquest
    {
        public int IdPaciente { get; set; }
        public string Descricao { get; set; }
        public string DataConsulta { get; set; }
        public string HoraConsulta { get; set; }
        public string Realizacao { get; set; }
    }
}
