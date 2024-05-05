using Microsoft.AspNetCore.Mvc;
using Odon.Track.Application.Responses;

namespace Odon.Track.Application.Services
{
    public class AuthServices : BaseResponses
    {
        public async Task<IActionResult> Singup()
        {
            return Ok();
        }
        public async Task<IActionResult> Auth(int valor)
        {
            return Ok(new { Teste = 10 / valor });
        } 
    }
}
