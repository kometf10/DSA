using FluentValidation;
using OA.Domin.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Domin.DSA.Validators
{
    public class PersonValidator : AbstractValidator<Person>
    {

        public PersonValidator()
        {
            RuleFor(per => per.Name).NotEmpty().WithMessage(Messages.REQUIRED);

            RuleFor(per => per.Phone)
                .NotEmpty().WithMessage(Messages.REQUIRED)
                .Must(Match.IsPhone).WithMessage(Messages.NOTVALID);

            When(per => !string.IsNullOrEmpty(per.Email), () =>
            {
                RuleFor(per => per.Email)
                    .EmailAddress().WithMessage(Messages.NOTVALID);
            });


        }
        
    }
}
