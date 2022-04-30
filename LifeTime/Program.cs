using LifeTime.Interfaces;
using LifeTime.Services;
using LifeTime.MIddlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<ICounter, RandomCounter>();
//builder.Services.AddScoped<ICounter, RandomCounter>();
//builder.Services.AddSingleton<ICounter, RandomCounter>();

builder.Services.AddTransient<CounterService>();
var app = builder.Build();

app.UseMiddleware<CounterMiddleware>();

app.Run();
