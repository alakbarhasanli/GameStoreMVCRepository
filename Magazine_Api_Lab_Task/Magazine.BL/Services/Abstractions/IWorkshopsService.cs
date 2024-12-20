using Magazine.BL.DTOs;
using Magazine.DL.Entities;
using Magazine.DL.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.BL.Services.Abstractions
{
    public interface IWorkshopsService
    {
        Task<IEnumerable<WorkShops>> GetAllasync();
        Task<WorkShops> GetByIdAsync(int id);
        
        Task<WorkShops> CreateAsync(WorkShopsCreateDTO workShopsCreateDTO);
        void Update(WorkShops workShops);
        void Delete(WorkShops workShops);
    }
}
