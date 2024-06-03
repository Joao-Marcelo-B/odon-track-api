using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odon.Track.Application.Contract.RecoverPassword
{
    internal class ResponsePostRecoverPasswordSendEmail
    {
        public string Email { get; set; }
        public int Codigo { get; set; }
        public DateTime Validade { get; set; }
        public string HashIdCodigo { get; set; }
    }
}
