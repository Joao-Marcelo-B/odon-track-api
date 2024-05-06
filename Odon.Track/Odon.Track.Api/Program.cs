using Odon.Track.Application.Configuration;
using Odon.Track.Application.Core.Middleware;
using Odon.Track.Application.Core.Injections.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using Odon.Track.Application.Data.MySQL;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();

AppSettings appSettings = new AppSettings(configuration);

//services.AddCommon(configuration);  // Erro aqui
services.AddSingleton(configuration);
services.AddLogging();
services.AddServices();
Console.WriteLine($"#############ConnOdonTrack={appSettings.ConnOdonTrack}");
services.AddDbContext<OdontrackContext>(
                                    options =>
                                    {
                                        if (appSettings.ConnOdonTrack != null) options.UseMySQL(appSettings.ConnOdonTrack);
                                    });
//services.AddContexts(appSettings);
//services.AddCustomCors(appSettings);
services.AddCustomControllers();
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();
services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "OdonTrack API", Version = "v1" });
});
services.AddAuthorization();
services.AddAuthentication("Bearer").AddJwtBearer();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "OdonTrack API v1");
        c.RoutePrefix = string.Empty; // Define a rota para a raiz da aplica��o
    });
}

app.UseExceptionHandler(error => error.UseCustomError());
app.UseAuthorization();
app.MapControllers();
app.UseCors(x =>
            x.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod());
app.Run();
