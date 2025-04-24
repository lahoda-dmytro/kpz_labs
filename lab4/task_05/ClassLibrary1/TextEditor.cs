using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class TextEditor
    {
        private TextDocument _document;
        private Stack<DocumentMemento> _history = new Stack<DocumentMemento>();

        public TextEditor(TextDocument document)
        {
            _document = document;
        }

        public void Write(string newContent)
        {
            Save();
            _document.SetContent(newContent);
        }

        public void Save()
        {
            _history.Push(new DocumentMemento(_document.Content));
        }

        public void Undo()
        {
            if (_history.Count > 0)
            {
                var memento = _history.Pop();
                _document.SetContent(memento.ContentSnapshot);
            }
            else
            {
                Console.WriteLine("Nothing to undo.");
            }
        }

        public void Print() => Console.WriteLine(_document.ToString());
    }
}
