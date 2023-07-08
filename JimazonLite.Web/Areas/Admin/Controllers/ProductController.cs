using JimazonLite.Data;
using JimazonLite.Data.Repository.IRepository;
using JimazonLite.Models;
using Microsoft.AspNetCore.Mvc;

namespace JimazonLite.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<Product> products = _productRepository.GetAll().ToList();
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
                _productRepository.Add(product);
                _productRepository.Save();
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

            Product? product = _productRepository.Get(u => u.Id == id);

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
                _productRepository.Update(product);
                _productRepository.Save();
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

            Product? product = _productRepository.Get(u => u.Id == id);

            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteProduct(int? id)
        {

            Product product = _productRepository.Get(u => u.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            _productRepository.Remove(product);
            _productRepository.Save();
            TempData["success"] = "Product successfully deleted";
            return RedirectToAction("Index");


        }
    }
}
