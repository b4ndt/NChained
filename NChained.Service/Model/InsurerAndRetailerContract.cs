using System;

namespace NChained.Service.Model
{
    public class InsurerAndRetailerContract
    {
        public string RetailerName { get; set; }
        public string RetailerRegisteredAddress { get; set; }
        public string RetailerPrimaryContact { get; set; }
        public DateTime AgreementStartDate { get; set; }
        public DateTime AgreementEndDate { get; set; }
        public Decimal CommissionRate { get; set; }
        public string TermsOfPayment { get; set; }
        public decimal ExtendedWarrantyInsuranceRates { get; set; }

    }
}
