using Ecommers.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommers.DAL.Repositories.Abstractions
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity, new()
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetOneEntityIdAsync(int id );
        Task<TEntity>  CreateAsync(TEntity entity);
        void Update(TEntity entity);
        void SoftDelete (TEntity entity );
        void HardDelete (TEntity entity);
        Task<int> SaveChangesAsync();

    }
}
