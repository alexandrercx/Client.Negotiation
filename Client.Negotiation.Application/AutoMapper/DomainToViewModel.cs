using AutoMapper;
using Client.Negotiation.Application.ViewModel;
using Client.Negotiation.Domain.Entity;

namespace Client.Negotiation.Application.AutoMapper
{
    public class DomainToViewModel : Profile
    {
        public DomainToViewModel()
        {
            CreateMap<FinancialProduct, FinancialProductOutputModel>();
            CreateMap<FinancialProduct, GetFinancialProductOutputModel>();
            CreateMap<ProductClient, AddProductClientOutputModel>();


        }
    }
}
