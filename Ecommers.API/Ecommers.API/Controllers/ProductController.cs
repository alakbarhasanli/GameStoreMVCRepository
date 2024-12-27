using Ecommers.BL.Dtos;
using Ecommers.BL.Services.Abstractions;
using Ecommers.DAL.Contexts;
using Ecommers.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
            
        }
        [HttpGet("AllProduct")]
        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _service.GetAllProductAsync();
        }
        [HttpGet("OneProduct")]
        public async Task<Product> GetOneProduct(int id)
        {
            return await _service.GetOneProductAsync(id);
        }
        [HttpPost("CreateProduct")]
        public async Task<IActionResult> CreateProduct(ProductCreateDto productCreateDto)
        { 
            if (!ModelState.IsValid)
            {
                return StatusCode(StatusCodes.Status404NotFound,ModelState);
            }
            return StatusCode(StatusCodes.Status201Created, await _service.CreateProductAsync(productCreateDto));
        }
        [HttpDelete("SoftDelete")]
        public async Task<IActionResult> SoftDelete( int id)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(StatusCodes.Status404NotFound, ModelState);
            }
            return StatusCode(StatusCodes.Status200OK, await _service.SoftDeleteAsync(id));
        }
        [HttpDelete("Hardelete")]
        public async Task<IActionResult> HardDelete(int id)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(StatusCodes.Status404NotFound, ModelState);
            }
            return StatusCode(StatusCodes.Status200OK, await _service.HardDeleteAsnyc(id));
        }
        [HttpPut("UpdateProduct/{id}")]
        public async Task<IActionResult> UpdateProduct(int id,ProductCreateDto productCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(StatusCodes.Status404NotFound, ModelState);
            }
            return StatusCode(StatusCodes.Status200OK, await _service.UpdateProductAsync(id,productCreateDto));
        }

    }
}
