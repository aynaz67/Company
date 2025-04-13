using Company.Application.Services.Interfaces;
using Company.Domain.Entity;
using Company.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Company.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<User> _dbSet;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;

        }

        public async Task<User?> AuthenticateAsync(string userName, string Password)
        {
            var user = await _dbSet.FirstOrDefaultAsync(u => u.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase) && u.Password == Password);
            return user;
        }

    }
}
