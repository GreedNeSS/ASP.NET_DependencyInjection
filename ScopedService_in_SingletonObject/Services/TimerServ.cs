using ScopedService_in_SingletonObject.Interfaces;

namespace ScopedService_in_SingletonObject.Services
{
    public class TimerServ : ITimeService
    {
        public TimerServ()
        {
            Time = DateTime.Now.ToLongTimeString();
        }
        public string Time
        {
            get;
        }
    }
}
