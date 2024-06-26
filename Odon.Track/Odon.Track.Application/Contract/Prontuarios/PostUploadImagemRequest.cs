using Microsoft.AspNetCore.Http;

namespace Odon.Track.Application.Contract.Prontuarios;

public class PostUploadImagemRequest
{
    public int IdProntuario { get; set; }
    public ETipoImagem TipoImagem  { get; set; }
    public IFormFile Imagem { get; set; }
}

public enum ETipoImagem
{
    mapa_periodontal,
    controle_placa_bacteriana,
    outros,
    foto_denticao_crianca,
    outros_crianca
}
