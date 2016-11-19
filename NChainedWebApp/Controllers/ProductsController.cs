using NChained.Business;
using NChained.Business.Contract;
using NChained.Service;
using System.Collections.Generic;
using System.Web.Http;

namespace NChainedWebApp.Controllers
{
    public class ProductsController : ApiController
    {


        
        public IList<Product> GetAllProducts()
        {
            return  ProductRepo.GetAllProducts();
        }

        public void Post([FromBody]Product value)
        {
            ProductRepo.SaveProduct(value);
        }

        public NChainedService ProductRepo
        {
            get { return new NChainedService(); }
        }

    }
}
