using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class SupervisorSupportHandler : SupportHandler
    {
        public override void HandleRequest(string request)
        {
            Console.WriteLine("Supervisor: Final handler reached.");
        }
    }
}
