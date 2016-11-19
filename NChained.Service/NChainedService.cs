using NChained.Business;
using NChained.Business.Contract;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Caching;
using System.ServiceModel;

namespace NChained.Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class NChainedService : INChainedService
    {
        static IStore<ExtendedWarrantySmartContract> _ew = new Store<ExtendedWarrantySmartContract>();
        

        public NChainedService()
        {
 
        }

        public Product GetData(int arg)
        {
            return new Product() { ProductName = "test-"  + arg.ToString()};
        }

        public void SaveProduct(Product product)
        {

            var cache = MemoryCache.Default;
            if (cache["Products"] == null)
            {
                var pstore = new Store<Product>();

                cache["Products"] = pstore;
            }
            else
            {
                ((Store<Product>)cache["Products"]).Put(product);
            }           
        }     

        public IList<Product> GetProductsByName(string Name)
        {
            var cache = MemoryCache.Default;
            if (cache["Products"] == null)
            {
                var pstore = new Store<Product>();
                return ((Store<Product>)cache["Products"]).GetAll().ToList();
            }
            else
            {
             return  ((Store<Product>)cache["Products"]).GetAll().Where(x => x.ProductName == Name).ToList();
            }


        }

        public string GetMe()
        {
            return "This has no args";
        }


        public IList<Customer> GetCustomerByName(string name)
        {
            var cache = MemoryCache.Default;
            if (cache["Customers"] == null)
            {
                var pstore = new Store<Product>();
                return ((Store<Customer>)cache["Customers"]).GetAll().ToList();
            }
            else
            {
                return ((Store<Customer>)cache["Customers"]).GetAll().Where(x => x.Name == name).ToList();
            }

        }

        public void SaveCustomer(Customer customer)
        {
            var cache = MemoryCache.Default;
            if (cache["Customers"] == null)
            {
                var pstore = new Store<Customer>();

                cache["Customers"] = pstore;
            }
            else
            {
                ((Store<Customer>)cache["Customers"]).Put(customer);
            }

        }

        public IList<Product> GetAllProducts()
        {
            var cache = MemoryCache.Default;
            if (cache["Products"] == null)
            {
                cache["Products"] = new Store<Product>();
                return ((Store<Product>)cache["Products"]).GetAll().ToList();
            }
            else
            {
                return ((Store<Product>)cache["Products"]).GetAll();
            }
        }

        public IList<Customer> GetAllCustomers()
        {
            var cache = MemoryCache.Default;
            if (cache["Customers"] == null)
            {
                var pstore = new Store<Customer>();
                return ((Store<Customer>)cache["Customers"]).GetAll().ToList();
            }
            else
            {
                return ((Store<Customer>)cache["Customers"]).GetAll().ToList();
            }
        }
    }
}
