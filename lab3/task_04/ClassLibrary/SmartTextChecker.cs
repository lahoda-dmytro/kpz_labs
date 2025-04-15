using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SmartTextChecker : ISmartTextReader
    {
        private readonly ISmartTextReader reader;

        public SmartTextChecker(ISmartTextReader reader)
        {
            this.reader = reader;
        }

        public char[][] ReadText(string path)
        {
            Console.WriteLine($"Opening file: {path}");
            char[][] result = reader.ReadText(path);
            Console.WriteLine("File read successfully.");
            Console.WriteLine($"Total lines: {result.Length}");

            int totalChars = 0;
            foreach (var line in result)
                totalChars += line.Length;

            Console.WriteLine($"Total characters: {totalChars}");
            Console.WriteLine("File closed.");

            return result;
        }
    }

}
