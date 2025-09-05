namespace MarketPlace.Models.ViewModels
{
    public class AddProductViewModel
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; } = 0;
        public string Status { get; set; } = string.Empty;
        public IFormFile? Photo { get; set; }
    }
}
