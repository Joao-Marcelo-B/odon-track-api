using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Odon.Track.Application.Contract.Chat;
using Odon.Track.Application.GetToken;
using Odon.Track.Application.Services;

namespace Odon.Track.Api.Controllers;

[ApiController]
[Route("[controller]")]
[Authorize]
public class ChatController : ControllerBase
{
    private readonly ChatServices _chatServices;

    public ChatController(ChatServices chatServices)
    {
        _chatServices = chatServices;
    }

    [HttpGet("configs")]
    public async Task<IActionResult> GetChatConfigs() =>
        await _chatServices.GetChatConfigs();

    [HttpGet("session")]
    public async Task<IActionResult> GetChatSession() =>
        await _chatServices.GetChatSession();

    [HttpGet("messages/{idSession}")]
    public async Task<IActionResult> GetChatMessages([FromRoute] int idSession) =>
        await _chatServices.GetChatMessages(idSession, GetHeaderValues.GetIdUsuario(Request.HttpContext.User.Claims));    
    
    [HttpPatch("messages")]
    public async Task<IActionResult> PatchChatMessages([FromBody] PatchChatMessagesRequest request) =>
        await _chatServices.PatchChatMessages(request, GetHeaderValues.GetIdUsuario(Request.HttpContext.User.Claims));
}
