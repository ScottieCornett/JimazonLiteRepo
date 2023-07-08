using JimazonLite.Data;
using JimazonLite.Models;
using Microsoft.AspNetCore.Mvc;

namespace JimazonLite.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public ProductController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<Product> products = _dbContext.Products.ToList();
            return View(products);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (product == null)
            {
                return NotFound();
            }

            if (product.Name.Length < 3)
            {
                ModelState.AddModelError("Name", "The product name must be at least 3 characters long");
            }

            if (ModelState.IsValid)
            {
                _dbContext.Products.Add(product);
                _dbContext.SaveChanges();
                TempData["success"] = "Product successfully created";
                return RedirectToAction("Index");
            }

            return View(product);
        }
        [HttpGet] 
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Product? product = _dbContext.Products.FirstOrDefault(u => u.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
        [HttpPost] 
        public IActionResult Update(Product product)
        {
            if (product == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _dbContext.Products.Update(product);
                _dbContext.SaveChanges();
                TempData["success"] = "Product successfully updated";
                return RedirectToAction("Index");
            }
            return View(product);

        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Product? product = _dbContext.Products.FirstOrDefault(u => u.Id == id);

            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteProduct(int? id)
        {
      
            Product product = _dbContext.Products.FirstOrDefault(u => u.Id == id);

            if (product == null)
            {
                return NotFound();
            }
            
             _dbContext.Products.Remove(product);
             _dbContext.SaveChanges();
            TempData["success"] = "Product successfully deleted";
            return RedirectToAction("Index");

            
        }
    }
}
