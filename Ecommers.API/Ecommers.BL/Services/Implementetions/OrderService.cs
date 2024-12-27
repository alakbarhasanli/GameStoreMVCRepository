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
    public class OrderService:IOrderService
    {
        private readonly IOrderRepository _repo;
        private readonly IMapper _mapper;
        public OrderService(IOrderRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;

        }
        public async Task<Order> CreateOrderAsync(OrderCreateDto orderCreateDto)
        {
            Order order = _mapper.Map<Order>(orderCreateDto);
            order.CreatedDate = DateTime.Now;
            var createdOrder = await _repo.CreateAsync(order);
            await _repo.SaveChangesAsync();
            return createdOrder;

        }

        public async Task<IEnumerable<Order>> GetAllorderAsync()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<Order> GetOneOrderAsync(int id)
        {
            return await _repo.GetOneEntityIdAsync(id);
        }

        public async Task<bool> HardDeleteAsnyc(int id)
        {
            var order = await _repo.GetOneEntityIdAsync(id);
            _repo.HardDelete(order);
            return true;
        }

        public async Task<bool> SoftDeleteAsync(int id)
        {
            var order = await _repo.GetOneEntityIdAsync(id);
            _repo.SoftDelete(order);
            return true; 
        }

        public async Task<bool> UpdateOrderAsync(int id, OrderCreateDto orderCreateDto)
        {
            Order order = _mapper.Map<Order>(orderCreateDto);
            order.CreatedDate = DateTime.Now;
            var entityOrder = await _repo.GetOneEntityIdAsync(id);
            _repo.Update(order);
            await _repo.SaveChangesAsync();
            return true;


        }
    }
}
