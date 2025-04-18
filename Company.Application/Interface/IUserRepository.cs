using Company.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Application.Interface
{
    public interface IUserRepository
    {
        public Task<User> AuthenticateAsync(string userName, string Password);       
    }
}
