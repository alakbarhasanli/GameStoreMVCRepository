using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.DL.Entities
{
    public abstract  class BaseAuditableEntity:BaseEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime? Updatedat { get; set; }
        public DateTime? DeletedAt { get; set; } 
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public string? DeletedBy { get; set; }
    }
}
