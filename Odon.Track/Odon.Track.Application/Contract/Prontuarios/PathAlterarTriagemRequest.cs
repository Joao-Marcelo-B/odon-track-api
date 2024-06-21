using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odon.Track.Application.Contract.Prontuarios
{
    public class PathAlterarTriagemRequest
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int EncaminharPeriodo { get; set; }
        public bool EspecializacaoCirurgia { get; set; }
        public bool EspecializacaoProteseImplante { get; set; }
        public string OutrasEspecializacoes { get; set; }
        public List<EHorarioDisponivelAtendimento> HorariosDisponiveisAtendimento { get; set; }
        public List<Tratamento> Tratamentos { get; set; }
        public int Status { get; set; }
    }
}
