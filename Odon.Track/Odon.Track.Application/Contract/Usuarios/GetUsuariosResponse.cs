using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odon.Track.Application.Contract.Usuarios
{
    public class GetUsuariosResponse
    {
        public List<UsuariosInfo> Usuarios = new List<UsuariosInfo>();
    }

    public class UsuariosInfo
    {
        public int Id { get; set; }
        public string Identificador { get; set; }
        public string Nome { get; set; }
        public string Email { get; set;}
        public int TipoUsuario {  get; set;}
        public int Status { get; set;}
    }
}
