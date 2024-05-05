using Microsoft.Extensions.DependencyInjection;
using Odon.Track.Application.Configuration;
using Odon.Track.Application.Services;

namespace Odon.Track.Application.Core.Injections.Extensions
{
    public static class InjectionsCoreExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<AuthServices>();
            return services;
        }
    }
}
