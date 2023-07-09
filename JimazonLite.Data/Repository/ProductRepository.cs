using JimazonLite.Data.Repository.IRepository;
using JimazonLite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JimazonLite.Data.Repository
{
    public class ProductRepository : Repository<Product> ,IProductRepository
    {
        private ApplicationDbContext _dbContext;
        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    
        public void Update(Product product)
        {
            var productFromDb = _dbContext.Products.FirstOrDefault(u => u.Id == product.Id);
            if(productFromDb != null)
            {
                productFromDb.Name = product.Name;
                productFromDb.Description = product.Description;
                productFromDb.Price = product.Price;
                productFromDb.ModelNumber = product.ModelNumber;
                productFromDb.Quantity = product.Quantity;
                productFromDb.DateAdded = product.DateAdded;
                productFromDb.CategoryId = product.CategoryId;
                if (product.ImageUrl != null)
                {
                    productFromDb.ImageUrl = product.ImageUrl;
                }
            }
        }
    }
}
