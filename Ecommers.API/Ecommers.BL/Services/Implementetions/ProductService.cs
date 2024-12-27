using AutoMapper;
using Ecommers.BL.Dtos;
using Ecommers.BL.Services.Abstractions;
using Ecommers.DAL.Contexts;
using Ecommers.DAL.Entities;
using Ecommers.DAL.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommers.BL.Services.Implementetions
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;

        }
        public async Task<Product> CreateProductAsync(ProductCreateDto productCreateDto)
        {
            Product product=_mapper.Map<Product>(productCreateDto);
            product.CreatedDate= DateTime.Now;
            var createdProduct= await _repo.CreateAsync(product);
            await _repo.SaveChangesAsync();
            return createdProduct;  
            
        }

        public async Task<IEnumerable<Product>> GetAllProductAsync()
        {
          return await _repo.GetAllAsync();
        }

        public async Task<Product> GetOneProductAsync(int id)
        {
            return await _repo.GetOneEntityIdAsync(id);
        }

        public async Task<bool> HardDeleteAsnyc(int id)
        {
            var product = await _repo.GetOneEntityIdAsync(id);
            _repo.HardDelete(product);
            await _repo.SaveChangesAsync();
            return true;
        }

        public async Task<bool> SoftDeleteAsync(int id)
        {
           var product= await _repo.GetOneEntityIdAsync(id);
            _repo.SoftDelete(product);
            await _repo.SaveChangesAsync();
            return true; 
        }

        public async Task<bool> UpdateProductAsync(int id, ProductCreateDto productCreateDto)
        {
            var entityproduct = await _repo.GetOneEntityIdAsync(id);
            Product product = _mapper.Map<Product>(productCreateDto);
            product.CreatedDate = DateTime.Now;
            _repo.Update(product);
            await _repo.SaveChangesAsync();
            return true;
            

        }
    }
}
