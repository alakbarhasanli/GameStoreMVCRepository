using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.DL.Entities
{
    public class Participants:BaseAuditableEntity
    {
      
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public WorkShops? Workshops { get; set; }

        public int WorkShopId { get; set; }


    }
}
