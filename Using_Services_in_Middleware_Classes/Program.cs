using Using_Services_in_Middleware_Classes.Interfaces;
using Using_Services_in_Middleware_Classes.Services;
using Using_Services_in_Middleware_Classes.MIddlewares;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<ITimeService, TimeService>();
var app = builder.Build();

app.UseMiddleware<TimerMiddleware>();
app.Run(async context =>
{
    await context.Response.WriteAsync("Main Page");
});
app.Run();
