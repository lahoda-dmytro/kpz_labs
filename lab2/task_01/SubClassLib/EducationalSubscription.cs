using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubClassLib
{
    public class EducationalSubscription : Subscription
    {
        public decimal Price => 5;
        public int MinPeriod => 3;
        public List<string> Channels => new List<string> { "Discovery", "National Geographic", "History" };


    }
}
