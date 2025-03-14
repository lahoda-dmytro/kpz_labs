using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class HeroBuilder : ICharacterBuilder
    {
        private Character _character = new Character();

        public HeroBuilder(string name)
        {
            _character.Name = name;
        }

        public ICharacterBuilder SetHeight(double height) { _character.Height = height; return this; }
        public ICharacterBuilder SetBodyType(string bodyType) { _character.BodyType = bodyType; return this; }
        public ICharacterBuilder SetHairColor(string hairColor) { _character.HairColor = hairColor; return this; }
        public ICharacterBuilder SetEyeColor(string eyeColor) { _character.EyeColor = eyeColor; return this; }
        public ICharacterBuilder SetClothing(string clothing) { _character.Clothing = clothing; return this; }
        public ICharacterBuilder AddItemToInventory(string item) { _character.Inventory.Add(item); return this; }
        public ICharacterBuilder AddAction(string action) { _character.Actions.Add(action); return this; }

        public Character Build() { return _character; }
    }
}
