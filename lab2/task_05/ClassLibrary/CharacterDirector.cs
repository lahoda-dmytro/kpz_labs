using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CharacterDirector
    {
        public Character ConstructHero(CharacterBuilder builder)
        {
            return builder.SetHeight(1.70)
                          .SetBodyType("fat")
                          .SetHairColor("bald")
                          .SetEyeColor("white")
                          .SetClothing("apron")
                          .AddItemToInventory("mask of madness")
                          .AddAction("hook")
                          .Build();
        }

        public Character ConstructEnemy(CharacterBuilder builder)
        {
            return builder.SetHeight(1.85)
                          .SetBodyType("demon")
                          .SetHairColor("dark")
                          .SetEyeColor("red")
                          .SetClothing("no clothing")
                          .AddItemToInventory("shadow blade")
                          .AddAction("cast requiem")
                          .Build();
        }
    }

}
