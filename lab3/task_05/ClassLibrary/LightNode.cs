using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class LightNode
    {
        public abstract string OuterHTML(int indent = 0);
        public abstract string InnerHTML(int indent = 0);

        // Шаблонний метод
        public void Create()
        {
            OnCreated();
            OnStylesApplied();
            OnClassListApplied();
        }

        protected virtual void OnCreated() { }
        protected virtual void OnStylesApplied() { }
        protected virtual void OnClassListApplied() { }
        protected virtual void OnTextRendered() { }
        protected virtual void OnInserted() { }
        protected virtual void OnRemoved() { }
        public virtual void AddChild(LightNode child)
        {
            child.OnInserted();
        }
    }
}
