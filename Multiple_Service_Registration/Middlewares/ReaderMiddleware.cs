using Multiple_Service_Registration.Interfaces;
using System;
using System.Threading.Tasks;

namespace Multiple_Service_Registration.Middlewares
{
    public class ReaderMiddleware
    {
        RequestDelegate _next;
        IReader _reader;

        public ReaderMiddleware(RequestDelegate next, IReader reader)
        {
            _next = next;
            _reader = reader;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await context.Response.WriteAsync($"<h2>Current Value: {_reader.ReadValue()}</h2>");
            await _next(context);
        }
    }
}
