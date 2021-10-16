using OA.Domin.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Domin.DSA.Indexes
{
    public class Activity : BaseEntity
    {
        public string Name { get; set; }        public string Description { get; set; }        [PropFlag("FK_REF_COLL")]        public virtual ICollection<CorporateDonator> CorporateDonators { get; set; }    }
}
