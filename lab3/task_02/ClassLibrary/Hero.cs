using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Hero
    {
        public string Name { get; protected set; }
        public virtual int HP { get; protected set; }
        public virtual int Mana { get; protected set; }
        public virtual int AttackDamage { get; protected set; }
        public virtual int SpellPower { get; protected set; }
        public virtual List<string> Inventory { get; protected set; } = new List<string>();

        public Hero(string name, int hp, int mana, int atk, int spell)
        {
            Name = name;
            HP = hp;
            Mana = mana;
            AttackDamage = atk;
            SpellPower = spell;
        }

        public override string ToString()
        {
            return $"{GetType().Name} {Name}: HP {HP}, Mana {Mana}, AD {AttackDamage}, SP {SpellPower}";
        }
    }
}
