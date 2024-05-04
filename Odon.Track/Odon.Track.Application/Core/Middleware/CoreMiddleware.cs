using Microsoft.AspNetCore.Builder;

namespace Odon.Track.Application.Core.Middleware
{
    public static class CoreMiddleware
    {
        public static void UseCustomError(this IApplicationBuilder app)
        {
            app.UseMiddleware<CustomExceptionMiddleware>();
        }
    }
}
