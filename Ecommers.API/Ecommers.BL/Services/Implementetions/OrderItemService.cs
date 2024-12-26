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
        private readonly Mapper _mapper;
        public OrderItemService(IOrderItemRepository repo,Mapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }
        public Task<Product> CreateOrderItemAsync(OrderItemCreateDto orderItemCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderItem>> GetAllOrderItemAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OrderItem> GetOneorderItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> HardDeleteAsnyc(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SoftDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateOrderItemAsync(int id, OrderItemCreateDto orderItemCreateDto)
        {
            throw new NotImplementedException();
        }
    }
}
