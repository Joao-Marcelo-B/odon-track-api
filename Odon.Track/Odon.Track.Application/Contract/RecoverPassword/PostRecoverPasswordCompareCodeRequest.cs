using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odon.Track.Application.Contract.RecoverPassword
{
    public class PostRecoverPasswordCompareCodeRequest
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Email { get; set; }
        public DateTime Validade { get; set; }
    }
}
