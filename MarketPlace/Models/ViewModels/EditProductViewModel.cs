using System.ComponentModel.DataAnnotations;

namespace MarketPlace.Models.ViewModels
{
    public class EditProductViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; } = 0;
        public string ImageUrl { get; set; } = string.Empty;

        [Required(ErrorMessage = "Image is required")]
        public IFormFile? Photo { get; set; }
    }
}
