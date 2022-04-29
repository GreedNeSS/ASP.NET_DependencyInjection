using System.Text;

var builder = WebApplication.CreateBuilder(args);
IServiceCollection services = builder.Services;
var app = builder.Build();

app.Run(async context =>
{
    StringBuilder sb = new StringBuilder();
    sb.Append("<h1>Все сервисы!</h1>");
    sb.Append("<table><tr><th>Тип</th><th>LifeTime</th><th>Реализация</th></tr>");

    foreach (var service in services)
    {
        sb.Append($"<tr><th>{service.ServiceType.Name}</th>");
        sb.Append($"<th>{service.Lifetime}</th>");
        sb.Append($"<th>{service.ImplementationType?.FullName}</th></tr>");
    }

    sb.Append("</tr></table>");

    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.WriteAsync(sb.ToString());
});

app.Run();
