using MarketPlace.Common;

namespace MarketPlace.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; } = 0;
        public string ImageUrl { get; set; } = string.Empty;
        public ProductStatus? Status { get; set; }
        public DateTime DatePosted { get; set; }
        public int Category { get; set; }
        public string? AddedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        // For digital product file
        public string? DigitalFilePath { get; set; } // keep this


    }
}
