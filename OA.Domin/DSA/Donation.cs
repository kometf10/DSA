using Microsoft.EntityFrameworkCore.Infrastructure;
using OA.Domin.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace OA.Domin.DSA
{
    public class Donation : BaseEntity
    {
        private readonly ILazyLoader Loader;
        public Donation(ILazyLoader loader)
        {
            Loader = loader;
        }
        public Donation()
        {

        }

        [DisplayName("Corporate Donator")]
        [PropFlag("FK")]
        public int? CorporateDonatorId { get; set; }

        private CorporateDonator _CorporateDonator;
        [PropFlag("FK_REF")]
        public CorporateDonator CorporateDonator
        {
            get => Loader.Load(this, ref _CorporateDonator);
            set => _CorporateDonator = value;
        }

        [DisplayName("Person Donator")]
        [PropFlag("FK")]
        public int? PersonDonatorId { get; set; }

        private PersonDonator _PersonDonator;
        [PropFlag("FK_REF")]
        public PersonDonator PersonDonator
        { 
            get => Loader.Load(this, ref _PersonDonator);
            set => _PersonDonator = value;
        }

        [DisplayName("Beneficiary")]
        [PropFlag("FK")]
        public int? BeneficiaryId { get; set; }

        private Beneficiary _Beneficiary;

        [PropFlag("FK_REF")]
        public Beneficiary Beneficiary
        {
            get => Loader.Load(this, ref _Beneficiary);
            set => _Beneficiary = value;
        }
        
        [PropFlag("FK")]
        [DisplayName("Corporate Beneficiary")]
        public int? CorporateBeneficiaryId { get; set; }

        private CorporateBeneficiary _CorporateBeneficiary;
        [PropFlag("FK_REF")]
        public CorporateBeneficiary CorporateBeneficiary 
        { 
            get => Loader.Load(this, ref _CorporateBeneficiary);
            set => _CorporateBeneficiary = value;
        }

        //public int? DonationRequestId { get; set; }
        //public int? DonationOfferId { get; set; }

        //public bool IsExternal { get; set; }

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public string PayBill { get; set; }

        [DisplayName("Donation Info")]
        public string DonationInfo { get; set; }

        [DisplayName("Donation Type")]
        public string DonationType { get; set; }


    }
}
