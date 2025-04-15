using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class EnemyBuilder : CharacterBuilder
    {
        private Character _character = new Character();

        public EnemyBuilder(string name)
        {
            _character.Name = name;
        }

        public CharacterBuilder SetHeight(double height) { _character.Height = height; return this; }
        public CharacterBuilder SetBodyType(string bodyType) { _character.BodyType = bodyType; return this; }
        public CharacterBuilder SetHairColor(string hairColor) { _character.HairColor = hairColor; return this; }
        public CharacterBuilder SetEyeColor(string eyeColor) { _character.EyeColor = eyeColor; return this; }
        public CharacterBuilder SetClothing(string clothing) { _character.Clothing = clothing; return this; }
        public CharacterBuilder AddItemToInventory(string item) { _character.Inventory.Add(item); return this; }
        public CharacterBuilder AddAction(string action) { _character.Actions.Add(action); return this; }

        public Character Build() { return _character; }
    }
}
