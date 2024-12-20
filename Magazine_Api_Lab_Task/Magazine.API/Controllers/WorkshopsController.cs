using Magazine.BL.DTOs;
using Magazine.BL.Services.Abstractions;
using Magazine.BL.Services.Concretes;
using Magazine.DL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Magazine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkshopsController : ControllerBase
    {
        private readonly IWorkshopsService _workshopsService;
        public WorkshopsController(IWorkshopsService workshopsService)
        {
            _workshopsService = workshopsService;
        }
        [HttpGet]
        public async Task<IEnumerable<WorkShops>> GetAll()
        {
            return await _workshopsService.GetAllasync();
        }
        [HttpPost ]
        public async Task<WorkShops> CreateWorkShopsController( WorkShopsCreateDTO workShopsCreateDTO)
        {
            return await _workshopsService.CreateAsync(workShopsCreateDTO);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteParticipant(int id)
        {

            var work = await _workshopsService.GetByIdAsync(id);
            _workshopsService.Delete(work);
            return NoContent();


        }
    }
}
