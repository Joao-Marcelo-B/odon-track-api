namespace Odon.Track.Application.Contract.Prontuarios
{
    public class PostObservacaoMenorRequest
    {
        public int IdPaciente { get; set; }
        public List<string> Observacoes { get; set; }
    }
}
