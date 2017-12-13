using System;
using Microsoft.Owin.Hosting;

namespace WebApiServerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            const string baseAddress = "http://localhost:9000/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.Out.WriteLine("Rest api is running on: " + baseAddress);
                Console.ReadLine();
            }
        }
    }

}
