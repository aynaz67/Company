using Company.Application.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Application.Validations
{
    public class LoginRequestValidator:AbstractValidator<LoginRequestDto>
    {
        public LoginRequestValidator() { 
            //RuleFor(x=>x.UserName).NotEmpty();
            //RuleFor(x=>x.Password).NotEmpty();
        }
    }
}
