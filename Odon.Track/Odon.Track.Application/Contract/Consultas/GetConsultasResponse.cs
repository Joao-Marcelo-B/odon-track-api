using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odon.Track.Application.Contract.Consultas
{
    public class GetConsultasResponse
    {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public string NomePaciente { get; set; }  
        public string Descricao { get; set; }
        public string DataConsulta { get; set; }
        public string HoraConsulta { get; set; }
        
    }
}
