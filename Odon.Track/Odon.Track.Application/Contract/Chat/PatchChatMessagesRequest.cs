namespace Odon.Track.Application.Contract.Chat;

public class PatchChatMessagesRequest
{
    public int? IdChat { get; set; }
    public string Titulo { get; set; }
    public string PromptPergunta { get; set; }
    public string PromptResposta { get; set; }
}
