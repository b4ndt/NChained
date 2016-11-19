using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NChained.Service
{
    [DataContract]
    public class ExtendedWarrantySmartContract
    {
        [DataMember]
        public Customer Customer { get; set; }

        [DataMember]
        public Product Product { get; set; }

        [DataMember]
        public DateTime DateOfSale { get; set; }

        [DataMember]
        public DateTime ExtendedWarrantyStartDate { get; set; }

        [DataMember]
        public DateTime ExtendedWarrantyEndDate { get; set; }

        [DataMember]
        public decimal ExtendedWarrantyPremium { get; set; }

        [DataMember]
        public string PolicyNumber { get; set; }

        [DataMember]
        public List<ExtendedWarrantyTransaction> ExtendedWarrantyTransactionList = new List<ExtendedWarrantyTransaction>();

    }
}
