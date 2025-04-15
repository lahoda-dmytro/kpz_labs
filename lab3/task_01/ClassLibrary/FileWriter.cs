using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ClassLibrary
{
    public class FileWriter
    {
        private string filePath;

        public FileWriter(string path)
        {
            filePath = path;

            string directory = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

        public void Write(string message)
        {
            File.AppendAllText(filePath, message);
        }

        public void WriteLine(string message)
        {
            File.AppendAllText(filePath, message + Environment.NewLine);
        }
    }
}
