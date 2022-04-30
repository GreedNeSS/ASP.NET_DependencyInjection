using System;

namespace GetService_GoodVersion_
{
    public class TimeMessage
    {
        private ITimeService _timeService;

        public TimeMessage(ITimeService timeService)
        {
            _timeService = timeService;
        }

        public string GetTimeMessage()
        {
            return $"Time: {_timeService.GetTime()}";
        }
    }
}
