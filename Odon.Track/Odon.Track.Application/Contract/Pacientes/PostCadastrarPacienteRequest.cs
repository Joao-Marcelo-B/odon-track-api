namespace Odon.Track.Application.Contract.Pacientes
{
    public class PostCadastrarPacienteRequest
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Naturalidade { get; set; }
        public string UF { get; set; }
        public string Profissao { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public string Telefone { get; set; }
        public string CartaoRegionalSUS { get; set; }
        public string CartaoNacionalSUS { get; set; }
        public List<ResponsavelPaciente> ResponsaveisPaciente { get; set; }
    }

    public class ResponsavelPaciente
    {
       public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
