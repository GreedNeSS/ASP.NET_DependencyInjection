using Using_Services_in_Middleware_Classes.Interfaces;

namespace Using_Services_in_Middleware_Classes.Services
{
    public class TimeService : ITimeService
    {
        public TimeService()
        {
            Time = DateTime.Now.ToLongTimeString();
        }
        public string Time
        {
            get;
        }
    }
}
