using System.ComponentModel.DataAnnotations.Schema;

namespace Odon.Track.Application.Contract.Pacientes
{
    public class PostCadastrarPacienteRequest
    {
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
        public string Indicacao { get; set; }

    }

    public class ResponsavelPaciente
    {
       public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Email { get; set; }
    }
}
