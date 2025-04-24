using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class TextDocument
    {
        public string Content { get; private set; }

        public TextDocument(string content = "")
        {
            Content = content;
        }

        public void SetContent(string newContent)
        {
            Content = newContent;
        }

        public override string ToString() => Content;
    }
}
