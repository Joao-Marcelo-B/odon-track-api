﻿using System;
using System.Collections.Generic;

namespace Odon.Track.Application.Data.MySQL.Entity;

public partial class CondutaProntoAtendimento
{
    public int Id { get; set; }

    public int IdProntuarioProntoAtendimento { get; set; }

    public string CodSus { get; set; } = null!;

    public string Conduta { get; set; } = null!;

    public virtual ProntuarioProntoAtendimento IdProntuarioProntoAtendimentoNavigation { get; set; } = null!;
}