using Microsoft.Extensions.DependencyInjection;
using Odon.Track.Application.Services;

namespace Odon.Track.Application.Injections.Extensions
{
    public static class CustomAddServicesInjections
    {
        public static IServiceCollection AddServices(this IServiceCollection services) 
        {
            services.AddScoped<AuthServices>();
            return services;
        }
    }
}
