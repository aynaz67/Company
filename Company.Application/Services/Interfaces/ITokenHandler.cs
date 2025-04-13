using Company.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Application.Services.Interfaces
{
    public interface ITokenHandler
    {
        Task<string> CreateTokenAsync(User user);
    }
}
