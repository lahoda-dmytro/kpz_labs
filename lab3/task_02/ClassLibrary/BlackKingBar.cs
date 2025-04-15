using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BlackKingBar : HeroDecorator
    {
        public BlackKingBar(Hero hero) : base(hero, atk: 25)
        {
            AddItem("Black King Bar");
        }
    }

}
