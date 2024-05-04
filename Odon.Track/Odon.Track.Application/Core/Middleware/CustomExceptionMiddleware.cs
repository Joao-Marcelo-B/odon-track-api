using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Odon.Track.Application.Core.Middleware
{
    public class CustomExceptionMiddleware(RequestDelegate _next)
    {
        public async Task InvokeAsync(HttpContext context , ILogger<CustomExceptionMiddleware> _log)
        {
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Response.ContentType = "application/json";

            await context
                    .Response
                    .WriteAsync(JsonConvert
                                .SerializeObject(
                                new
                                {
                                    message = "Ocorreu um erro inesperado. Tente novamente mais tarde."
                                }));

            var exceptionHandlerPathFeature =
                context.Features.Get<IExceptionHandlerPathFeature>();

            _log.LogError(exceptionHandlerPathFeature!.Error.ToString());
        }
    }
}
