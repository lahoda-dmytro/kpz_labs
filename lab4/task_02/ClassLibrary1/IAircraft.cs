using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IAircraft
    {
        string Identifier { get; }
        void RequestTakeOff();
        void RequestLanding();
        void ReceiveClearance(string message);
    }
}
