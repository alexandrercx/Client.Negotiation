using Client.Negotiation.Domain.Entity;

namespace Client.Negotiation.Domain.Interface.Service
{
    public interface IProductClientService
    {
        ProductClient AddProductClient(ProductClient productClient);
    }
}
