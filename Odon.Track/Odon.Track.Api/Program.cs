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
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "OdonTrack API", Version = "v1" });

    var securityScheme = new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Insira o token JWT no formato: Bearer {seu token}"
    };

    c.AddSecurityDefinition("Bearer", securityScheme);

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            securityScheme,
            new string[] {}
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
    c.DisplayRequestDuration();
    c.DocExpansion(Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.None);
    c.DefaultModelsExpandDepth(-1);
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
