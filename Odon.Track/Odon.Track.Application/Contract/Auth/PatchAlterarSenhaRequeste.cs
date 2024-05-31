using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odon.Track.Application.Contract.Auth
{
    public class PatchAlterarSenhaRequeste
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string senhaAtual { get; set; }
        [Required]
        public string novaSenha { get; set; }
        [Required]
        public string confirmarSenha { get; set; }
    }
}
