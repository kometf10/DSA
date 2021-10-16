using OA.Domin.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Domin.DSA
{
    public class Person : BaseEntity
    {

        public string Name { get; set; }

        public string EnName { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }

        public string Gender { get; set; }

        public DateTime? BirthDate { get; set; }

        public string Residentcountry { get; set; }

        [PropFlag("FK_REF")]
        [PropFlag("IGNORE")]
        public PersonDonator PersonDonator { get; set; }

        [PropFlag("FK_REF")]
        [PropFlag("IGNORE")]
        public CorporateDonator CorporateDonator { get; set; }

        [PropFlag("FK_REF")]
        [PropFlag("IGNORE")]
        public virtual Beneficiary Beneficiary {get; set;}

    }
}
