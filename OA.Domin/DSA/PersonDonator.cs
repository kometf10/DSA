using Microsoft.EntityFrameworkCore.Infrastructure;
using OA.Domin.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OA.Domin.DSA
{
    public class PersonDonator : BaseEntity
    {
        private readonly ILazyLoader Loader;
        public PersonDonator(ILazyLoader loader)
        {
            Loader = loader;
        }
        public PersonDonator()
        {
            Person = new Person();
        }

        [NotMapped]
        public string Name
        {
            get => Person?.Name;
            private set { }
        }

        [PropFlag("FK")]
        public int PersonId { get; set; }
        
        private Person _Person;

        [PropFlag("FK_REF")]
        public virtual Person Person
        {
            get => Loader.Load(this, ref _Person);
            set => _Person = value;
        }

        public string UserId { get; set; }

        [PropFlag("FK_REF_COLL")]
        public virtual ICollection<Donation> Donations { get; set; }

    }
}
