namespace MarketPlace.Models
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
    }
}