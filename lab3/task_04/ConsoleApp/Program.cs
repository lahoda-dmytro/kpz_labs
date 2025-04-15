using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string allowedFile = "allowedFile.txt";
            string restrictedFile = "restrictedFile.txt";

            File.WriteAllLines(allowedFile, new[] {"allowedFile" });
            File.WriteAllLines(restrictedFile, new[] {"restrictedFile" });

            ISmartTextReader baseReader = new SmartTextReader();

            ISmartTextReader checker = new SmartTextChecker(baseReader);

            ISmartTextReader locker = new SmartTextReaderLocker(checker, ".*restricted.*");

            Console.WriteLine("Reading allowed file");
            locker.ReadText(allowedFile);

            Console.WriteLine("\nReading restricted file");
            locker.ReadText(restrictedFile);
        }
    }
}
