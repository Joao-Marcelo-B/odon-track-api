namespace Odon.Track.Application.Contract.Prontuarios
{
    public class GetImagensProntuarioResponse
    {
        public int IdImagem { get; set; }
        public string Imagem { get; set; }
        public string TipoImagem { get; set; }
        public string Filename { get; set; }
        public string ContentType { get; set; }
    }
}
