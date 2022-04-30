using System;
using System.Threading.Tasks;
using Using_Services_in_Middleware_Classes.Interfaces;

namespace Using_Services_in_Middleware_Classes.MIddlewares
{
    public class TimerMiddleware
    {
        ITimeService _timeService;
        RequestDelegate _next;

        public TimerMiddleware(RequestDelegate next, ITimeService timeService) // Use Singleton Service
        {
            _next = next;
            _timeService = timeService;
        }

        public async Task InvokeAsync(HttpContext context, ITimeService callServiceFromInvoke) // Use Scoped and Transient Service
        {
            if (context.Request.Path == "/time")
            {
                await context.Response.WriteAsync($"Call service from ctor: {_timeService.Time};" +
                    $" Call service from invoke: {callServiceFromInvoke.Time}");
            }
            else
            {
                await _next.Invoke(context);
            }
        }
    }
}
