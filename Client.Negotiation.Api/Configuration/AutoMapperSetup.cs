using Client.Negotiation.Application.AutoMapper;

namespace Client.Negotiation.Configuration
{
    public static class AutoMapperSetup
    {

        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ViewModelToDomain), typeof(DomainToViewModel));
        }
    }
}
