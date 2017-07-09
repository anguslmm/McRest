using Nancy.Hosting.Self;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace McRest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new NancyHost(new Uri("http://localhost:1234")))
            {
                host.Start();
                Console.WriteLine("Running on http://localhost:1234");
                Console.ReadLine();
                host.Stop();
            }
            //WebServiceHost host = new WebServiceHost(typeof(Service), new Uri("http://localhost:8000/"));
            //try
            //{
            //    ServiceEndpoint ep = host.AddServiceEndpoint(typeof(IService), new WebHttpBinding(), "");
            //    host.Open();
            //    using (ChannelFactory<IService> cf = new ChannelFactory<IService>(new WebHttpBinding(), "http://localhost:8000"))
            //    {
            //        cf.Endpoint.Behaviors.Add(new WebHttpBehavior());

            //        Console.WriteLine("Endpoints are up and running.");
            //        Console.WriteLine($"They are available at '{cf.Endpoint.Address}'");
            //        cf.Endpoint.Contract.Operations.ToList().ForEach(endpoint =>
            //        {
            //            Console.WriteLine($"Endpoint: '{endpoint.Name}'");
            //        });
            //        Console.WriteLine("");
            //    }

            //    Console.WriteLine("Press <ENTER> to terminate");
            //    Console.ReadLine();

            //    host.Close();
            //}
            //catch (CommunicationException cex)
            //{
            //    Console.WriteLine("An exception occurred: {0}", cex.Message);
            //    host.Abort();
            //}
        }
    }
}
