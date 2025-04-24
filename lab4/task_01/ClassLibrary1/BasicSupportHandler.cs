using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class BasicSupportHandler : SupportHandler
    {
        public override void HandleRequest(string request)
        {
            if (request.Contains("password") || request.Contains("login"))
            {
                Console.WriteLine("Basic Support: Handled your request.");
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
