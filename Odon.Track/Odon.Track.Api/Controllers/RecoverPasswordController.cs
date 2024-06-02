using Microsoft.AspNetCore.Mvc;
using Odon.Track.Application.Contract.Auth;
using Odon.Track.Application.Contract.RecoverPassword;
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

        [HttpPost("CompareCode")]
        public async Task<IActionResult> CompareCode([FromBody] PostRecoverPasswordCompareCodeRequest obj) =>
            await _services.CompareCode(obj);

        [HttpPatch]
        public async Task<IActionResult> ChangePassword([FromBody] PatchRecoverPasswordChangePassword usuario) =>
            await _services.ChangePassword(usuario);
        
    }
}
