using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ConsoleLoggerListener : IEventListener
    {
        public void HandleEvent(string eventType, LightElementNode source)
        {
            Console.WriteLine($"[LOG] Event '{eventType}' triggered on <{source.TagName}> element.");
        }
    }

}
