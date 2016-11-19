using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using Topshelf;

namespace NChained.Service.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x => {
                x.Service<INChainedServiceHost>(s =>
                {
                    s.ConstructUsing(name => new NChainedServiceHost());
                    s.WhenStarted(nc => nc.Start());
                    s.WhenStopped(nc => nc.Stop());
                });
            });
        }
    }


    
    [ServiceContract]
    public interface INChainedServiceHost
    {
        void Start();
        bool Stop();
        string Get(string arg);
    }

    public class NChainedServiceHost : INChainedServiceHost
    {
        ServiceHost serviceHost = null;

        public void Start()
        {
            System.Console.WriteLine("Starting Service");
            string serviceAddress = "http://localhost:8080";

            Uri baseAddress = new Uri(serviceAddress);
            if (serviceHost != null)
            {
                serviceHost.Close();
            }

            // Create a ServiceHost for the CalculatorService type and 
            // provide the base address.
            serviceHost = new ServiceHost(typeof(NChainedService), baseAddress);

            // Open the ServiceHostBase to create listeners and start 
            // listening for messages.
            serviceHost.Open();
        }

        public bool Stop()
        {
            System.Console.WriteLine("Stopping Service");
            serviceHost.Close();
            serviceHost = null;            
            return true;
        }

        public string Get(string arg)
        {
            return DateTime.Now.ToString() +arg;
        }

       
    }

}
