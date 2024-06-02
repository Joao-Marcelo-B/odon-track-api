using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odon.Track.Application.Contract.RecoverPassword
{
    public class PatchRecoverPasswordChangePassword
    {
        public string HashIdCodigo { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
