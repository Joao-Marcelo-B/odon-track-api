using Odon.Track.Application.Configuration;
using Odon.Track.Application.Core.Middleware;
using Odon.Track.Application.Core.Injections.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;    
IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();

AppSettings appSettings = new AppSettings(configuration);

services.AddScoped<AppSettings>();
services.AddServices();
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();
services.AddLogging();

services.AddControllers( config =>
                          {
                              config.Filters.Add(new ConsumesAttribute("application/json"));
                              config.Filters.Add(new ProducesAttribute("application/json"));
                          })
                    .AddJsonOptions(
                          config =>
                          {
                              config.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                          });

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

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionHandler(error => error.UseCustomError());
app.UseAuthorization();
app.MapControllers();
app.UseCors("AllowOrigins");
app.Run();
