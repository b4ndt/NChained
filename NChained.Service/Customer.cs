using System.Runtime.Serialization;

namespace NChained.Service
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string EmailAddress { get; set; }
    }
}
