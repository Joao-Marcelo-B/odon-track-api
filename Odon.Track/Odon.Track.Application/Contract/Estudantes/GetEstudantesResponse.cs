
namespace Odon.Track.Application.Contract.Estudantes
{
    public class GetEstudantesResponse
    {
        public List<EstudantesInfo> Estudantes = new List<EstudantesInfo>();
    }

    public class EstudantesInfo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int PeriodoAtual { get; set; }

    }
}
