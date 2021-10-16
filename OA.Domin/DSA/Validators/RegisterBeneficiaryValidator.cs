using FluentValidation;
using OA.Domin.DSA.ViewModels;
using OA.Domin.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Domin.DSA.Validators
{
    public class RegisterBeneficiaryValidator : AbstractValidator<RegisterBeneficiaryVM>
    {

        public RegisterBeneficiaryValidator()
        {
            RuleFor(d => d.UserName)
                .NotEmpty().WithMessage(Messages.REQUIRED)
                .Must(Match.IsUserName).WithMessage(Messages.NOTVALID);

            RuleFor(d => d.Password).NotEmpty().WithMessage(Messages.REQUIRED);

            RuleFor(d => d.Type)
                .NotEmpty().WithMessage(Messages.REQUIRED)
                .Must(v => new List<string>() { "Per", "Corp" }.Contains(v)).WithMessage(Messages.NOTVALID);

            When(d => d.Type == "Per", () =>
            {                
                RuleFor(d => d.Beneficiary)
                    .NotNull().WithMessage(Messages.REQUIRED)
                    .SetValidator(new BeneficiaryValidator());
            });

            When(d => d.Type == "Corp", () =>
            {
                RuleFor(d => d.CorporateBeneficiary)
                    .NotNull().WithMessage(Messages.REQUIRED)
                    .SetValidator(new CorporateBeneficiaryValidator());
            });
        }

    }
}
