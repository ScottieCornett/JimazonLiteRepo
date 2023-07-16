using JimazonLite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JimazonLite.Data.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        // This is an example of the Interface Segregation Principle from SOLID
        // As updating a product may be different than updating than a category,
        // a more specific update method is used so no code is forced to depend
        // on methods it does not use.
        void Update(Product product);
                
    }
}
