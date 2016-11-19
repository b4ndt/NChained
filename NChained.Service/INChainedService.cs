using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace NChained.Service
{

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface INChainedService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/GetData?arg={arg}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedResponse)]
        Product GetData(int arg);

        [OperationContract]
        IList<Product> GetProductsByName(string Name);

        [OperationContract]
       void  SaveProduct(Product Name);

        [OperationContract]
        IList<Product> GetAllProducts();

        [OperationContract]
        IList<Customer> GetAllCustomers();

        [OperationContract]
        void SaveCustomer(Customer customer );


    }

}
