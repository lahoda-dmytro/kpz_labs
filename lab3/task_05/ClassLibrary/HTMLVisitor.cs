using System;
using System.Text;

namespace ClassLibrary
{
    public interface IHTMLVisitor
    {
        void Visit(LightElementNode element);
        void Visit(LightTextNode text);
    }

    // Modify base class to support visitor
    public abstract partial class LightNode
    {
        public abstract void Accept(IHTMLVisitor visitor);
    }

    // Extend LightElementNode to support visitor
    public partial class LightElementNode
    {
        public override void Accept(IHTMLVisitor visitor)
        {
            visitor.Visit(this);
            foreach (var child in Children)
            {
                child.Accept(visitor);
            }
        }
    }

    // Extend LightTextNode to support visitor
    public partial class LightTextNode : LightNode
    {
        public override void Accept(IHTMLVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    // Concrete visitors
    public class HTMLStatisticsVisitor : IHTMLVisitor
    {
        public int ElementCount { get; private set; }
        public int TextNodeCount { get; private set; }
        public int TotalCharacters { get; private set; }

        public void Visit(LightElementNode element)
        {
            ElementCount++;
        }

        public void Visit(LightTextNode text)
        {
            TextNodeCount++;
            TotalCharacters += text.Text.Length;
        }

        public override string ToString()
        {
            return $"Statistics:\nElements: {ElementCount}\nText Nodes: {TextNodeCount}\nTotal Characters: {TotalCharacters}";
        }
    }

    public class HTMLMinifierVisitor : IHTMLVisitor
    {
        private readonly StringBuilder minifiedHtml = new StringBuilder();

        public void Visit(LightElementNode element)
        {
            string classAttr = element.CssClasses.Count > 0 ? $" class=\"{string.Join(" ", element.CssClasses)}\"" : "";
            string styleAttr = $" style=\"display: {element.Display.ToString().ToLower()};\"";

            if (element.Closing == ClosingType.Single)
            {
                minifiedHtml.Append($"<{element.TagName}{classAttr}{styleAttr}/>");
            }
            else
            {
                minifiedHtml.Append($"<{element.TagName}{classAttr}{styleAttr}>");
            }
        }

        public void Visit(LightTextNode text)
        {
            minifiedHtml.Append(text.Text.Trim());
        }

        public string GetMinifiedHTML()
        {
            return minifiedHtml.ToString();
        }
    }
} 