using Client.Negotiation.Infrastructure.DependencyInjection;

namespace Client.Negotiation.Configuration
{
    public static class DependencyInjectionSetup
    {
        public static void AddDependencyInjectionSetup(this IServiceCollection services, IConfiguration configuration)
        {
            DependencyInjection.RegisterServices(services,configuration);
        }
    }
}
