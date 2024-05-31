using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odon.Track.Application.Contract.Usuarios
{
    public class GetUsuarioResponse
    {
        public List<UsuarioInfo> Usuario = new List<UsuarioInfo>();
    }

    public class UsuarioInfo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdTipoUsuario { get; set; }
        public string Email { get; set; }
        public string Identificador { get; set; }
        public int periodo { get; set; }
    }
}
