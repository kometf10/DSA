using FluentValidation;
using OA.Domin.DSA.ViewModels;
using OA.Domin.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Domin.DSA.Validators
{
    public class RegisterDonatorValidator : AbstractValidator<RegisterDonatorVM>
    {

        public RegisterDonatorValidator()
        {
            RuleFor(d => d.DonatorUserName)
                .NotEmpty().WithMessage(Messages.REQUIRED)
                .Must(Match.IsUserName).WithMessage(Messages.NOTVALID);

            RuleFor(d => d.DonatorPassword).NotEmpty().WithMessage(Messages.REQUIRED);

            RuleFor(d => d.Type)
                .NotEmpty().WithMessage(Messages.REQUIRED)
                .Must(v => new List<string>() { "Per", "Corp" }.Contains(v)).WithMessage(Messages.NOTVALID);

            When(d => d.Type == "Per", () =>
            {
                RuleFor(d => d.PersonDonator)
                    .NotNull().WithMessage(Messages.REQUIRED)
                    .SetValidator(new PersonDonatorValidator());
            });

            When(d => d.Type == "Corp", () =>
            {
                RuleFor(d => d.CorporateDonator)
                    .NotNull().WithMessage(Messages.REQUIRED)
                    .SetValidator(new CorporateDonatorValidator());
            });
        }

    }
}
