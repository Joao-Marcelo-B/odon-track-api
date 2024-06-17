using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odon.Track.Application.Contract.Pacientes
{
    public class PathAtualizarPacienteRequest
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Naturalidade { get; set; }
        public string UFNaturalidade { get; set; }
        public string Profissao { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public int Ativo { get; set; }
        public int NecessitaResponsavel { get; set; }
        public string Telefone { get; set; }
        public string CartaoRegionalSUS { get; set; }
        public string CartaoNacionalSUS { get; set; }
        public string Sexo { get; set; }
        public string SexoOutro { get; set; }
        public string GrupoEtnico { get; set; }
        public DateTime DataExpedicaoRG { get; set; }
        public string EstadoCivil { get; set; }
        public string MoraCom { get; set; }
        public string MoraComOutro { get; set; }
        public string Escola { get; set; }
        public string Serie { get; set; }
        public string Turno { get; set; }
    }
}
