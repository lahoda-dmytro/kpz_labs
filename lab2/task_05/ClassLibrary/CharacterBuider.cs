using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface CharacterBuilder
    {
        CharacterBuilder SetHeight(double height);
        CharacterBuilder SetBodyType(string bodyType);
        CharacterBuilder SetHairColor(string hairColor);
        CharacterBuilder SetEyeColor(string eyeColor);
        CharacterBuilder SetClothing(string clothing);
        CharacterBuilder AddItemToInventory(string item);
        CharacterBuilder AddAction(string action);
        Character Build();
    }
}
