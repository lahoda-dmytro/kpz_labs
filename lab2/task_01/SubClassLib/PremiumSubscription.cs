using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubClassLib
{
    public class PremiumSubscription  : Subscription
    {
        public decimal Price => 20;
        public int MinPeriod => 6;
        public List<string> Channels => new List<string> { "BBC", "CNN", "MTV", "Discovery", "National Geographic", "History" };

    }
}
