﻿using Company.Application.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Application.Validations
{
    public class VillaDTOValidation : AbstractValidator<VillaDto>
    {
        public VillaDTOValidation()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}
