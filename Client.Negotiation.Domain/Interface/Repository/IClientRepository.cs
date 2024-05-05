namespace Client.Negotiation.Domain.Interface.Repository
{
    public interface IClientRepository : IDisposable
    {
        Entity.Client? GetById(int id);
    }
}
