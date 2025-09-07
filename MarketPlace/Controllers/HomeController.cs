using MarketPlace.Common;
using MarketPlace.Data.DataContext;
using MarketPlace.Data.Entities;
using MarketPlace.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MarketPlace.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);
            var recentProduct = await _dbContext.Products.Where(p => p.AddedBy != userId && p.Status != ProductStatus.Sold).OrderByDescending(x => x.AddedBy).Take(4).ToListAsync();
            HomePageViewModel homePageViewModel = new()
            {
                RecentProducts = recentProduct,
                ContactUs = new ContactUs()
            };
            return View(homePageViewModel);
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ContactUs(HomePageViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var contactUs = new ContactUs
            {
                Name = model.ContactUs.Name,
                Email = model.ContactUs.Email,
                Message = model.ContactUs.Message
            };
            _dbContext.ContactUs.Add(contactUs);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
