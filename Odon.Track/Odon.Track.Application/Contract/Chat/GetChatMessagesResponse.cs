namespace Odon.Track.Application.Contract.Chat;
public class GetChatMessagesResponse
{
    public int Id { get; set; }
    public string PromptPergunta { get; set; }
    public string PromptResposta { get; set; }
    public int Ordem { get; set; }
    public DateTime DataHora { get; set; }
}
