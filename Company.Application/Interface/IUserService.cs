using Company.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Application.Interface
{
    public interface IUserService
    {
        Task<string?> AuthenticateAsync(string userName, string Password);
    }
}
