using Company.Application.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Company.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Company.Infrastructure.Repositories
{

    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<T?> GetByIdAsync(int id) => await _dbSet.FindAsync(id);

        //public async Task<T?> GetByIdAsync(int id)
        //{
        //    if (_dbSet == null)
        //    {
        //        throw new InvalidOperationException("DbSet is not initialized.");
        //    }

        //    try
        //    {
        //        return await _dbSet.FindAsync(id);
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle the exception as desired
        //        throw new Exception("An error occurred while retrieving the entity by ID.", ex);
        //    }
        //   // return await _dbSet.FindAsync(id);
        //}

        public async Task<IEnumerable<T>> GetAllAsync() => await _dbSet.ToListAsync();

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task UpdateAsync(T entity)
        {
         _dbSet.Update(entity);
        }

        public async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
        }
        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}


