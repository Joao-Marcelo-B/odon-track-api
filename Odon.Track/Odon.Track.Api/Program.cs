using Odon.Track.Application.Configuration;
using Odon.Track.Application.Core.Middleware;
using Odon.Track.Application.Core.Injections.Extensions;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;


var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();

AppSettings appSettings = new AppSettings(configuration);

services.AddLogging();
services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});
services.AddServices();
services.AddContexts(appSettings);
services.AddCustomControllers();
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();
services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "OdonTrack API", Version = "v1" });

    // Configuração para autenticação Bearer
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Scheme = "Bearer",
        BearerFormat = "JWT", // ou qualquer outro formato do seu token
        Type = SecuritySchemeType.ApiKey,
        Description = "Insira o token JWT de acesso"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] { }
        }
    });
});

services.AddCustomAuthorization();
services.AddCustomAuthentication(appSettings);

var app = builder.Build();

//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI(c =>
{
c.SwaggerEndpoint("/swagger/v1/swagger.json", "OdonTrack API v1");
c.RoutePrefix = "swagger";
c.ConfigObject.DisplayRequestDuration = true;
c.ConfigObject.DocExpansion = Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.None;
c.ConfigObject.DefaultModelsExpandDepth = -1;

// Habilitar a opção para passar o token Bearer diretamente no Swagger UI
c.ConfigObject.Authorization = new OpenApiOAuthFlow
{
AuthorizationUrl = new Uri("https://seu-servidor-de-autorizacao.com"),
TokenUrl = new Uri("https://seu-servidor-de-token.com")
};
});
//}
app.UseRouting();
app.UseExceptionHandler(error => error.UseCustomError());
app.UseAuthentication();
app.UseCookiePolicy();
app.UseAuthorization();
app.MapControllers();
app.UseCors(x =>
            x.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod());
app.Run();
