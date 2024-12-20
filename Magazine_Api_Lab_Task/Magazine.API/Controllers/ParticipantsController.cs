using Magazine.BL.DTOs;
using Magazine.BL.Services.Abstractions;
using Magazine.DL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Magazine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipantsController : ControllerBase
    {
        private readonly IParticipantsService _participantsService;
        public ParticipantsController(IParticipantsService participantsService)
        {
            _participantsService = participantsService;
        }
        [HttpGet]
        public async Task<IEnumerable<Participants>> GetAll()
        {
            return await _participantsService.GetAllasync();
        }
        [HttpPost]
        public async Task<Participants> CreateParticipantsasync(ParcitipantsCreateDTO participantsCreateDTO)
        {

            return await _participantsService.CreateAsync(participantsCreateDTO);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteParticipant(int id)
        {
           
            var participant = await _participantsService.GetByIdAsync(id);
             _participantsService.Delete(participant);
            return NoContent();
            
      
        }

    }
}
