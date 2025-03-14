using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CharacterDirector director = new CharacterDirector();

            Character hero = director.ConstructHero(new HeroBuilder("Pudge"));
            Character enemy = director.ConstructEnemy(new EnemyBuilder("Shadow Fiend"));

            Console.WriteLine("hero:");
            hero.Print();

            Console.WriteLine("enemy:");
            enemy.Print();
        }
    }
}
