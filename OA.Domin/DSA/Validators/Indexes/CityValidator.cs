using FluentValidation;
using OA.Domin.DSA.Indexes;
using OA.Domin.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Domin.DSA.Validators.Indexes
{
    public class CityValidator : AbstractValidator<City>
    {

        public CityValidator()
        {
            RuleFor(city => city.Name).NotEmpty().WithMessage(Messages.REQUIRED);
        }

    }
}
