using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class LightElementFactory
    {
        private readonly Dictionary<string, LightElementNode> _cache = new Dictionary<string, LightElementNode>();

        public LightElementNode GetElement(string tag, DisplayType display, ClosingType closing)
        {
            string key = $"{tag}-{display}-{closing}";
            if (!_cache.ContainsKey(key))
            {
                var element = new LightElementNode(tag, display, closing);
                _cache[key] = element;
            }

            var baseElement = _cache[key];
            return new LightElementNode(baseElement.TagName, baseElement.Display, baseElement.Closing);
        }

        public int CacheSize => _cache.Count;
    }

}
