using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Domin.DSA.Validators
{
    public class PersonDonatorValidator : AbstractValidator<PersonDonator>
    {
        public PersonDonatorValidator()
        {
            RuleFor(per => per.Person).SetValidator(new PersonValidator());
        }
    }
}
