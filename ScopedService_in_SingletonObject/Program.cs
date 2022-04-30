using ScopedService_in_SingletonObject.MIddlewares;
using ScopedService_in_SingletonObject.Interfaces;
using ScopedService_in_SingletonObject.Services;

var builder = WebApplication.CreateBuilder(args);

// #1
//builder.Services.AddTransient<ITimeService, TimerServ>();
//builder.Services.AddScoped<TimeService>();

// #2
//builder.Services.AddScoped<ITimeService, TimerServ>();
//builder.Services.AddScoped<TimeService>();

// #3
//builder.Services.AddScoped<ITimeService, TimerServ>();
//builder.Services.AddTransient<TimeService>();

builder.Services.AddTransient<ITimeService, TimerServ>();
builder.Services.AddTransient<TimeService>();

var app = builder.Build();

app.UseMiddleware<TimerMiddleware>();

app.Run();
