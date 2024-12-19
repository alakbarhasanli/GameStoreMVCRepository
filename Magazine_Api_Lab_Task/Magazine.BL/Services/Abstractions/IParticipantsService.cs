using Magazine.DL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.BL.Services.Abstractions
{
    public  interface IParticipantsService
    {
        Task<IEnumerable<Participants>> GetAllasync();
        Task<IEnumerable<Participants>> GetAllAsync();
        Task<Participants> GetByIdAsync(int id);
        Task<Participants> CreateAsync(Participants);
        void Update(Participants participants);
        void Delete(Participants participants);

    }
}
