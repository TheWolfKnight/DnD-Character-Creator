using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_Charactor_Creator.Src.Models;
using DnD_Charactor_Creator.Src.Interface;
using DnD_Charactor_Creator.Src.Enumerators;

namespace DnD_Charactor_Creator.Src.Services
{
    public class CharacterBuilder : IBuilder<CharacterBuilder, Character>
    {

        private Character _Result = null!;

        private CharacterBuilder()
        {
            _Result = new Character();
        }

        public static CharacterBuilder Builder()
        {
            return new CharacterBuilder();
        }

        public CharacterBuilder SetFirstName(string firstName)
        {
            throw new NotImplementedException();
        }

        public CharacterBuilder SetLastName(string lastName)
        {
            throw new NotImplementedException();
        }

        public CharacterBuilder SetFullName(string fullName)
        {
            throw new NotImplementedException();
        }

        public CharacterBuilder SetAge(uint age)
        {
            throw new NotImplementedException();
        }

        public CharacterBuilder SetRace(Races race)
        {
            throw new NotImplementedException();
        }

        public CharacterBuilder SetLooks(Characteristics looks)
        {
            throw new NotImplementedException();
        }

        public CharacterBuilder SetAbilityValue(Abilities ability, int value)
        {
            throw new NotImplementedException();
        }

        public CharacterBuilder SetClass(GameClasses charClass)
        {
            throw new NotImplementedException();
        }

        public Character Build()
        {
            return _Result;
        }
    }
}
