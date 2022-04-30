using LifeTime.Interfaces;

namespace LifeTime.Services
{
    public class RandomCounter : ICounter
    {
        private static readonly Random _random = new Random();
        private int _value;

        public RandomCounter()
        {
            _value = _random.Next(0, 1000000);
        }

        public int Value => _value;
    }
}
