using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SmartTextReaderLocker : ISmartTextReader
    {
        private readonly ISmartTextReader reader;
        private readonly Regex restrictedPattern;

        public SmartTextReaderLocker(ISmartTextReader reader, string pattern)
        {
            this.reader = reader;
            restrictedPattern = new Regex(pattern);
        }

        public char[][] ReadText(string path)
        {
            if (restrictedPattern.IsMatch(path))
            {
                Console.WriteLine("Access denied!");
                return Array.Empty<char[]>();
            }

            return reader.ReadText(path);
        }
    }

}
