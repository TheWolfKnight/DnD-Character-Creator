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
    public class CharacteristicsBuilder : IBuilder<CharacteristicsBuilder, Characteristics>
    {
        private CharacteristicsBuilder()
        {
            throw new NotImplementedException();
        }

        public static CharacteristicsBuilder Builder()
        {
            throw new NotImplementedException();
        }

        public CharacteristicsBuilder SetHairColor(string color)
        {
            throw new NotImplementedException();
        }

        public CharacteristicsBuilder SetEyeColor(string left, string right)
        {
            throw new NotImplementedException();
        }

        public CharacteristicsBuilder SetSkinColor(string color)
        {
            throw new NotImplementedException();
        }

        public CharacteristicsBuilder SetHeight(string Height)
        {
            throw new NotImplementedException();
        }

        public CharacteristicsBuilder SetWeight(string weight)
        {
            throw new NotImplementedException();
        }

        public CharacteristicsBuilder SetGender(Genders gender)
        {
            throw new NotImplementedException();
        }

        public Characteristics Build()
        {
            throw new NotImplementedException();
        }
    }
}
