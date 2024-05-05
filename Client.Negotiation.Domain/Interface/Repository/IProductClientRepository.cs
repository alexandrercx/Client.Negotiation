using Client.Negotiation.Domain.Entity;

namespace Client.Negotiation.Domain.Interface.Repository
{
    public interface IProductClientRepository : IDisposable
    {
        ProductClient Add(ProductClient productClient);

        void SaveChanges();
    }
}
