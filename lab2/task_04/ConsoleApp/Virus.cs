using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Virus : ICloneable
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public List<Virus> Children { get; set; } = new List<Virus>();

        public Virus(string name, string type, int age, double weight)
        {
            Name = name;
            Type = type;
            Age = age;
            Weight = weight;
        }

        public void AddChild(Virus child)
        {
            Children.Add(child);
        }

        public object Clone()
        {
            var clonedVirus = new Virus(Name, Type, Age, Weight);
            foreach (var child in Children)
            {
                clonedVirus.Children.Add((Virus)child.Clone());
            }
            return clonedVirus;
        }

        public void Print(string indent = "")
        {
            Console.WriteLine($"{indent}Virus: {Name}, Type: {Type}, Age: {Age}, Weight: {Weight}");
            foreach (var child in Children)
            {
                child.Print(indent);
            }
        }
    }
}
