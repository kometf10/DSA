using OA.Domin.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Domin.DSA
{
    public class DonationOffer : BaseEntity
    {
        [PropFlag("FK")]
        public int DonationRequestId { get; set; }

        [PropFlag("FK_REF")]
        public virtual DonationRequest DonationRequest { get; set; }

        public bool IsAccepted { get; set; } = false;

        public string DonatorType { get; set; }

        public int? PersonDonatorId { get; set; }

        public int? CorporateDonatorId { get; set; }

        public string Notes { get; set; }


    }
}
