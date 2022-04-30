using Multiple_Service_Registration.Interfaces;
using Multiple_Service_Registration.Services;
using Multiple_Service_Registration.Middlewares;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IHelloService, RuHelloService>();
builder.Services.AddTransient<IHelloService, EnHelloService>();

// Реализация одна, а обьекты разные
//builder.Services.AddSingleton<IGenerator, ValueStorage>();
//builder.Services.AddSingleton<IReader, ValueStorage>();

// Реализация одна обьект один
//ValueStorage valueStorage = new ValueStorage();
//builder.Services.AddSingleton<IGenerator>(_ => valueStorage);
//builder.Services.AddSingleton<IReader>(_ => valueStorage);

// Реализация одна обьект один
builder.Services.AddSingleton<ValueStorage>();
builder.Services.AddSingleton<IGenerator>(servises => servises.GetRequiredService<ValueStorage>());
builder.Services.AddSingleton<IReader>(servises => servises.GetRequiredService<ValueStorage>());

var app = builder.Build();

app.UseMiddleware<GeneratorMiddleware>();
app.UseMiddleware<ReaderMiddleware>();
app.UseMiddleware<HelloMiddleware>();

app.Run();
