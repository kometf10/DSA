using Microsoft.EntityFrameworkCore.Infrastructure;
using OA.Domin.Attributes;
using OA.Domin.DSA.Indexes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OA.Domin.DSA
{
    public class DonationRequest : BaseEntity
    {
        public DonationRequest()
        {

        }

        private readonly ILazyLoader Loader;
        public DonationRequest(ILazyLoader loader)
        {
            Loader = loader;
        }

        [PropFlag("FK")]
        public int? DonationTypeId { get; set; }

        private DonationType _DonationType;
        [PropFlag("FK_REF")]
        public DonationType DonationType 
        { 
            get => Loader.Load(this, ref _DonationType);
            set => _DonationType = value;
        }

        public bool IsAccepted { get; set; }

        public bool IsAssigned { get; set; }

        public string BeneficiaryType { get; set; }

        public int? BeneficiaryId { get; set; }

        public int? CorpBeneficiaryId { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

    }
}
