using AutoMapper;
using Company.Application.DTOs;
using Company.Application.Interface;
using Company.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ITokenHandler _tokenHandler;

        public UserService(IUserRepository userRepository, ITokenHandler tokenHandler)
        {
            _userRepository = userRepository;
            _tokenHandler = tokenHandler;
        }
        public async Task<string?> AuthenticateAsync(string userName, string Password)
        {
            var user = await _userRepository.AuthenticateAsync(userName, Password);
            if (user == null)
            {
                return null;
            }

            var token = await _tokenHandler.CreateTokenAsync(user);
            return token;
        }
    }
}