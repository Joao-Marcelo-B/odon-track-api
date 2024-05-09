using System.ComponentModel.DataAnnotations;

namespace Odon.Track.Application.Contract
{
    public class PostAuthRequest
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
