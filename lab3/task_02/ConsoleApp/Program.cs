using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero sf = new HeroPalladin("ShadowFiend");
            Hero cm = new HeroMage("CrystalMaiden");
            Hero dk = new HeroWarrior("DragonKnight");

            Console.WriteLine(sf);
            Console.WriteLine(cm);
            Console.WriteLine(dk);
            Console.WriteLine();

            sf = new PowerTreads(sf);
            sf = new BlackKingBar(sf);

            cm = new AghanimsScepter(cm);
            cm = new BlinkDagger(cm);

            dk = new PowerTreads(dk);
            dk = new HeartOfTarrasque(dk);
            dk = new BlackKingBar(dk);

            Console.WriteLine(sf);
            Console.WriteLine(cm);
            Console.WriteLine(dk);
        }
    }

}
