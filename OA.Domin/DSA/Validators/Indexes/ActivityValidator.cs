using FluentValidation;
using OA.Domin.DSA.Indexes;
using OA.Domin.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Domin.DSA.Validators.Indexes
{
    public class ActivityValidator : AbstractValidator<Activity>
    {

        public ActivityValidator()
        {
            RuleFor(act => act.Name).NotEmpty().WithMessage(Messages.REQUIRED);
        }

    }
}
