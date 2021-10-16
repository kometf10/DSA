using FluentValidation;
using OA.Domin.DSA.Indexes;
using OA.Domin.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Domin.DSA.Validators.Indexes
{
    public class JobTypeValidator : AbstractValidator<JobType>
    {

        public JobTypeValidator()
        {
            RuleFor(job => job.Name).NotEmpty().WithMessage(Messages.REQUIRED);
        }

    }
}
