using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubClassLib
{
    public interface Subscription
    {

        string Name { get; }
        decimal Price { get; }
        int MinPeriod { get; }
        List<string> Channels { get; }


    }
}
