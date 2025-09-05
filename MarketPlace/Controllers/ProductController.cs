using MarketPlace.Data.DataContext;
using MarketPlace.Data.Entities;
using MarketPlace.Models;
using MarketPlace.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace MarketPlace.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IWebHostEnvironment _environment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProductController(ApplicationDbContext dbContext, IWebHostEnvironment environment, UserManager<ApplicationUser> userManager)
        {
            _dbContext = dbContext;
            _environment = environment;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            // Get current logged-in user's Id (stored as string in claims)
            //var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Convert to Guid (assuming your AddedBy column is Guid)
            //Guid loggedInUserId = Guid.Parse(userIdString!);
            // Get current logged in user ID
            var userId = _userManager.GetUserId(User);
            // Fetch products where AddedBy is not the logged-in user
            var products = await _dbContext.Products
                                     .Where(p => p.AddedBy != userId)
                                     .ToListAsync();

            ViewData["Title"] = "Products";
            return View(products);
        }


        // New Details action
        public async Task<IActionResult> Details(int id)
        {
            var product = await _dbContext.Products.FirstOrDefaultAsync(p => p.Id == id);
            ViewData["Title"] = "Product Details";
            if (product == null)
            {
                return NotFound(); // returns 404 if product not found
            }

            return View(product); // passes product to view
        }


        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            string? uniquePhotoPath = ProcessFileUploads(model);

            // Get current logged in user ID
            var userId = _userManager.GetUserId(User);

            Product newProduct = new()
            {
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                ImageUrl = uniquePhotoPath,
                DatePosted = DateTime.Now,
                Status = model.Status,
                AddedBy = userId // <-- Assign logged-in user
            };

            _dbContext.Products.Add(newProduct);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> ManageProduct()
        {
            //var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);
            // Get current logged in user ID
            var userId = _userManager.GetUserId(User);
            // Convert to Guid (assuming your AddedBy column is Guid)
            //Guid loggedInUserId = Guid.Parse(userIdString!);

            // Fetch products where AddedBy is not the logged-in user
            var products = await _dbContext.Products
                                     .Where(p => p.AddedBy == userId)
                                     .ToListAsync();

            var userProductList = new List<ManageProductViewModel>();
            foreach (var product in products)
            {
                var userProduct = new ManageProductViewModel
                {
                    Id = product.Id,
                    Name = product.Name,
                    Status = product.Status,
                    Price = product.Price,
                    DatePosted = product.DatePosted,
                };
                userProductList.Add(userProduct);
            }

            ViewData["Title"] = "Manage My Products";
            return View(userProductList);
        }

        [HttpGet]
        public async Task<IActionResult> EditProduct(int id)
        {
            var product = await _dbContext.Products.FindAsync(id);
            if (product == null)
            {
                NotFound("Product Not Found");
            }
            ViewData["Title"] = "Edit Product";
            EditProductViewModel userProduct = new EditProductViewModel
            {
                Id = id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                ImageUrl = product.ImageUrl
            };

            return View(userProduct);
        }

        [HttpPost]
        public async Task<IActionResult> EditProduct(EditProductViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            // Get current logged in user ID
            var userId = _userManager.GetUserId(User);
            var existingProduct = await _dbContext.Products.FindAsync(model.Id);
            if (existingProduct != null)
            {
                if (model.Photo != null)
                {
                    if (model.ImageUrl != null)
                    {
                        string existingFilePath = Path.Combine(_environment.WebRootPath, "images", model.ImageUrl);
                        System.IO.File.Delete(existingFilePath);
                    }
                    existingProduct.ImageUrl = ProcessEditFileUploads(model);
                }
                existingProduct.Name = model.Name;
                existingProduct.Description = model.Description;
                existingProduct.Price = model.Price;
                existingProduct.ModifiedBy = userId;
                existingProduct.ModifiedDate = DateTime.Now;

                _dbContext.Products.Update(existingProduct);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                NotFound("Product Not Found");
            }

            return RedirectToAction("ManageProduct");
        }

        private string ProcessFileUploads(AddProductViewModel model)
        {
            string? uniquePhotoPath = null!;
            if (model.Photo != null)
            {
                string uploadFolder = Path.Combine(_environment.WebRootPath, "images");
                uniquePhotoPath = Guid.NewGuid() + model.Photo.FileName;
                string filePath = Path.Combine(uploadFolder, uniquePhotoPath);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Photo.CopyTo(fileStream);
                }
            }
            return uniquePhotoPath;
        }

        private string ProcessEditFileUploads(EditProductViewModel model)
        {
            string? uniquePhotoPath = null!;
            if (model.Photo != null)
            {
                string uploadFolder = Path.Combine(_environment.WebRootPath, "images");
                uniquePhotoPath = Guid.NewGuid() + model.Photo.FileName;
                string filePath = Path.Combine(uploadFolder, uniquePhotoPath);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Photo.CopyTo(fileStream);
                }
            }
            return uniquePhotoPath;
        }
        // Delete product
        [HttpPost]
        public async Task<IActionResult> Buy(PurchaseViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model); // re-display form with validation errors
            }

            var order = new Order
            {
                ProductId = model.ProductId,
                Name = model.Name,
                Email = model.Email,
                ContactNumber = model.ContactNumber,
                Address = model.Address,
                PurchaseDate = DateTime.Now
            };

            _dbContext.Orders.Add(order);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Confirmation"); // After successful purchase
        }
        public IActionResult Buy(int id)
        {
            var model = new PurchaseViewModel
            {
                ProductId = id
            };
            return View(model);
        }

    }
}
