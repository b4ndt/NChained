using System;
using System.Runtime.Serialization;

namespace NChained.Service
{
    [DataContract]
    public class ExtendedWarrantyTransaction
    {
        [DataMember]
        public string TransactionGuid { get; set; }

        [DataMember]
        public int TransactionSeq { get; set; }

        [DataMember]
        public DateTime TransactionDateTime { get; set; }


    }
}
