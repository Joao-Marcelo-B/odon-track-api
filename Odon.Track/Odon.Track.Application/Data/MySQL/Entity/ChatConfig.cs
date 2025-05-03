using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Odon.Track.Application.Data.MySQL.Entity;

[Table("chat_config")]
public class ChatConfig
{
    [Key, Column("id")]
    public int Id { get; set; }

    [Column("prompt_inicial")]
    public string PromptInicial { get; set; }

    [Column("descricao")]
    public string Descricao { get; set; }
}