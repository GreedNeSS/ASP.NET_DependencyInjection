using LifeTime.Interfaces;

namespace LifeTime.Services
{
    public class CounterService
    {
        public ICounter Counter { get; }

        public CounterService(ICounter counter)
        {
            Counter = counter;
        }
    }
}
