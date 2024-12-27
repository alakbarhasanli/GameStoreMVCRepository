using Ecommers.BL.Dtos;
using Ecommers.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommers.BL.Services.Abstractions
{
    public  interface IOrderItemService
    {
        Task<IEnumerable<OrderItem>> GetAllOrderItemAsync();
        Task<OrderItem> GetOneorderItemAsync(int id);
        Task<OrderItem> CreateOrderItemAsync(OrderItemCreateDto orderItemCreateDto);
        Task<bool> UpdateOrderItemAsync(int id, OrderItemCreateDto orderItemCreateDto);
        Task<bool> SoftDeleteAsync(int id);
        Task<bool> HardDeleteAsnyc(int id);
    }
}
