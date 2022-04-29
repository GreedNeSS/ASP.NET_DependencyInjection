using System;
namespace CreateServices
{
    public static class ServiceProviderExtensions
    {
        public static void AddLongTimeService(this IServiceCollection services)
        {
            services.AddTransient<LongTimeService>();
        }
    }
}
