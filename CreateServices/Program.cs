using CreateServices;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<ITimeService, ShortTimeService>();
builder.Services.AddLongTimeService();
var app = builder.Build();

app.MapGet("/", () => app.Services.GetService<ITimeService>()?.GetTime());
app.MapGet("/long", () => app.Services.GetService<LongTimeService>()?.GetTime());

app.Run();
