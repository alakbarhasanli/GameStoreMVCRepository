using Ecommers.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommers.BL.Dtos
{
    public class OrderCreateDto
    {
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
