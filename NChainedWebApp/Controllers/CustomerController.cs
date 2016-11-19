using NChained.Service;
using System.Collections.Generic;
using System.Web.Http;

namespace NChainedWebApp.Controllers
{
    public class CustomersController : ApiController
    {

        public IList<Customer> GetAll(string name)
        {
            return CustomerRepo.GetCustomerByName(name);
        }

        public IList<Customer> GetAll()
        {
            return CustomerRepo.GetAllCustomers();
        }


        public void Post([FromBody]Customer value)
        {
            CustomerRepo.SaveCustomer(value);
        }

        public NChainedService CustomerRepo
        {
            get { return new NChainedService(); }
        }


    }
}
