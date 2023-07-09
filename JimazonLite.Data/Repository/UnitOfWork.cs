using JimazonLite.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JimazonLite.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;
        public ICategoryRepository Category { get; private set; }

        public IProductRepository Product { get; private set; }
        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            Category = new CategoryRepository(dbContext);
            Product = new ProductRepository(dbContext);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
