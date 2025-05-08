using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public interface IHTMLCommand
    {
        void Execute();
        void Undo();
    }

    public class AddClassCommand : IHTMLCommand
    {
        private readonly LightElementNode element;
        private readonly string className;

        public AddClassCommand(LightElementNode element, string className)
        {
            this.element = element;
            this.className = className;
        }

        public void Execute()
        {
            element.AddClass(className);
            element.OnClassListApplied();
        }

        public void Undo()
        {
            element.CssClasses.Remove(className);
            element.OnClassListApplied();
        }
    }

    public class AddChildCommand : IHTMLCommand
    {
        private readonly LightElementNode parent;
        private readonly LightNode child;

        public AddChildCommand(LightElementNode parent, LightNode child)
        {
            this.parent = parent;
            this.child = child;
        }

        public void Execute()
        {
            parent.AddChild(child);
            child.OnInserted();
        }

        public void Undo()
        {
            parent.Children.Remove(child);
            child.OnRemoved();
        }
    }

    public class CommandInvoker
    {
        private readonly Stack<IHTMLCommand> undoStack = new Stack<IHTMLCommand>();
        private readonly Stack<IHTMLCommand> redoStack = new Stack<IHTMLCommand>();

        public void ExecuteCommand(IHTMLCommand command)
        {
            command.Execute();
            undoStack.Push(command);
            redoStack.Clear(); // Clear redo stack when new command is executed
        }

        public void Undo()
        {
            if (undoStack.Count > 0)
            {
                var command = undoStack.Pop();
                command.Undo();
                redoStack.Push(command);
            }
        }

        public void Redo()
        {
            if (redoStack.Count > 0)
            {
                var command = redoStack.Pop();
                command.Execute();
                undoStack.Push(command);
            }
        }
    }
} 