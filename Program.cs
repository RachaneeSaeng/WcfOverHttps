using System;
using System.ServiceModel;

namespace WcfOverHttps
{
    class Program
    {
        static void Main(string[] args)
        {
            string address = "https://localhost:1234/HelloWorldService";

            ServiceHost host = new ServiceHost(typeof(SimpleService), new Uri(address));
            host.Open();

            Console.WriteLine("Host is opened.  Press enter to close.");
            Console.WriteLine();
            Console.WriteLine("Press <ENTER> to terminate service.");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}