using Multiple_Service_Registration.Interfaces;

namespace Multiple_Service_Registration.Services
{
    public class ValueStorage : IGenerator, IReader
    {
        int value;

        public int GenerateValue()
        {
            value = new Random().Next();
            return value;
        }

        public int ReadValue() => value;
    }
}
