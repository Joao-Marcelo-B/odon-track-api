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
services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo()
    {
        Title = "Catalogo API",
        Version = "v1",
        Description = "Catalogo de Produtos e Categorias",
        TermsOfService = new Uri("https://google.com"),
        Contact = new OpenApiContact()
        {
            Name = "Joao Marcelo",
            Email = "joaomarcelobn157@hotmail.com",
            Url = new Uri("https://google.com")
        },
        License = new OpenApiLicense()
        {
            Name = "License",
            Url = new Uri("https://google.com")
        }
    });

    var xmlFileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFileName));

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Bearer JWT"
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
    app.UseSwaggerUI();
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
