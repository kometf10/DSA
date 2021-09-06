using OA.Domin.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace OA.Domin.DSA
{
    public class EventTranslation : BaseEntity
    {

        public string Name { get; set; }

        public string Description { get; set; }

        [PropFlag("FK")]
        [DisplayName("Event")]
        public int EventId { get; set; }

        [PropFlag("FK_REF")]
        public virtual Event Event { get; set; }

        public string Language { get; set; }

        public string Slug { get; set; }

        [DisplayName("Active")]
        public bool IsActive { get; set; }

    }
}
