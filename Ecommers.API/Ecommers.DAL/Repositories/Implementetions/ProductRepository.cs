using Ecommers.DAL.Contexts;
using Ecommers.DAL.Entities;
using Ecommers.DAL.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommers.DAL.Repositories.Implementetions
{
    public class ProductRepository:GenericRepository<Product>,IProductRepository
    {
        public ProductRepository(EcommerseDbContext context):base(context)
        {
            
        }
    }
}
