using AutoMapper;
using Ecommers.BL.Dtos;
using Ecommers.BL.Services.Abstractions;
using Ecommers.DAL.Entities;
using Ecommers.DAL.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommers.BL.Services.Implementetions
{
    public class OrderItemService : IOrderItemService
    {
        private readonly IOrderItemRepository _repo;
        private readonly IMapper _mapper;
        public OrderItemService(IOrderItemRepository repo,IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }
        public async Task<OrderItem> CreateOrderItemAsync(OrderItemCreateDto orderItemCreateDto)
        {
            OrderItem orderItem = _mapper.Map<OrderItem>(orderItemCreateDto);
            orderItem.CreatedDate = DateTime.Now;
            var createdOrderItem = await _repo.CreateAsync(orderItem);
            await _repo.SaveChangesAsync();
            return createdOrderItem;
        }

        public async Task<IEnumerable<OrderItem>> GetAllOrderItemAsync()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<OrderItem> GetOneorderItemAsync(int id)
        {
            return await _repo.GetOneEntityIdAsync(id);
        }

        public async Task<bool> HardDeleteAsnyc(int id)
        {
            var orderItem = await _repo.GetOneEntityIdAsync(id);
            _repo.HardDelete(orderItem);
            return true;
        }

        public async Task<bool> SoftDeleteAsync(int id)
        {
            var orderItem = await _repo.GetOneEntityIdAsync(id);
            _repo.SoftDelete(orderItem);
            return true;
        }

        public async Task<bool> UpdateOrderItemAsync(int id, OrderItemCreateDto orderItemCreateDto)
        {
            OrderItem orderItem = _mapper.Map<OrderItem>(orderItemCreateDto);
            orderItem.CreatedDate = DateTime.Now;
            var entityOrderItem = await _repo.GetOneEntityIdAsync(id);
            _repo.Update(entityOrderItem);
            await _repo.SaveChangesAsync();
            return true;
        }
    }
}
