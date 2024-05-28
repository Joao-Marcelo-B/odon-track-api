namespace Odon.Track.Application.Contract.Professores
{
    public class GetProfessoresDisciplinasResponse
    {
        public int Id { get; set; }
        public string CodigoUnifenas { get; set; }
        public string Nome { get; set; } = null!;
        public List<string> NomeDisciplina{ get; set; }
        public int Bloqueado { get; set; }
}
}
