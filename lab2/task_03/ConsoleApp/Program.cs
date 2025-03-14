using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(() => {
                var auth1 = Authenticator.Instance;
                auth1.Authenticate();
            });

            Thread thread2 = new Thread(() => {
                var auth2 = Authenticator.Instance;
                auth2.Authenticate();
            });

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();
        }
    }
}
