﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odon.Track.Application.Contract.Pacientes
{
    public class PostCadastrarEnderecoResponsavel
    {
        public int IdResponsavel { get; set; }
        public int IdPaciente { get; set; }
        public string NumeroCasa { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
    }
}
