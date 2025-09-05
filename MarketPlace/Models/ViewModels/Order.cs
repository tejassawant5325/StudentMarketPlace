using System.ComponentModel.DataAnnotations;

namespace MarketPlace.Models.ViewModels
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public required string UserId { get; set; } // From logged-in user

        [Required]
        public int Quantity { get; set; }

        [Required, StringLength(15)]
        public required string ContactNumber { get; set; }

        [Required]
        public required string PaymentMethod { get; set; } // e.g. Cash on Delivery / UPI

        public DateTime PurchaseDate { get; set; }
    }
}

