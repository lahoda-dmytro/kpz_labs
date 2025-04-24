using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class TechnicalSupportHandler : SupportHandler
    {
        public override void HandleRequest(string request)
        {
            if (request.Contains("bug") || request.Contains("error"))
            {
                Console.WriteLine("Technical Support: Issue registered.");
            }
            else if (next != null)
            {
                next.HandleRequest(request);
            }
            else
            {
                Console.WriteLine("No support level found. Please try again.");
            }
        }
    }
}
