namespace MarketPlace.Models.ViewModels
{
    public class MyOrdersViewModel
    {
        public string UserEmail { get; set; }
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public string PaymentStatus { get; set; }
        public decimal Price { get; set; }
        public DateTime OrderOn { get; set; }
        public string ImageUrl { get; set; }
    }
}
