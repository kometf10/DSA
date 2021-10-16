using FluentValidation;
using OA.Domin.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Domin.DSA.Validators
{
    public class CorporateDonatorValidator : AbstractValidator<CorporateDonator>
    {

        public CorporateDonatorValidator()
        {
            RuleFor(corp => corp.Name).NotEmpty().WithMessage(Messages.REQUIRED);

            RuleFor(corp => corp.Phone).NotEmpty().WithMessage(Messages.REQUIRED);

            When(corp => !string.IsNullOrEmpty(corp.Email), () =>
            {
                RuleFor(corp => corp.Email).NotEmpty().WithMessage(Messages.REQUIRED);
            });

            RuleFor(corp => corp.ActivityId).NotNull().NotEqual(0).WithMessage(Messages.NOTVALID);

            RuleFor(corp => corp.Person).SetValidator(new PersonValidator());
            
        }

    }
}
