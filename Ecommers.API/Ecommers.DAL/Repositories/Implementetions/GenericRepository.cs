using Ecommers.DAL.Contexts;
using Ecommers.DAL.Entities;
using Ecommers.DAL.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommers.DAL.Repositories.Implementetions
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity, new()
    {
        private readonly EcommerseDbContext _context;
        public GenericRepository(EcommerseDbContext context)
        {
            _context = context;
        }
        public DbSet<TEntity> Table => _context.Set<TEntity>();
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await Table.Where(x=>!x.IsDeleted).ToListAsync();
        }
        public async Task<TEntity> GetOneEntityIdAsync(int id)
        {
            var existingEntity = await Table.FirstOrDefaultAsync(x=>x.Id==id && !x.IsDeleted);
            _context.Entry(existingEntity).State=EntityState.Detached;
            return existingEntity;
        }
        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            await Table.AddAsync(entity);
            return entity;

        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }


        public void SoftDelete(TEntity entity)
        {
            entity.IsDeleted = true;
        }
        public void HardDelete(TEntity entity)
        {
            Table.Remove(entity);


        }

        public async Task<int> SaveChangesAsync()
        {
           return await _context.SaveChangesAsync();
        }
    }
}
