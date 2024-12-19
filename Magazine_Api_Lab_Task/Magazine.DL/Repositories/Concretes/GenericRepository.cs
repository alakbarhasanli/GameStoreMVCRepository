using Magazine.DL.Contexts;
using Magazine.DL.Entities;
using Magazine.DL.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.DL.Repositories.Concretes
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new()
    {
        private readonly MagazineDbContext _context;
        public GenericRepository(MagazineDbContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public async Task<T> CreateAsync(T entity)
        {
            await Table.AddAsync(entity);
            return entity;
        }

        public void DeleteAsync(T entity)
        {
           Table.Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await Table.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            T? entity= await Table.FindAsync(id);
            return entity;

        }

        public async Task<int> SaveChangesasync()
        {
           return  await _context.SaveChangesAsync();
        }

        public  void UpdateAsync(T entity)
        {
          Table.Update(entity);
        }
    }
}
