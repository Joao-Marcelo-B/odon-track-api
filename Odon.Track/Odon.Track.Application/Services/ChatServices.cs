using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Odon.Track.Application.Contract.Chat;
using Odon.Track.Application.Data.MySQL;
using Odon.Track.Application.Data.MySQL.Entity;
using Odon.Track.Application.Responses;

namespace Odon.Track.Application.Services;

public class ChatServices : BaseResponses
{
    private OdontrackContext _context;
    public ChatServices(OdontrackContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> GetChatConfigs()
    {
        var chatConfig = await _context.ChatConfigs.FirstOrDefaultAsync(x => x.Id == 1);

        return Ok(new { Prompt = chatConfig.PromptInicial }); 
    }

    public async Task<IActionResult> GetChatMessages(int idChat, int idUsuario)
    {
        var chatSession = await _context.ChatSessions.FirstOrDefaultAsync(x => x.Id == idChat && x.IdUsuario == idUsuario);
        if (chatSession == null)
            return BadRequest("Essa sessão não foi encontrada");

        var chatMessages = await _context.ChatMessages.Where(x => x.IdChatSession == chatSession.Id).ToListAsync();
        if(chatMessages == null || chatMessages.Count <= 0)
            return BadRequest("Essa sessão não possui mensagens");

        List<GetChatMessagesResponse> response = chatMessages.Select(x =>  
        {
            return new GetChatMessagesResponse
            {
                DataHora = x.DataCriacao,
                Id = x.Id,
                Ordem = x.Ordem,
                PromptPergunta = x.PromptPergunta,
                PromptResposta = x.PromptResposta
            };
        }).ToList();

        return Ok(response);
    }

    public async Task<IActionResult> PatchChatMessages(PatchChatMessagesRequest request, int idUsuario)
    {
        ChatSession session = null;
        if (request.IdChat == null || request.IdChat <= 0)
        {
            session = new()
            {
                IdChatConfig = 1,
                IdUsuario = idUsuario,
            };

            var chatMessage = new ChatMessage
            {
                IdChatSession = session.Id,
                PromptPergunta = request.PromptPergunta,
                PromptResposta = request.PromptResposta,
                Ordem = 1,
                DataCriacao = DateTime.Now
            };

            _context.ChatSessions.Add(session);
            _context.ChatMessages.Add(chatMessage);
            await _context.SaveChangesAsync();

            return Ok(new { IdChat = session.Id });
        }

        session = await _context.ChatSessions.FirstOrDefaultAsync(x => x.Id == request.IdChat && x.IdUsuario == idUsuario);
        if (session == null)
            return BadRequest("Essa sessão não foi encontrada");

        var chatMessageLast = await _context.ChatMessages.Where(x => x.IdChatSession == session.Id).OrderByDescending(x => x.Ordem).FirstOrDefaultAsync();
        if (chatMessageLast == null)
            return BadRequest("Essa sessão não possui mensagens");

        var newChatMessage = new ChatMessage
        {
            IdChatSession = session.Id,
            PromptPergunta = request.PromptPergunta,
            PromptResposta = request.PromptResposta,
            Ordem = chatMessageLast.Ordem++,
            DataCriacao = DateTime.Now
        };

        _context.ChatMessages.Add(newChatMessage);
        await _context.SaveChangesAsync();

        return Ok();
    }
}
