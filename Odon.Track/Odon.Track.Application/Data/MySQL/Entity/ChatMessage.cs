using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Odon.Track.Application.Data.MySQL.Entity;

[Table("chat_messages")]
public class ChatMessage
{
    [Key, Column("id")]
    public int Id { get; set; }

    [Column("id_chat_session")]
    public int? IdChatSession { get; set; }

    [ForeignKey("IdChatSession")]
    public ChatSession ChatSession { get; set; }

    [Column("ordem")]
    public int Ordem { get; set; }

    [Column("prompt_pergunta")]
    public string PromptPergunta { get; set; }

    [Column("prompt_resposta")]
    public string PromptResposta { get; set; }

    [Column("data_criacao")]
    public DateTime DataCriacao { get; set; } = DateTime.Now;
}
