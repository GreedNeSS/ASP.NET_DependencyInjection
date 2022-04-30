using GetService_Bad_;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<ITimeService, ShortTimeService>();
var app = builder.Build();

app.Run(async context =>
{
    //var timeService = app.Services.GetService<ITimeService>();
    //var timeService = context.RequestServices.GetService<ITimeService>();
    var timeService = app.Services.GetRequiredService<ITimeService>();

    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.WriteAsync($"<h2>Time: {timeService?.GetTime()}</h2>");
});

app.Run();