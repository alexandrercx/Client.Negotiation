using Client.Negotiation.Application.ViewModel;

namespace Client.Negotiation.Application.Interfaces
{
    public interface IProductClientApp
    {
        AddProductClientOutputModel AddProductClient(AddProductClientInputModel productClientInputModel);
    }
}
