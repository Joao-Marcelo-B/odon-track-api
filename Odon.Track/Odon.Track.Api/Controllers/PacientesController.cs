﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Odon.Track.Application.Authorization;
using Odon.Track.Application.Contract.Pacientes;
using Odon.Track.Application.GetToken;
using Odon.Track.Application.Services;

namespace Odon.Track.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = RolesForUsers.Professor + "," + RolesForUsers.Estudante)]
    public class PacientesController(PacientesServices _services) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetPacientes([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10) =>
            await _services.GetPacientes(pageNumber, pageSize);

        [HttpPost]
        [Authorize(Roles = RolesForAccess.CadastrarPaciente)]
        public async Task<IActionResult> PostCadastrarPaciente([FromBody] PostCadastrarPacienteRequest request) =>
            await _services.PostCadastrarPaciente(GetHeaderValues.GetIdUsuario(Request.HttpContext.User.Claims) ,request);

        [HttpPost("endereco")]
        [Authorize(Roles = RolesForAccess.CadastrarPaciente)]
        public async Task<IActionResult> PostCadastrarEnderecoPaciente([FromBody] PostCadastrarEnderecoPacienteRequest request) =>
            await _services.PostCadastrarEnderecoPaciente(request);
    }
}
