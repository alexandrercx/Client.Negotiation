using Client.Negotiation.Domain.Entity;
using Client.Negotiation.Domain.Interface.Repository;
using Client.Negotiation.Domain.Interface.Service;

namespace Client.Negotiation.Domain.Service
{
    public class ProductClientService : IProductClientService
    {
        private readonly IProductClientRepository _productClientRepository;
        private readonly IFinancialProductRepository _financialProductRepository;
        private readonly IClientRepository _clientRepository;

        public ProductClientService(IProductClientRepository productClientRepository, IFinancialProductRepository financialProductRepository, IClientRepository clientRepository)
        {
            _productClientRepository = productClientRepository;
            _financialProductRepository = financialProductRepository;
            _clientRepository = clientRepository;
        }

        public ProductClient AddProductClient(ProductClient productClient)
        {
            //consumir get api através de endpoint
            if (_financialProductRepository.GetById(productClient.ProductId) == null)
            {
                throw new FormatException("Financial Product not found");
            }

            if (_clientRepository.GetById(productClient.ClientId) == null)
            {
                throw new FormatException("Client not found");
            }

            _productClientRepository.Add(productClient);
            _productClientRepository.SaveChanges();
            return productClient;
        }
    }
}
