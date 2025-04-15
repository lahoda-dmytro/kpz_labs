using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class HeroDecorator : Hero
    {
        protected Hero hero;

        public HeroDecorator(Hero hero, int hp = 0, int mana = 0, int atk = 0, int spell = 0)
            : base(hero.Name, hero.HP + hp, hero.Mana + mana, hero.AttackDamage + atk, hero.SpellPower + spell)
        {
            this.hero = hero;
            Inventory = new List<string>(hero.Inventory);
        }

        protected void AddItem(string item)
        {
            Inventory.Add(item);
        }

        public override string ToString()
        {
            return $"{base.ToString()}; Inventory: {(Inventory.Count > 0 ? string.Join(", ", Inventory) : "empty")}";
        }
    }
}
