using Ecommers.BL.Dtos;
using Ecommers.DAL.Entities;
using Ecommers.DAL.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommers.BL.Services.Abstractions
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductAsync();
        Task<Product> GetOneProductAsync(int id);
        Task<Product> CreateProductAsync(ProductCreateDto productCreateDto);
        Task<bool> UpdateProductAsync(int id, ProductCreateDto productCreateDto);
        Task<bool> SoftDeleteAsync(int id);
        Task<bool> HardDeleteAsnyc(int id);


    }
}
