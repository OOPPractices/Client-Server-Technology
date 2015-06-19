using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace VECOHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(VECOService.VECOService)))
            {
                host.Open();
                Console.WriteLine("Service is up and running at : {0}", DateTime.Now.ToString());
                foreach (var ea in host.Description.Endpoints)
                {
                    Console.WriteLine(ea.Address);
                }
                Console.ReadLine();

                host.Close();
            }
        }
    }
}
