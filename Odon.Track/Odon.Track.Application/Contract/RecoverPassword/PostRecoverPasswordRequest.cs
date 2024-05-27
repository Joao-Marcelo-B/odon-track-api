using System.ComponentModel.DataAnnotations;

namespace Odon.Track.Application.Contract.Auth
{
    public class PostRecoverPasswordRequest
    {
        [Required, EmailAddress]
        public string Email { get; set; }
    }
}
