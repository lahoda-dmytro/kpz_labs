using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DocumentMemento
    {
        public string ContentSnapshot { get; }

        public DocumentMemento(string content)
        {
            ContentSnapshot = content;
        }
    }
}
