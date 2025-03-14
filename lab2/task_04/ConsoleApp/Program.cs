using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Virus parent = new Virus("Alpha", "Type A", 5, 2.5);
            Virus child1 = new Virus("Beta", "Type B", 2, 1.2);
            Virus child2 = new Virus("Gamma", "Type C", 3, 1.8);
            Virus grandchild = new Virus("Delta", "Type D", 1, 0.9);

            child1.AddChild(grandchild);
            parent.AddChild(child1);
            parent.AddChild(child2);

            Console.WriteLine("Original Virus Family:");
            parent.Print();

            Virus clonedParent = (Virus)parent.Clone();
            Console.WriteLine("\nCloned Virus Family:");
            clonedParent.Print();
        }
    }
}
