using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odon.Track.Application.Contract.Prontuarios
{
    public class GetTriagemResponse
    {
        public int Id { get; set; }
        public Pessoa Paciente { get; set; }
        public Pessoa Professor { get; set; }
        public Pessoa Estudante { get; set; }
        public List<Tratamento> Tratamentos { get; set; }
        public int EncaminharPeriodo { get; set; }
        public bool EspecializacaoCirurgia { get; set; }
        public bool EspecializacaoProteseImplante { get; set; }
        public string OutrasEspecializacoes { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<Horarios> HorariosDisponiveisAtendimento { get; set; }
    }

    public class Pessoa 
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }

    public class Horarios 
    {
        public string Id { get; set; }
        public string Descricao { get; set; }
    }


}
