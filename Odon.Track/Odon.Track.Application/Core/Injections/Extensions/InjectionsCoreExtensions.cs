using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Odon.Track.Application.Configuration;
using Odon.Track.Application.Data.MySQL;
using Odon.Track.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Configuration;

namespace Odon.Track.Application.Core.Injections.Extensions
{
    public static class InjectionsCoreExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<AppSettings>();
            services.AddScoped<AuthServices>();
            return services;
        }

        public static IServiceCollection AddContexts(this IServiceCollection services, AppSettings appSettings)
        {
            services.AddDbContext<OdontrackContext>(
                                    options =>
                                    {
                                        if (appSettings.ConnOdonTrack != null) options.UseMySQL(appSettings.ConnOdonTrack);
                                    });

            return services;
        }

        public static IServiceCollection AddCustomCors(this IServiceCollection services, AppSettings appSettings)
        {
            services.AddCors(setup =>
            {
                setup.AddPolicy("AllowOrigins", config =>
                {
                    string[] lstAllowOrigins = appSettings.AllowOrigins!.Split(",");
                    config.WithOrigins(lstAllowOrigins)
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });

            return services;
        }

        public static IServiceCollection AddCustomControllers(this IServiceCollection services)
        {
            services.AddControllers(config =>
            {
                config.Filters.Add(new ConsumesAttribute("application/json"));
                config.Filters.Add(new ProducesAttribute("application/json"));
            })
                    .AddJsonOptions(
                          config =>
                          {
                              config.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                          });

            return services;
        }

        public static IServiceCollection AddCommon(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddLogging();
            services.AddSingleton(configuration);
            return services;
        }
    }
}
