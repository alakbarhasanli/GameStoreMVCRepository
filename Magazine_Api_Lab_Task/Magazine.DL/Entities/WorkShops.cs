using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.DL.Entities
{
    public class WorkShops:BaseAuditableEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date {  get; set; }
        public string Location { get; set; }
        public ICollection<Participants> Participants { get; set; }
    }
}
