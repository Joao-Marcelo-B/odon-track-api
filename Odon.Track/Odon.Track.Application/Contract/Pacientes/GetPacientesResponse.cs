namespace Odon.Track.Application.Contract.Pacientes
{
    public class GetPacientesResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Status { get; set; }
        public string DataNascimento { get; set; }
        public int  Atividade { get; set; }
    }
}
