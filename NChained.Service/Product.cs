using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace NChained.Service
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public string ProductManufacturer { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public string ProductDescription { get; set; }
        [DataMember]
        public string ProductSerialNumber { get; set; }
    }
}