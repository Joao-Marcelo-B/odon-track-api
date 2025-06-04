using System.Reflection;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Odon.Track.Application.Configuration;
using Odon.Track.Application.Core.Injections.Extensions;
using Odon.Track.Application.Core.Middleware;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

// Carregar configura��o a partir do arquivo appsettings.json
var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .Build();

var appSettings = new AppSettings(configuration);

// Configura��o b�sica de servi�os
services.AddLogging();

services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

services.AddServices();
services.AddContexts(appSettings);
services.AddCustomControllers();
services.AddEndpointsApiExplorer();

// Configura��o do Swagger
services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Cat�logo API",
        Version = "v1",
        Description = "Cat�logo de Produtos e Categorias",
        TermsOfService = new Uri("https://google.com"),
        Contact = new OpenApiContact
        {
            Name = "Joao Marcelo",
            Email = "joaomarcelobn157@hotmail.com",
            Url = new Uri("https://google.com")
        },
        License = new OpenApiLicense
        {
            Name = "License",
            Url = new Uri("https://google.com")
        }
    });

    // Coment�rios XML
    var xmlFileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlFilePath = Path.Combine(AppContext.BaseDirectory, xmlFileName);
    c.IncludeXmlComments(xmlFilePath);

    // Seguran�a JWT
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
            Array.Empty<string>()
        }
    });
});

// Autentica��o e Autoriza��o
services.AddCustomAuthorization();
services.AddCustomAuthentication(appSettings);

var app = builder.Build();

// Middlewares e Pipeline
app.UseSwagger();
app.UseSwaggerUI();

app.UseRouting();

app.UseExceptionHandler(error => error.UseCustomError());

app.UseAuthentication();
app.UseCookiePolicy();
app.UseAuthorization();

app.UseCors(policy =>
    policy.AllowAnyOrigin()
          .AllowAnyHeader()
          .AllowAnyMethod()
);

app.MapControllers();

app.Run();
