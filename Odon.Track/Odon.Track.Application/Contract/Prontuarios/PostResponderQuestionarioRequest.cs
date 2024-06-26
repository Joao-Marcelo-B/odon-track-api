namespace Odon.Track.Application.Contract.Prontuarios
{
    public class PostResponderQuestionarioRequest
    {
        public int IdProntuario { get; set; }
        public string Status { get; set; }
        public Pessoa Paciente { get; set; } = new();
        public List<PerguntasAbertasResposta> PerguntasAbertasRespostas { get; set; } = new();
        public List<PerguntasAlternativasResposta> PerguntasAlternativasRespostas { get; set; } = new();

    }

    public class PerguntasAbertasResposta
    {
        public int IdPergunta { get; set; }
        public string Resposta { get; set; }
    }

    public class PerguntasAlternativasResposta
    {
        public int IdPergunta { get; set; }
        public int IdAlternativa { get; set; }
        public bool Checked { get; set; }
    }
}
