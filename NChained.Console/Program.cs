using NChained.Console.NChainedService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NChained.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var sc = new NChainedService.NChainedServiceClient("BasicHttpBinding_INChainedService");
            var s = sc.GetData(42);


           System.Console.WriteLine(s);


            for (int i = 0; i < 5; i++)
            {
                sc.SaveProduct(new Product() { ProductName = "product_" + i.ToString() });
            }

            var product = sc.GetProductsByName("product_4").FirstOrDefault();
            System.Console.WriteLine(product.ProductName);

            System.Console.ReadLine();
        }
    }
}
