using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AddSubClassLib;
using SubClassLib;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SubFactory subFactory = new WebSite();
            var website = subFactory.CreateSubscription();

            subFactory = new MobileApp();
            var mobileApp = subFactory.CreateSubscription();

            subFactory = new ManagerCall();
            var managerCall = subFactory.CreateSubscription();

            Console.WriteLine($"DomesticSubscription Price: {website.Price}"); 
        }
    }
}
