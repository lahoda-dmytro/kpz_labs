using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class SupportHandler
    {
        protected SupportHandler next;

        public void SetNext(SupportHandler nextHandler)
        {
            next = nextHandler;
        }

        public abstract void HandleRequest(string request);

    }
}
