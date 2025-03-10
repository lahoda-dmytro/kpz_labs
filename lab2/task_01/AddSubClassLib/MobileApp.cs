using SubClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddSubClassLib
{
    public class MobileApp : SubFactory
    {
        public Subscription CreateSubscription() => new PremiumSubscription();

    }
}
