using Ecommers.BL.Dtos;
using Ecommers.BL.Services.Abstractions;
using Ecommers.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemController : ControllerBase
    {
        private readonly IOrderItemService _service;

        public OrderItemController(IOrderItemService service)
        {
            _service = service;

        }
        [HttpGet("AllOrderItem")]
        public async Task<IEnumerable<OrderItem>> GetAll()
        {
            return await _service.GetAllOrderItemAsync();
        }
        [HttpGet("OneOrderItem")]
        public async Task<OrderItem> GetOneOrderItem(int id)
        {
            return await _service.GetOneorderItemAsync(id);
        }
        [HttpPost("CreateOrderItem")]
        public async Task<IActionResult> CreateOrderItem(OrderItemCreateDto orderItemCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(StatusCodes.Status404NotFound, ModelState);
            }
            return StatusCode(StatusCodes.Status201Created, await _service.CreateOrderItemAsync(orderItemCreateDto));
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
        [HttpPut("UpdateOrderItem/{id}")]
        public async Task<IActionResult> UpdateOrderItem(int id, OrderItemCreateDto orderItemCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(StatusCodes.Status404NotFound, ModelState);
            }
            return StatusCode(StatusCodes.Status200OK, await _service.UpdateOrderItemAsync(id, orderItemCreateDto));
        }
    }
}
