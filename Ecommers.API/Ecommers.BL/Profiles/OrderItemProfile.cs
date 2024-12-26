using AutoMapper;
using Ecommers.BL.Dtos;
using Ecommers.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommers.BL.Profiles
{
    public class OrderItemProfile:Profile
    {
        public OrderItemProfile()
        {
            CreateMap<OrderItemCreateDto, OrderItem>().ReverseMap();
        }
    }
}
