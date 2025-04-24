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
    }


}
