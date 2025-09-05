using MarketPlace.Data.DataContext;
using Microsoft.AspNetCore.Mvc;
using MarketPlace.Data.Entities; // for Product entity
using Microsoft.EntityFrameworkCore; // for async queries

namespace MarketPlace.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public OrderController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: /Order/OrderForm/5
        public IActionResult OrderForm(int id)
        {
            var product = _dbContext.Products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product); // shows order form
        }

        // POST: /Order/OrderForm
        [HttpPost]
        public async Task<IActionResult> OrderForm(int id, int quantity)
        {
            var product = await _dbContext.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            if (product.Status != "Available")
            {
                // Show error message back in form
                ModelState.AddModelError("", "This product is no longer available.");
                return View(product);
            }

            // 🔹 Later you will add purchase/order save logic here
            // For now just simulate success
            TempData["SuccessMessage"] = $"Order placed for {quantity} x {product.Name}";

            return RedirectToAction("Index", "Product");
        }
    }
}
