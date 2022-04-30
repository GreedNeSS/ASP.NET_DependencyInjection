namespace GetService_Bad_
{
    public class ShortTimeService : ITimeService
    {
        public string GetTime()
        {
            return DateTime.Now.ToShortTimeString();
        }
    }
}
