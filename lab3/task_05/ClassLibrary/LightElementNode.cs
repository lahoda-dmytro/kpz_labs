using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; }
        public DisplayType Display { get; }
        public ClosingType Closing { get; }

        public List<string> CssClasses { get; } = new List<string>();
        public List<LightNode> Children { get; } = new List<LightNode>();

        public LightElementNode(string tagName, DisplayType display, ClosingType closing)
        {
            TagName = tagName;
            Display = display;
            Closing = closing;
        }

        public void AddClass(string className) => CssClasses.Add(className);
        public void AddChild(LightNode child) => Children.Add(child);

        public override string OuterHTML(int indent = 0)
        {
            var sb = new StringBuilder();
            string indentStr = new string(' ', indent);
            string displayStyle = $"display: {Display.ToString().ToLower()};";
            string classAttr = CssClasses.Count > 0 ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";
            string styleAttr = $" style=\"{displayStyle}\"";

            if (Closing == ClosingType.Single)
            {
                sb.AppendLine($"{indentStr}<{TagName}{classAttr}{styleAttr} />");
            }
            else
            {
                sb.AppendLine($"{indentStr}<{TagName}{classAttr}{styleAttr}>");
                foreach (var child in Children)
                {
                    sb.AppendLine(child.OuterHTML(indent + 2));
                }
                sb.Append($"{indentStr}</{TagName}>");
            }

            return sb.ToString();
        }

        public override string InnerHTML(int indent = 0)
        {
            var sb = new StringBuilder();
            foreach (var child in Children)
            {
                sb.AppendLine(child.OuterHTML(indent));
            }
            return sb.ToString();
        }
    }

}
