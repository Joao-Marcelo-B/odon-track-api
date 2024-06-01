namespace Odon.Track.Application.Contract.Pacientes
{
    public class GetPacientesResponse
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Status { get; set; }
        public string DataNascimento { get; set; }
        public int  Atividade { get; set; }
    }
}
