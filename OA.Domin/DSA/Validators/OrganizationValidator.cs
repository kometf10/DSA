using FluentValidation;
using OA.Domin.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Domin.DSA.Validators
{
    public class OrganizationValidator : AbstractValidator<Organization>
    {

        public OrganizationValidator()
        {
            RuleFor(o => o.Name).NotEmpty().WithMessage(Messages.REQUIRED);

            RuleFor(o => o.Country).NotEmpty().WithMessage(Messages.REQUIRED);

            RuleFor(o => o.Phone).NotEmpty().WithMessage(Messages.REQUIRED);

            RuleFor(o => o.Email).EmailAddress().WithMessage(Messages.REQUIRED);

            RuleFor(o => o.Person).SetValidator(new PersonValidator());

        }

    }
}
