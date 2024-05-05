namespace Client.Negotiation.Application.ViewModel
{
    public class AddProductClientInputModel
    {
        public int ProductId { get; set; }
        public int ClientId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
