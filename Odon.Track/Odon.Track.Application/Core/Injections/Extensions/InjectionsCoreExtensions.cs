using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Odon.Track.Application.Configuration;
using Odon.Track.Application.Data.MySQL;
using Odon.Track.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Configuration;
using Odon.Track.Application.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Odon.Track.Application.Core.Injections.Extensions
{
    public static class InjectionsCoreExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<AppSettings>();
            services.AddScoped<AuthServices>();
            services.AddScoped<ProfessoresServices>();
            services.AddScoped<EstudantesServices>();
            services.AddScoped<UsuariosServices>();
            services.AddScoped<RecoverPasswordServices>();
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

        public static IServiceCollection AddCustomAuthorization(this IServiceCollection services)
        {
            services.AddAuthorization();

            return services;
        }

        public static IServiceCollection AddCustomAuthentication(this IServiceCollection services, AppSettings appSettings)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                options.ExpireTimeSpan = TimeSpan.FromHours(10);
                options.LoginPath = "/auth";
            });
            services.AddAuthentication(auth =>
            {
                auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(appSettings.SharedKeyToken)),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            return services;
        }
    }
}
