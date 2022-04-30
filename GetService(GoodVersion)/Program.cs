using GetService_GoodVersion_;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<ITimeService, ShortTimeService>();
builder.Services.AddTransient<TimeMessage>();
var app = builder.Build();

app.UseMiddleware<TimeMessageMiddleware>();

app.Run(async context =>
{
    var timeService = context.RequestServices.GetService<TimeMessage>();
    await context.Response.WriteAsync($"<h2>{timeService?.GetTimeMessage()}</h2>");
});

app.Run();
