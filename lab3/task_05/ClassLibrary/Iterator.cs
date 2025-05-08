using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public interface IIterator
    {
        bool HasNext();
        LightNode Next();
        void Reset();
    }

    public class DepthIterator : IIterator
    {
        private readonly LightNode root;
        private readonly Stack<LightNode> stack;

        public DepthIterator(LightNode root)
        {
            this.root = root;
            this.stack = new Stack<LightNode>();
            Reset();
        }

        public bool HasNext()
        {
            return stack.Count > 0;
        }

        public LightNode Next()
        {
            if (!HasNext())
                throw new InvalidOperationException("немає більше елементів");

            var current = stack.Pop();

            if (current is LightElementNode elementNode)
            {
                // додаємо дітей в зворотньому порядку
                for (int i = elementNode.Children.Count - 1; i >= 0; i--)
                {
                    stack.Push(elementNode.Children[i]);
                }
            }

            return current;
        }

        public void Reset()
        {
            stack.Clear();
            if (root != null)
                stack.Push(root);
        }
    }

    public class BreadthIterator : IIterator
    {
        private readonly LightNode root;
        private readonly Queue<LightNode> queue;

        public BreadthIterator(LightNode root)
        {
            this.root = root;
            this.queue = new Queue<LightNode>();
            Reset();
        }

        public bool HasNext()
        {
            return queue.Count > 0;
        }

        public LightNode Next()
        {
            if (!HasNext())
                throw new InvalidOperationException("немає більше елементів");

            var current = queue.Dequeue();

            if (current is LightElementNode elementNode)
            {
                foreach (var child in elementNode.Children)
                {
                    queue.Enqueue(child);
                }
            }

            return current;
        }

        public void Reset()
        {
            queue.Clear();
            if (root != null)
                queue.Enqueue(root);
        }
    }
} 