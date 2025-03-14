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
            Console.OutputEncoding = Encoding.UTF8;

            SubFactory subFactory = new WebSite();
            var website = subFactory.CreateSubscription();
            PrintSubscriptionDetails(website);


            subFactory = new MobileApp();
            var mobileApp = subFactory.CreateSubscription();
            PrintSubscriptionDetails(mobileApp);


            subFactory = new ManagerCall();
            var managerCall = subFactory.CreateSubscription();
            PrintSubscriptionDetails(managerCall);


        }

        static void PrintSubscriptionDetails(Subscription subscription)
        {
            Console.WriteLine($"Підписка: {subscription.Name}");
            Console.WriteLine($"Щомісячна плата: {subscription.Price} $");
            Console.WriteLine($"Мінімальний період підписки: {subscription.MinPeriod} місяців");
            Console.WriteLine($"Канали: {string.Join(", ", subscription.Channels)}");
            Console.WriteLine();
        }
    }
}
