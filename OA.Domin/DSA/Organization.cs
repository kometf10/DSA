using Microsoft.EntityFrameworkCore.Infrastructure;
using OA.Domin.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Domin.DSA
{
    public class Organization : BaseEntity
    {

        public Organization()
        {
            Person = new Person();
        }

        private readonly ILazyLoader Loader;
        public Organization(ILazyLoader loader)
        {
            Loader = loader;
        }

        public string Name { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        [PropFlag("FK")]
        public int PersonId { get; set; }

        private Person _Person;

        [PropFlag("FK_REF")]
        public virtual Person Person 
        { 
            get => Loader.Load(this, ref _Person);
            set => _Person = value;
        }

    }
}
