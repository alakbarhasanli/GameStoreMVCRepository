using Ecommers.BL.Dtos;
using Ecommers.BL.Services.Abstractions;
using Ecommers.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _service;

        public OrderController(IOrderService service)
        {
            _service = service;

        }
        [HttpGet("AllOrder")]
        public async Task<IEnumerable<Order>> GetAll()
        {
            return await _service.GetAllorderAsync();
        }
        [HttpGet("OneOrder")]
        public async Task<Order> GetOneOrder(int id)
        {
            return await _service.GetOneOrderAsync(id);
        }
        [HttpPost("CreateOrder")]
        public async Task<IActionResult> CreateOrder(OrderCreateDto orderCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(StatusCodes.Status404NotFound, ModelState);
            }
            return StatusCode(StatusCodes.Status201Created, await _service.CreateOrderAsync(orderCreateDto));
        }
        [HttpDelete("SoftDelete")]
        public async Task<IActionResult> SoftDelete(int id)
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
        [HttpPut("UpdateOrder/{id}")]
        public async Task<IActionResult> UpdateOrder(int id, OrderCreateDto orderCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(StatusCodes.Status404NotFound, ModelState);
            }
            return StatusCode(StatusCodes.Status200OK, await _service.UpdateOrderAsync(id, orderCreateDto));
        }
    }
}
