using AutoMapper;
using Client.Negotiation.Application.ViewModel;
using Client.Negotiation.Domain.Entity;

namespace Client.Negotiation.Application.AutoMapper
{
    public class ViewModelToDomain : Profile
    {
        public ViewModelToDomain()
        {
            CreateMap<AddProductClientInputModel, ProductClient>();  
        }
    }
}
