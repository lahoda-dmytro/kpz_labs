using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var basic = new BasicSupportHandler();
            var advanced = new AdvancedSupportHandler();
            var tech = new TechnicalSupportHandler();
            var supervisor = new SupervisorSupportHandler();

            basic.SetNext(advanced);
            advanced.SetNext(tech);
            tech.SetNext(supervisor);

            while (true)
            {
                Console.WriteLine("\nenter issue ('exit' to quit):");
                string input = Console.ReadLine();
                if (input == "exit") break;

                basic.HandleRequest(input);
            }
        }

    }
}
