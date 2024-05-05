using AutoMapper;
using Client.Negotiation.Application.Interfaces;
using Client.Negotiation.Application.ViewModel;
using Client.Negotiation.Domain.Entity;
using Client.Negotiation.Domain.Interface.Service;

namespace Client.Negotiation.Application.Services
{
    public class ProductClientApp : IProductClientApp
    {
        private readonly IProductClientService _productClientService;
        private readonly IMapper _mapper;
        public ProductClientApp(IMapper mapper, IProductClientService productClientService)
        {
            _mapper = mapper;
            _productClientService = productClientService;
        }

        public AddProductClientOutputModel AddProductClient(AddProductClientInputModel productClientInputModel)
        {
            var pc = _mapper.Map<ProductClient>(productClientInputModel);
            _productClientService.AddProductClient(pc);
            AddProductClientOutputModel pcmodel = _mapper.Map<AddProductClientOutputModel>(pc);
            return pcmodel;
        }

      
    }
}
