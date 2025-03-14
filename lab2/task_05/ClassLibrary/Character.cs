using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Character
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public string BodyType { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothing { get; set; }
        public List<string> Inventory { get; set; } = new List<string>();
        public List<string> Actions { get; set; } = new List<string>();

        public void Print()
        {
            Console.WriteLine($"Character: {Name}\nHeight: {Height}\nBody Type: {BodyType}\nHair Color: {HairColor}\nEye Color: {EyeColor}\nClothing: {Clothing}\nInventory: {string.Join(", ", Inventory)}\nActions: {string.Join(", ", Actions)}\n");
        }
    }
}
