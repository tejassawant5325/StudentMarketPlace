namespace MarketPlace.Data.Entities
{
    public class Order
    {
        public int Id { get; set; } // Primary key
        public int ProductId { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string ContactNumber { get; set; }
        public required string Address { get; set; }
        public DateTime PurchaseDate { get; set; } = DateTime.Now;
        public bool IsPaid { get; set; }
        public DateTime PaidAt { get; set; }
        public string? UserId { get; set; }
    }
}