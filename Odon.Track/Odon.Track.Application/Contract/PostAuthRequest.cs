using System.ComponentModel.DataAnnotations;

namespace Odon.Track.Application.Contract
{
    public class PostAuthRequest
    {
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
