using System;
using System.Threading.Tasks;

namespace GetService_GoodVersion_
{
    public class TimeMessageMiddleware
    {
        private RequestDelegate _next;

        public TimeMessageMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, ITimeService timeService)
        {
            context.Response.ContentType = "text/html; charset=utf-8";
            await context.Response.WriteAsync($"<h1>Time: {timeService?.GetTime()}</h1>");
            await _next.Invoke(context);
        }
    }
}
