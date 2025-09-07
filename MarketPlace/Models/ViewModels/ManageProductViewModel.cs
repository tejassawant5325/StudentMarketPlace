using MarketPlace.Common;

namespace MarketPlace.Models.ViewModels
{
    public class ManageProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; } = 0;
        public ProductStatus? Status { get; set; }
        public DateTime DatePosted { get; set; }
    }
}
