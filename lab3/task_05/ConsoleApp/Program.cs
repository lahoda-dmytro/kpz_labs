using ClassLibrary;
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
            var div = new LightElementNode("div", DisplayType.Block, ClosingType.Pair);
            div.AddClass("container");

            //var h1 = new LightElementNode("h1", DisplayType.Block, ClosingType.Pair);
            //h1.AddChild(new LightTextNode("My LightHTML!"));

            //var ul = new LightElementNode("ul", DisplayType.Inline, ClosingType.Pair);
            //ul.AddChild(new LightTextNode("Welcome to a home page!"));

            //div.AddChild(h1);
            //div.AddChild(ul);

            var logger = new ConsoleLoggerListener();
            div.AddEventListener("click", logger);
            div.AddEventListener("mouseover", logger);

            div.TriggerEvent("click");
            div.TriggerEvent("mouseover");

            Console.WriteLine(div.OuterHTML());
        }
    }
}
