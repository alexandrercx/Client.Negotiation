using Client.Negotiation.Domain.Entity;

namespace Client.Negotiation.Domain.Interface.Repository
{
    public interface IFinancialProductRepository : IDisposable
    {    
        FinancialProduct Update(FinancialProduct financialProduct);
        FinancialProduct? GetById(int id);
        void SaveChanges();
    }
}
