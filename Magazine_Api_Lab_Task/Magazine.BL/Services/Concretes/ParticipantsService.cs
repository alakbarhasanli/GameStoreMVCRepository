using AutoMapper;
using Magazine.BL.DTOs;
using Magazine.BL.Services.Abstractions;
using Magazine.DL.Entities;
using Magazine.DL.Repositories.Abstractions;
using Magazine.DL.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.BL.Services.Concretes
{
    public class ParticipantsService : IParticipantsService
    { 
        private readonly IPartipicatiansRepository _partipicatiansRepository;
        private readonly IMapper _mapper;

        public ParticipantsService(IPartipicatiansRepository partipicatiansRepository, IMapper mapper)
        {
            _partipicatiansRepository = partipicatiansRepository;
            _mapper = mapper;
        }
        public async Task<Participants> CreateAsync(ParcitipantsCreateDTO parcitipantsCreateDTO)
        {
            Participants participants = _mapper.Map<Participants>(parcitipantsCreateDTO);
          
            participants.CreatedAt = DateTime.Now;
            var createdEntity = await _partipicatiansRepository.CreateAsync(participants);
         await _partipicatiansRepository.SaveChangesasync();
            return createdEntity;
        }

        public void Delete(Participants participants)
        {
            _partipicatiansRepository.DeleteAsync(participants);
            _partipicatiansRepository.SaveChangesasync();
        }

        public async Task<IEnumerable<Participants>> GetAllasync()
        {
            var AllParticipants=await _partipicatiansRepository.GetAllAsync();
            return AllParticipants;
        }

        public async Task<Participants> GetByIdAsync(int id)
        {
            return await _partipicatiansRepository.GetByIdAsync(id);
        }

        public void Update(Participants participants)
        {
            _partipicatiansRepository.UpdateAsync(participants);
        }
    }
}
