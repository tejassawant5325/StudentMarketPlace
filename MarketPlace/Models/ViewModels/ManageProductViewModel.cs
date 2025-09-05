namespace MarketPlace.Models.ViewModels
{
    public class ManageProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; } = 0;
        public string Status { get; set; } = string.Empty;
        public DateTime DatePosted { get; set; }
    }
}
