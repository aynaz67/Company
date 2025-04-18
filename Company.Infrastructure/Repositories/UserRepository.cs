using Company.Application.DTOs;
using Company.Application.Interface;
using Company.Domain.Entity;
using Company.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;

namespace Company.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Company.Domain.Entity.User> _dbSet;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<User>();
        }

        public async Task<Company.Domain.Entity.User?> AuthenticateAsync(string userName, string Password)
        {
            //   var a =  _dbSet.SingleOrDefaultAsync(u => u.UserName == userName && u.Password == Password);
            var a = await _dbSet.FirstOrDefaultAsync(u => u.UserName == userName && u.Password == Password);
            //return _mapper.Map<VillaDto>(villa);
            return a;

        }
        // public async Task<IEnumerable<T>> GetAllAsync() => await _dbSet.ToListAsync();
    }
}
