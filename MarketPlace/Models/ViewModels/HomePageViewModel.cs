using MarketPlace.Data.Entities;

namespace MarketPlace.Models.ViewModels
{
    public class HomePageViewModel
    {
        public List<Product> RecentProducts { get; set; } = new List<Product>();
        public ContactUs ContactUs { get; set; }
    }
}
