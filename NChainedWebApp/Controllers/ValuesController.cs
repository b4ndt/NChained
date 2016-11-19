using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Http;
using NChained.Service;

namespace NChainedWebApp.Controllers
{

    public class ValuesController : ApiController
    {


        //// GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };

        //}

        // GET api/values/5
        public IList<Product> GetAllProducts()
        {
            var s = new NChained.Service.NChainedService();
            return new List<Product>() { new Product() { ProductName = "teste" } };
        } 

        public Test GetTest(string retailerName, string retailerPrimaryContact)
        {
            return new Test() { RetailerName = retailerName, RetailerPrimaryContact= retailerPrimaryContact };
        }

        public Test2 GetTest2(string productName, string productType)
        {
            return new Test2() { ProductName = productName, ProductType = productType };
        }


        public string GetTest3(string product, string Retailer)
        {
            var prod = JsonConvert.DeserializeObject<Test2>(product);
            var ret = JsonConvert.DeserializeObject<Test>(Retailer);
            return "Done";
                        
        }

        public ExtendedWarrantySmartContract GetSmartContract( string customer,string product  )
        {
            var sc = new ExtendedWarrantySmartContract();
            sc.Product = new Product() { ProductName = product };
            sc.Customer = new Customer() { Name = customer };
            sc.ExtendedWarrantyStartDate = DateTime.Now.AddYears(1);
            sc.ExtendedWarrantyEndDate = DateTime.Now.AddYears(2);
            sc.ExtendedWarrantyPremium = 50;
            sc.ExtendedWarrantyTransactionList.Add(new ExtendedWarrantyTransaction() { TransactionDateTime = DateTime.Now, TransactionGuid=Guid.NewGuid().ToString()});
            sc.PolicyNumber =  Guid.NewGuid().ToString().Substring(0,6).ToUpper();
            return sc;
        }
        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            var a = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        public class Test
        {
            public string RetailerName { get; set; }
            public string RetailerPrimaryContact { get; set; }
        }

        public class Test2
        {
            public string ProductName { get; set; }
            public string ProductType { get; set; }
        }

    }
}
