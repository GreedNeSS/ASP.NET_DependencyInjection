using LifeTime.Interfaces;
using LifeTime.Services;
using System;
using System.Threading.Tasks;

namespace LifeTime.MIddlewares
{
    public class CounterMiddleware
    {
        private RequestDelegate _next;
        private int i = 0;

        public CounterMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, ICounter counter, CounterService counterService)
        {
            i++;
            context.Response.ContentType = "text/html; charset=utf-8";
            await context.Response.WriteAsync($"<h1>Запрос #{i}; Counter: {counter.Value}; Service: {counterService.Counter.Value}</h1>");
        }
    }
}
