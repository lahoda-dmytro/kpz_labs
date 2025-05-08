using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class LightNode
    {
        // Template Method pattern
        public virtual void OnCreated() { }
        public virtual void OnInserted() { }
        public virtual void OnRemoved() { }
        public virtual void OnStylesApplied() { }
        public virtual void OnClassListApplied() { }
        public virtual void OnTextRendered() { }

        // Template method that defines the rendering algorithm
        public string Render(int indent = 0)
        {
            OnCreated();
            var result = OuterHTML(indent);
            OnTextRendered();
            return result;
        }

        public abstract string OuterHTML(int indent = 0);
        public abstract string InnerHTML(int indent = 0);
    }
}
