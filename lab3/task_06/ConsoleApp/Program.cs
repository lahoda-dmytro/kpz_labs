using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var url = "https://www.gutenberg.org/cache/epub/1513/pg1513.txt";
            var lines = await DownloadBookAsync(url);

            var factory = new LightElementFactory();
            var root = new LightElementNode("div", DisplayType.Block, ClosingType.Pair);
            root.AddClass("book");

            long memoryBefore = GC.GetTotalMemory(true);

            for (int i = 0; i < lines.Count; i++)
            {
                var line = lines[i].Trim();
                if (string.IsNullOrWhiteSpace(line)) continue;

                string tag;
                DisplayType display = DisplayType.Block;

                if (i == 0)
                {
                    tag = "h1";
                }
                else if (line.Length < 20)
                {
                    tag = "h2";
                }
                else if (char.IsWhiteSpace(lines[i][0]))
                {
                    tag = "blockquote";
                }
                else
                {
                    tag = "p";
                }

                var element = factory.GetElement(tag, display, ClosingType.Pair);
                element.AddChild(new LightTextNode(line));
                root.AddChild(element);
            }

            long memoryAfter = GC.GetTotalMemory(true);
            long memoryUsed = memoryAfter - memoryBefore;

            string outputPath = Path.Combine(Directory.GetCurrentDirectory(), "outputBooks.html");
            File.WriteAllText(outputPath, root.OuterHTML());

            Console.WriteLine($"HTML файл збережено за адресою: {outputPath}");
            Console.WriteLine($"\nFlyweight tag cache size: {factory.CacheSize}");
            Console.WriteLine($"Memory used (approx): {memoryUsed / 1024.0:F2} KB");
        }

        static async Task<List<string>> DownloadBookAsync(string url)
        {
            using (var httpClient = new HttpClient())
            {
                var content = await httpClient.GetStringAsync(url);
                var lines = content.Split('\n').Select(line => line.TrimEnd('\r')).ToList();
                return lines;
            }
        }
    }
}
