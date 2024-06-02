﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Odon.Track.Application.Authorization;
using Odon.Track.Application.Contract.Pacientes;
using Odon.Track.Application.Services;

namespace Odon.Track.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = RolesForUsers.Professor + "," + RolesForUsers.Estudante)]
    public class ProntuariosController(ProntuariosServices _services) : ControllerBase
    {
        [HttpPost("triagem")]
        [Authorize(Roles = RolesForAccess.CadastrarTriagem)]
        public async Task<IActionResult> PostCadastrarTriagem([FromBody] PostCadastrarTriagemRequest request) =>
            await _services.PostCadastrarTriagem(request);

        [HttpGet]
        public async Task<IActionResult> GetProntuarios([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10) =>
            await _services.GetProntuarios(pageNumber, pageSize);

        [HttpGet("triagem")]
        public async Task<IActionResult> GetTriagem([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10) =>
            await _services.GetTriagem(pageNumber, pageSize);

        [HttpGet("pronto-atendimento")]
        public async Task<IActionResult> GetProntoAtendimento([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10) =>
            await _services.GetProntoAtendimento(pageNumber, pageSize);
    }   
}