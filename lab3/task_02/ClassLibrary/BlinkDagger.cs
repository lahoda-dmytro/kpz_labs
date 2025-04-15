using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BlinkDagger : HeroDecorator
    {
        public BlinkDagger(Hero hero) : base(hero)
        {
            AddItem("Blink Dagger");
        }
    }

}
