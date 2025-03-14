using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Authenticator
    {
        private static readonly Lazy<Authenticator> instance =
        new Lazy<Authenticator>(() => new Authenticator(), LazyThreadSafetyMode.ExecutionAndPublication);

        private Authenticator()
        {
            Console.WriteLine("authenticator instance created");
        }

        public static Authenticator Instance => instance.Value;

        public void Authenticate()
        {
            Console.WriteLine("user authenticated");
        }
    }
}
