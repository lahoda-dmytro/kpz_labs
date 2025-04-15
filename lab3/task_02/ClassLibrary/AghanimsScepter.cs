using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class AghanimsScepter : HeroDecorator
    {
        public AghanimsScepter(Hero hero) : base(hero, hp: 200, mana: 150, spell: 25)
        {
            AddItem("Aghanim's Scepter");
        }
    }

}
