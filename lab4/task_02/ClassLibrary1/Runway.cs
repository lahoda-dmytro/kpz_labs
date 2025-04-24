using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Runway : IRunway
    {
        public string Name { get; }
        public bool IsAvailable { get; private set; } = true;

        public Runway(string name)
        {
            Name = name;
        }

        public void Occupy()
        {
            IsAvailable = false;
            Console.WriteLine($"{Name} is now occupied.");
        }

        public void Vacate()
        {
            IsAvailable = true;
            Console.WriteLine($"{Name} is now available.");
        }
    }

}
