using FluentValidation;
using OA.Domin.Validators;
using System;
using System.Collections.Generic;
using System.Text;
using OA.Domin.DSA.Indexes;

namespace OA.Domin.DSA.Validators.Indexes
{
    public class GovernorateValidator : AbstractValidator<Governorate>
    {

        public GovernorateValidator()
        {
            RuleFor(gov => gov.Name).NotEmpty().WithMessage(Messages.REQUIRED);
        }

    }
}
