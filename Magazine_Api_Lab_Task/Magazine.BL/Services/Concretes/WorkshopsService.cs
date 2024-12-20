using AutoMapper;
using Magazine.BL.DTOs;
using Magazine.BL.Services.Abstractions;
using Magazine.DL.Entities;
using Magazine.DL.Repositories.Abstractions;
using Magazine.DL.Repositories.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.BL.Services.Concretes
{
    public class WorkshopsService : IWorkshopsService
    {
        private readonly IWorkshopsRepository _workshopsRepository;
        private readonly IMapper _mapper;

        public WorkshopsService(IWorkshopsRepository workshopsRepository, IMapper mapper)
        {
            _workshopsRepository = workshopsRepository;
            _mapper = mapper;
        }


        public async Task<WorkShops> CreateAsync(WorkShopsCreateDTO workShopsCreateDTO)
        {
            WorkShops workShops = _mapper.Map<WorkShops>(workShopsCreateDTO);
            workShops.CreatedAt = DateTime.Now;
            var ceratedWorkshops = await _workshopsRepository.CreateAsync(workShops);
            await _workshopsRepository.SaveChangesasync();
            return ceratedWorkshops;
        }

        public void Delete(WorkShops workShops)
        {
            _workshopsRepository.DeleteAsync(workShops);
            _workshopsRepository.SaveChangesasync();
        }

        public async Task<IEnumerable<WorkShops>> GetAllasync()
        {
            var AllWorkShops = await _workshopsRepository.GetAllAsync();
            return AllWorkShops;
        }

        public async Task<WorkShops> GetByIdAsync(int id)
        {
            return await _workshopsRepository.GetByIdAsync(id);
        }

        public void Update(WorkShops workShops)
        {
            _workshopsRepository.UpdateAsync(workShops);
        }
    }
}
