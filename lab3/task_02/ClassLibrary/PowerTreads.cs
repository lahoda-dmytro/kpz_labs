using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class PowerTreads : HeroDecorator
    {
        public PowerTreads(Hero hero) : base(hero, hp: 150, atk: 10)
        {
            AddItem("Power Treads");
        }
    }

}
