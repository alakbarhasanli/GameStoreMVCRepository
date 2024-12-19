using Magazine.DL.Contexts;
using Magazine.DL.Entities;
using Magazine.DL.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.DL.Repositories.Concretes
{
    public class WorkshopsRepository : GenericRepository<WorkShops>, IWorkshopsRepository
    {
        public WorkshopsRepository(MagazineDbContext context):base(context)
        {
            
        }
    }
}
