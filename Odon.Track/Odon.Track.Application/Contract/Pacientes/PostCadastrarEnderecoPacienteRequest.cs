namespace Odon.Track.Application.Contract.Pacientes
{
    public class PostCadastrarEnderecoPacienteRequest
    {
        public int IdPaciente { get; set; }
        public string NumeroCasa { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
    }
}
