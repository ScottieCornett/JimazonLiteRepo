﻿using JimazonLite.Data;
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
        public IActionResult Index()
        {
            List<Product> Products = _dbContext.Products.ToList();
            return View();
        }
    }
}