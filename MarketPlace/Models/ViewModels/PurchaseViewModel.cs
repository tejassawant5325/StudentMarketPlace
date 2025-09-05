using System.ComponentModel.DataAnnotations;

namespace MarketPlace.Models.ViewModels
{
    public class PurchaseViewModel
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }

        public string ContactNumber { get; set; }

        public string Address { get; set; }
    }

}
