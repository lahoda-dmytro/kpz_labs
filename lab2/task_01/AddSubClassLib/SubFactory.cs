using SubClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddSubClassLib
{
    public interface SubFactory
    {
        Subscription CreateSubscription ();
    }
}
