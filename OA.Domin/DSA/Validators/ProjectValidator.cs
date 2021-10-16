using FluentValidation;
using OA.Domin.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Domin.DSA.Validators
{
    public class ProjectValidator : AbstractValidator<Project>
    {
        public ProjectValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage(Messages.REQUIRED);

            RuleFor(p => p.OwnerName).NotEmpty().WithMessage(Messages.REQUIRED);

            RuleFor(p => p.Location).NotEmpty().WithMessage(Messages.REQUIRED);

            RuleFor(p => p.SupervisorName).NotEmpty().WithMessage(Messages.REQUIRED);

            RuleFor(p => p.SupervisorPhone)
                .NotEmpty().WithMessage(Messages.REQUIRED)
                .Must(Match.IsPhone).WithMessage(Messages.PHONE);
        }

    }
}
