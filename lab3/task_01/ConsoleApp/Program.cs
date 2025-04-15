using ClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            logger.Log("Some message");
            logger.Error("Error message");
            logger.Warn("Warn message");

            string logsPath = Path.Combine(Directory.GetCurrentDirectory(), "logs", "logs.txt");
            Console.WriteLine(logsPath);

            FileLoggerAdapter fileLogger = new FileLoggerAdapter(logsPath);


            try
            {
                fileLogger.Log("Some message");
                fileLogger.Error("Error message");
                fileLogger.Warn("Warn message");
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error: {e}");
            }
        }
    }
}
