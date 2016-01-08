using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace PingWebsite
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up a new variable that pings.
            var ping = new Ping(); 

            // Asks the user what website they want to ping.
            Console.WriteLine("What website do you want to check? Example(www.google.co.uk)");
            // Records their input.
            var website = Console.ReadLine();
            // Records the result of the ping.
            var result = ping.Send(website);
            // Set up an if else statement for if it fails or not.
            if (result.Status != IPStatus.Success)
            {
                // If fails website is down.
                Console.WriteLine("Website is Down.");
            } else
            {
                // If anything else i.e suceeds prints it is up.
                Console.WriteLine("Website is Up.");
            }

            // Stops program from terminating.
            Console.ReadLine();
        }
    }
}
