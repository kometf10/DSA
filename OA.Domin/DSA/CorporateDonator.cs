using Microsoft.EntityFrameworkCore.Infrastructure;
using OA.Domin.Attributes;
using OA.Domin.DSA.Indexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Domin.DSA
{
    public class CorporateDonator : BaseEntity
    {

        private readonly ILazyLoader Loader;
        public CorporateDonator(ILazyLoader loader)
        {
            Loader = loader;
        }
        public CorporateDonator()
        {
            Person = new Person();
        }

        public string Name { get; set; }

        public string EnName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        [PropFlag("FK")]
        public int? ActivityId { get; set; }

        [PropFlag("FK_REF")]
        public Activity Activity {get; set;}

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
