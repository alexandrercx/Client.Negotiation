using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Client.Negotiation.Application.Interfaces;
using Client.Negotiation.Application.Services;
using Client.Negotiation.Domain.Interface.Repository;
using Client.Negotiation.Domain.Interface.Service;
using Client.Negotiation.Domain.Service;
using Client.Negotiation.Infrastructure.Repository;

namespace Client.Negotiation.Infrastructure.DependencyInjection
{
    public static class DependencyInjection
    {
        public static void RegisterServices(IServiceCollection service, IConfiguration configuration)
        {
            //Application
            service.AddScoped<IProductClientApp, ProductClientApp>();

            //Domain
            service.AddScoped<IProductClientService, ProductClientService>();

            //Repository
            service.AddScoped<IProductClientRepository, ProductClientRepository>();
            service.AddScoped<IClientRepository, ClientRepository>();
            service.AddScoped<IFinancialProductRepository, FinancialProductRepository>();

        }
    }
}
