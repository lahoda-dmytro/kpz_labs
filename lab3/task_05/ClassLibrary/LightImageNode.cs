using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LightImageNode : LightNode
    {
        public string Href { get; }
        private readonly IImageLoadStrategy _loadStrategy;

        public LightImageNode(string href, IImageLoadStrategy strategy)
        {
            Href = href;
            _loadStrategy = strategy;
        }

        public override string OuterHTML(int indent = 0)
        {
            string indentStr = new string(' ', indent);
            string comment = _loadStrategy.Load(Href);
            return $"{indentStr}<img src=\"{Href}\" alt=\"image\" /> <!-- {comment} -->";
        }

        public override string InnerHTML(int indent = 0) => "";
    }

}
