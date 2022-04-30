using Multiple_Service_Registration.Interfaces;
using System;
using System.Threading.Tasks;

namespace Multiple_Service_Registration.Middlewares
{
    public class GeneratorMiddleware
    {
        RequestDelegate _next;
        IGenerator _generator;

        public GeneratorMiddleware(RequestDelegate next, IGenerator generator)
        {
            _next = next;
            _generator = generator;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            context.Response.ContentType = "text/html;charset=utf-8";

            if (context.Request.Path == "/generate")
            {
                await context.Response.WriteAsync($"<h1>New Value: {_generator.GenerateValue()}</h1>");
            }
            else
            {
                await _next(context);
            }
        }
    }
}
