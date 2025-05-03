using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Odon.Track.Application.Data.MySQL.Entity;

[Table("chat_sessions")]
public class ChatSession
{
    
    [Key, Column("id")]
    public int Id { get; set; }

    [Column("id_chat_config")]
    public int? IdChatConfig { get; set; }

    [ForeignKey("IdChatConfig")]
    protected ChatConfig ChatConfig { get; set; }

    [Column("id_usuario")]
    public int? IdUsuario { get; set; }

    [ForeignKey("IdUsuario")]
    protected Usuario Usuario { get; set; }

    [Column("data_criacao")]
    public DateTime DataCriacao { get; set; } = DateTime.Now;
}