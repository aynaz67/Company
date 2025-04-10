using Company.Application.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Application.Validations
{
    internal class CreateUpdateVillaValidation : AbstractValidator<CreateUpdateVillaDto>
    {
        public CreateUpdateVillaValidation()
        {
            RuleFor(x => x.Name).NotEmpty();

        }
    }
}
