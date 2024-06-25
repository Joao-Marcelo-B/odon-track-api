namespace Odon.Track.Application.Contract.Prontuarios
{
    public class GetGruposResponse
    {
        public List<DataGrupo> Grupos { get; set; } = new();
    }

    public class DataGrupo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<DataPerguntas> DataPerguntas { get; set; } = new();
    }

    public class DataPerguntas
    {
        public int Id { get; set; }
        public string Pergunta { get; set; }
        public string TipoPergunta { get; set; }
        public List<DataAlternativas> DataAlternativas { get; set; } = new();
    }

    public class DataAlternativas
    {
        public int Id { get; set; }
        public string Alternativa { get; set; }
    }
}
