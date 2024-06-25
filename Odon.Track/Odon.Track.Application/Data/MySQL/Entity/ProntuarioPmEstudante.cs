using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Odon.Track.Application.Data.MySQL.Entity;
[Table("prontuario_pm_estudante")]
public partial class ProntuarioPmEstudante
{
    [Column("id"), Key]
    public int Id { get; set; }
    [Column("id_estudante")]
    public int EstudanteId { get; set; }
    [Column("id_prontuario_pm")]
    public int ProntuarioPmIdentificador { get; set; }
}
