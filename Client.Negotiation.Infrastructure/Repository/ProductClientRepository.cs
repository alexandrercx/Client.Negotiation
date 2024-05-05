using Client.Negotiation.Domain.Entity;
using Client.Negotiation.Domain.Interface.Repository;

namespace Client.Negotiation.Infrastructure.Repository
{
    public class ProductClientRepository : Repository<ProductClient>, IProductClientRepository
    {
        public ProductClientRepository(Context.AppContext appContext) : base(appContext)
        {

        }

        public ProductClient Add(ProductClient productClient)
        {
            Db.ProductClient.Add(productClient);
            return productClient;
        }

        public void SaveChanges()
        {
            Db.SaveChanges();
        }

    }
}
