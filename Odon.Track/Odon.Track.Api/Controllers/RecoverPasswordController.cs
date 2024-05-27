using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Odon.Track.Application.Contract.Auth;
using Odon.Track.Application.Data.MySQL.Entity;
using Odon.Track.Application.Services;

namespace Odon.Track.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RecoverPasswordController : ControllerBase
    {
        private readonly RecoverPasswordServices _services;

        public RecoverPasswordController(RecoverPasswordServices service)
        {
            _services = service;
        }

        [HttpPost]
        public async Task<IActionResult> GetCode([FromBody]PostRecoverPasswordRequest email) =>
            await _services.GetCode(email);
        
    }
}
