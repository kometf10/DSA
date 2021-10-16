using FluentValidation;
using OA.Domin.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Domin.DSA.Validators
{
    public class VacancyValidator : AbstractValidator<Vacancy>
    {

        public VacancyValidator()
        {
            RuleFor(v => v.Name).NotEmpty().WithMessage(Messages.REQUIRED);

            RuleFor(v => v.JobName).NotEmpty().WithMessage(Messages.REQUIRED);

            RuleFor(v => v.ContactEmail)
                .NotEmpty().WithMessage(Messages.REQUIRED)
                .EmailAddress().WithMessage(Messages.NOTVALID);
        }

    }
}
