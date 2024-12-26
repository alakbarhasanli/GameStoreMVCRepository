using Ecommers.BL.Dtos;
using Ecommers.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommers.BL.Services.Abstractions
{
   public interface IOrderService
    {
        Task<IEnumerable<Order>> GetAllorderAsync();
        Task<Order> GetOneOrderAsync(int id);
        Task<Order> CreateOrderAsync(OrderCreateDto orderCreateDto);
        Task<bool> UpdateOrderAsync(int id, OrderCreateDto orderCreateDto);
        Task<bool> SoftDeleteAsync(int id);
        Task<bool> HardDeleteAsnyc(int id);
    }
}
