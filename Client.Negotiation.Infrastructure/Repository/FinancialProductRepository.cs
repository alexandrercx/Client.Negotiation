using Client.Negotiation.Domain.Entity;
using Client.Negotiation.Domain.Interface.Repository;
using Microsoft.EntityFrameworkCore;

namespace Client.Negotiation.Infrastructure.Repository
{
    public class FinancialProductRepository : Repository<FinancialProduct>, IFinancialProductRepository
    {
        public FinancialProductRepository(Context.AppContext appContext) : base(appContext)
        {
                
        }

        public FinancialProduct Update(FinancialProduct financialProduct)
        {
            Db.FinancialProducts.Update(financialProduct);
            return financialProduct;
        }

        public FinancialProduct? GetById(int id)
        {
            return Db.FinancialProducts.FirstOrDefault(c => c.Id == id);
        }

        public void SaveChanges()
        {
            Db.SaveChanges();
        }




    }
}
