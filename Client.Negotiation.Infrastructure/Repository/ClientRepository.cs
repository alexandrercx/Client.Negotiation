using Client.Negotiation.Domain.Interface.Repository;
using Microsoft.EntityFrameworkCore;

namespace Client.Negotiation.Infrastructure.Repository
{
    public class ClientRepository : Repository<Domain.Entity.Client>, IClientRepository
    {
        public ClientRepository(Context.AppContext appContext) : base(appContext)
        {

        }
        public Domain.Entity.Client Add(Domain.Entity.Client client)
        {
            Db.Client.Add(client);
            return client;
        }

        public Domain.Entity.Client? GetById(int id)
        {
            return Db.Client.AsNoTracking().FirstOrDefault(c => c.Id == id);
        }
    }
}
