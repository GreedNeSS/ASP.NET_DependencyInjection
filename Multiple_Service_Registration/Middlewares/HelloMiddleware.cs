using Multiple_Service_Registration.Interfaces;
using System;
using System.Threading.Tasks;

namespace Multiple_Service_Registration.Middlewares
{
    public class HelloMiddleware
    {
        IEnumerable<IHelloService> _helloServices;
        public HelloMiddleware(RequestDelegate _, IEnumerable<IHelloService> helloServices)
        {
            _helloServices = helloServices;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            string response = String.Empty;

            foreach (var helloservice in _helloServices)
            {
                response += $"<h3>{helloservice.Message}</h3>";
            }

            await context.Response.WriteAsync(response);
        }
    }
}
