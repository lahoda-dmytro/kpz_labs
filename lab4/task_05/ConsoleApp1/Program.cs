using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var document = new TextDocument("Initial content");
            var editor = new TextEditor(document);

            editor.Print(); // Initial content

            editor.Write("First edit");
            editor.Print();

            editor.Write("Second edit");
            editor.Print(); 

            editor.Undo();
            editor.Print(); // First edit

            editor.Undo();
            editor.Print(); // Initial content

            editor.Undo(); // Nothing to undo.
        }
    }
}
