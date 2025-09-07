using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MarketPlace.Models.ViewModels
{
    public class PurchaseViewModel
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string? Email { get; set; }

        [DisplayName("Contact Number")]
        [Required(ErrorMessage = "Contact is required")]
        public string? ContactNumber { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string? Address { get; set; }
    }
}
