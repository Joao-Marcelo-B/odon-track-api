using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Odon.Track.Application.Data.MySQL.Entity;
[Table("conduta_pronto_atendimento")]
public partial class CondutaProntoAtendimento
{
    [Column("id")]
    public int Id { get; set; }
    [Column("id_prontuario_pronto_atendimento")]
    public int ProntuarioProntoAtendimentoId { get; set; }
    [Column("cod_sus")]
    public string CodSus { get; set; } = null!;
    [Column("conduta")]
    public string Conduta { get; set; } = null!;

    //public virtual ProntuarioProntoAtendimento IdProntuarioProntoAtendimentoNavigation { get; set; } = null!;
}
