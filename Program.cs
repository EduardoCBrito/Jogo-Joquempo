using Jogo_Joquempo.Interfaces;
using Jogo_Joquempo.Services;

// Criação do host (para habilitar DI em console)
var builder = Host.CreateApplicationBuilder(args);
var services = builder.Services;

// Registro automático de todos os tipos que implementam ITipo
services.Scan(scan => scan
    .FromAssemblyOf<ITipo>()
    .AddClasses(classes => classes.AssignableTo<ITipo>())
    .AsImplementedInterfaces()
    .WithTransientLifetime());

// Registro da factory
services.AddTransient<GameFactory>();

// Constrói o host
using var app = builder.Build();

// Resolve a Factory e inicia o jogo
using var scope = app.Services.CreateScope();
var jogo = scope.ServiceProvider.GetRequiredService<GameFactory>();

jogo.GameStart();
