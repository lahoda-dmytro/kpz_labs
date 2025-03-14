using FactoryClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory iPhoneFactory = new IPhoneFactory();
            Console.WriteLine("IPhone devices:");
            ShowDevicesInfo(iPhoneFactory);

            Console.WriteLine(" ");


            Factory xiaomiFactory = new XiaomiFactory();
            Console.WriteLine("xiaomi devices:");
            ShowDevicesInfo(xiaomiFactory);

            Console.WriteLine(" ");


            Factory galaxyFactory = new GalaxyFactory();
            Console.WriteLine("Galaxy devices:");
            ShowDevicesInfo(galaxyFactory);


        }

        static void ShowDevicesInfo(Factory factory)
        {
            Console.WriteLine(factory.CreateLaptop().Name());
            Console.WriteLine(factory.CreateSmartphone().Name());
        }
    }
}
