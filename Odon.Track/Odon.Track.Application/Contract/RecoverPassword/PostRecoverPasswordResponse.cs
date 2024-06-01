using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odon.Track.Application.Contract.RecoverPassword
{
    internal class PostRecoverPasswordResponse
    {
        public string codigo { get; set; }
        public string nomeUsuario { get; set; }
        public string numeroUnifenas { get; set; }
        public string email { get; set; }
    }
}
