using System;
using System.Threading.Tasks;
using ScopedService_in_SingletonObject.Services;

namespace ScopedService_in_SingletonObject.MIddlewares
{
    public class TimerMiddleware
    {
        TimeService _timeService;

        public TimerMiddleware(RequestDelegate next, TimeService timeService)
        {
            _timeService = timeService;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await context.Response.WriteAsync($"Time: {_timeService.GetTime()}");
        }
    }
}
