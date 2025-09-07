using System.ComponentModel.DataAnnotations;

namespace MarketPlace.Models.ViewModels
{
    public class AddProductViewModel
    {
        [Required(ErrorMessage = "Enter Product Name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Enter Product Description")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Enter Product Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Enter Product Image")]
        public IFormFile? Photo { get; set; }
    }
}
