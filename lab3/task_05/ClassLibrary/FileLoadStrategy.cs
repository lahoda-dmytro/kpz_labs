using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FileLoadStrategy : IImageLoadStrategy
    {
        public string Load(string href) => $"[Loaded from file]: {href}";
    }

}
