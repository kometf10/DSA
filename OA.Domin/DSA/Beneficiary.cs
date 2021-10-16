using Microsoft.EntityFrameworkCore.Infrastructure;
using OA.Domin.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OA.Domin.DSA
{
    public class Beneficiary : BaseEntity
    {
        private readonly ILazyLoader Loader;
        public Beneficiary(ILazyLoader loader)
        {
            Loader = loader;
        }

        public Beneficiary()
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
        public Person Person 
        { 
            get => Loader.Load(this, ref _Person);
            set => _Person = value;
        }

        public string UserId { get; set; }

        [PropFlag("FK_REF_COLL")]
        public virtual ICollection<Donation> Donations { get; set; } 

    }
}
