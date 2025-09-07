using MarketPlace.Common;
using MarketPlace.Data.DataContext;
using MarketPlace.Data.Entities;
using MarketPlace.Models;
using MarketPlace.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
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
            var userId = _userManager.GetUserId(User);
            // Fetch products where AddedBy is not the logged-in user
            var products = await _dbContext.Products
                                     .Where(p => p.AddedBy != userId && p.Status != ProductStatus.Sold)
                                     .ToListAsync();

            ViewData["Title"] = "Products";
            return View(products);
        }


        #region CHECKOUT METHODS
        //This section contains method which to display the checkout view and process checkout
        [HttpGet]
        public async Task<IActionResult> Checkout(int id)
        {
            var product = await _dbContext.Products.FirstOrDefaultAsync(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            ViewData["Title"] = "Checkout";
            ViewBag.Product = product;

            var model = new PurchaseViewModel
            {
                ProductId = id
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Checkout(PurchaseViewModel model)
        {
            var product = await _dbContext.Products.FirstOrDefaultAsync(p => p.Id == model.ProductId);
            if (product == null)
            {
                return NotFound();
            }

            product.Status = ProductStatus.Sold;
            _dbContext.Products.Update(product);

            if (!ModelState.IsValid)
            {
                ViewData["Title"] = "Checkout";
                ViewBag.Product = product;
                return View("Checkout", model);
            }

            var order = new Order
            {
                ProductId = product.Id,
                Name = model.Name,
                Email = model.Email,
                ContactNumber = model.ContactNumber,
                Address = model.Address,
                PurchaseDate = DateTime.Now,
                UserId = _userManager.GetUserId(User)
            };

            _dbContext.Orders.Add(order);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Payment", new { orderId = order.Id });
        }
        #endregion

        [HttpGet]
        public async Task<IActionResult> Payment(int orderId)
        {
            var order = await _dbContext.Orders.FirstOrDefaultAsync(o => o.Id == orderId);
            if (order == null)
            {
                return NotFound();
            }

            var product = await _dbContext.Products.FirstOrDefaultAsync(p => p.Id == order.ProductId);
            if (product == null)
            {
                return NotFound();
            }

            var upi = $"upi://pay?pa=nehasawant549@okicici&pn=MarketPlace&am={product.Price}&cu=INR";
            var qrUrl = $"https://api.qrserver.com/v1/create-qr-code/?size=220x220&data={Uri.EscapeDataString(upi)}";

            var vm = new PaymentViewModel
            {
                Order = order,
                Product = product,
                QrCodeUrl = qrUrl
            };

            ViewData["Title"] = "Payment";
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConfirmPayment(int orderId)
        {
            var orderDetails = await _dbContext.Orders.FindAsync(orderId);
            if (orderDetails != null)
            {
                orderDetails.IsPaid = true;
                orderDetails.PaidAt = DateTime.Now;

                _dbContext.Orders.Update(orderDetails);
                await _dbContext.SaveChangesAsync();
            }
            TempData["PaymentStatus"] = "Completed (Demo)";
            return RedirectToAction("Confirmation", new { orderId });
        }

        [HttpGet]
        public async Task<IActionResult> Confirmation(int orderId)
        {
            var order = await _dbContext.Orders.FirstOrDefaultAsync(o => o.Id == orderId);
            if (order == null)
            {
                return NotFound();
            }

            var product = await _dbContext.Products.FirstOrDefaultAsync(p => p.Id == order.ProductId);
            if (product == null)
            {
                return NotFound();
            }

            var vm = new PaymentViewModel
            {
                Order = order,
                Product = product,
                QrCodeUrl = string.Empty
            };

            ViewData["Title"] = "Order Confirmation";
            return View(vm);
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

                if (ModelState.ContainsKey("Price"))
                {
                    ModelState["Price"].Errors.Clear(); // remove existing errors
                    ModelState["Price"].Errors.Add("Enter Product Price"); // add new error message
                }
                return View(model);
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
                Status = ProductStatus.Available,
                AddedBy = userId // <-- Assign logged-in user
            };

            _dbContext.Products.Add(newProduct);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> ManageProduct()
        {
            // Get current logged in user ID
            var userId = _userManager.GetUserId(User);
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


        [HttpGet]
        public async Task<IActionResult> MyOrders()
        {
            var userId = _userManager.GetUserId(User);
            //var userOrders = await _dbContext.Orders.Where(x => x.UserId == userId).ToListAsync();
            var userOrders = await (from o in _dbContext.Orders
                                    join u in _dbContext.Users on o.UserId equals u.Id
                                    join p in _dbContext.Products on o.ProductId equals p.Id
                                    where o.UserId == userId
                                    select new
                                    {
                                        OrderId = o.Id,
                                        UserName = u.Email,
                                        ProductName = p.Name,
                                        Price = p.Price,
                                        OrderDate = o.PurchaseDate,
                                        IsPaid = o.IsPaid ? "Paid" : "Pending",
                                        ImageUrl = p.ImageUrl
                                    }).ToListAsync();

            var myOrdersList = new List<MyOrdersViewModel>();
            foreach (var order in userOrders)
            {
                var myOrder = new MyOrdersViewModel
                {
                    ProductName = order.ProductName,
                    PaymentStatus = order.IsPaid,
                    OrderOn = order.OrderDate,
                    Price = order.Price,
                    OrderId = order.OrderId,
                    UserEmail = order.UserName,
                    ImageUrl = order.ImageUrl
                };
                myOrdersList.Add(myOrder);
            }
            return View(myOrdersList);
        }

        public async Task<IActionResult> CancelOrder(int orderId)
        {
            if (orderId > 0)
            {
                var userOrders = await _dbContext.Orders.FindAsync(orderId);
                if (userOrders != null)
                {
                    var product = await _dbContext.Products.FindAsync(userOrders.ProductId);
                    if (product != null)
                    {
                        product.Status = ProductStatus.Available;
                        _dbContext.Products.Update(product);
                    }


                    _dbContext.Orders.Remove(userOrders);
                    await _dbContext.SaveChangesAsync();
                }
                else
                {
                    return NotFound("Order Not Found");
                }
                return RedirectToAction("Index", "Product");
            }
            return BadRequest("Invalid Order Id");
        }
    }
}
