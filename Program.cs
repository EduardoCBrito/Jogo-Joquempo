using Jogo_Joquempo.Interfaces;
using Jogo_Joquempo.Services;

var builder = Host.CreateApplicationBuilder(args);
var services = builder.Services;

services.Scan(scan => scan
    .FromAssemblyOf<ITipo>()
    .AddClasses(classes => classes.AssignableTo<ITipo>())
    .AsImplementedInterfaces()
    .WithTransientLifetime());

services.AddTransient<GameFactory>();

using var app = builder.Build();

using var scope = app.Services.CreateScope();
var jogo = scope.ServiceProvider.GetRequiredService<GameFactory>();

jogo.GameStart();
