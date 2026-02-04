using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using WMS.Application.DTOs;


namespace WMS.Application.Validators
{
    public class CreateWorkRequestValidator : AbstractValidator<CreateWorkRequestDto>
    {
        public CreateWorkRequestValidator()
        {
            RuleFor(x => x.Title).NotEmpty().MaximumLength(200);
            RuleFor(x => x.Description).NotEmpty().MaximumLength(2000);
        }
    }
}
