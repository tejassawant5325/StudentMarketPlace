using MarketPlace.Data.Entities;

namespace MarketPlace.Models.ViewModels
{
    public class PaymentViewModel
    {
        public required Order Order { get; set; }
        public required Product Product { get; set; }
        public string QrCodeUrl { get; set; } = string.Empty;
    }
}
