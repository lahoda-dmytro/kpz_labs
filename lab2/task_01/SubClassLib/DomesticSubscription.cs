using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SubClassLib
{
    public class DomesticSubscription : Subscription
    {
        public decimal Price => 10;
        public int MinPeriod => 1;
        public List<string> Channels => new List<string> { "BBC", "CNN", "MTV" };


    }
}
