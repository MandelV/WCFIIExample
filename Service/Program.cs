using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Service Configuration...");
            WSHttpBinding binding = new WSHttpBinding();
            binding.Name = "Binding1";
            binding.HostNameComparisonMode = HostNameComparisonMode.StrongWildcard;
            binding.ReliableSession.Enabled = false;
            binding.TransactionFlow = false;
            binding.Security.Mode = SecurityMode.Message;

           
            

            Uri url = new Uri(@"http://localhost:8080/services/bank");

            ServiceHost serviceHost = new ServiceHost(typeof(BankService), url);
            serviceHost.AddServiceEndpoint(typeof(IBank), binding, url);
   
            var meta = new ServiceMetadataBehavior();
            meta.HttpGetEnabled = true;
            serviceHost.Description.Behaviors.Add(meta);


            Console.WriteLine("Service is starting...");
            serviceHost.Open();

            Console.WriteLine("Service ready - Enter to close it");

            Console.ReadLine();

            serviceHost.Close();

            while (true)
            {

            }


        }
    }
}
