using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Domin.DSA.Validators
{
    public class BeneficiaryValidator : AbstractValidator<Beneficiary>
    {
        public BeneficiaryValidator()
        {
            RuleFor(ben => ben.Person).SetValidator(new PersonValidator());
        }

    }
}
