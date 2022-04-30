using ScopedService_in_SingletonObject.Interfaces;
using System;

namespace ScopedService_in_SingletonObject.Services
{
    public class TimeService
    {
        ITimeService _timeService;

        public TimeService(ITimeService timeService)
        {
            _timeService = timeService;
        }

        public string GetTime()
        {
            return _timeService.Time;
        }
    }
}
