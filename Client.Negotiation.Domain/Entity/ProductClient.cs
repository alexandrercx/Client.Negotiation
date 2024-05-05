namespace Client.Negotiation.Domain.Entity
{
    public class ProductClient
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public int ProductId { get; set; }

        public decimal Amount { get; set; }

        public DateTime PurchaseDate { get; set; }
    }
}
