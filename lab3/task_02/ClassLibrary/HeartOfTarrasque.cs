using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class HeartOfTarrasque : HeroDecorator
    {
        public HeartOfTarrasque(Hero hero) : base(hero, hp: 500)
        {
            AddItem("Heart of Tarrasque");
        }
    }

}
