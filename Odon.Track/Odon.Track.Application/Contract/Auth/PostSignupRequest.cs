using System.ComponentModel.DataAnnotations;

namespace Odon.Track.Application.Contract.Auth
{
    public class PostSignupRequest
    {
        [Required]
        public int TipoUsuario { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Identificador { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string PasswordConfirmed { get; set; }
    }
}
