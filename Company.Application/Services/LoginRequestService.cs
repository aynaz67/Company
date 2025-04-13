using AutoMapper;
using Company.Application.Services.Interfaces;
using Company.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Company.Application.Services
{
    public class LoginRequestService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public LoginRequestService(IUserRepository usesrRepository, IMapper mapper)
        {
            _userRepository = usesrRepository;
            _mapper = mapper;
        }



    }
}
