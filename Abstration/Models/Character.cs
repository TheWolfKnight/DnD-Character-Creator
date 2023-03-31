using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstraction.Enumerators;

namespace Abstraction.Models
{
    public class Character
    {
        #region Name

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public string FullName { get => $"{FirstName} {LastName}"; }

        public void SetFullName(string fullName)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Race Description

        public Races Race { get; set; } = default;
        public string SubSpecies { get; set; } = null!;

        #endregion

        #region Alignment and Faith

        public Alignment CharactreAlignemt { get; set; } = default;
        public Lifestyles Lifestyle { get; set; } = default;
        public string Faith { get; set; } = null!;

        #endregion

        #region Character Description

        public Characteristics Looks { get; set; } = default;
        public uint Age { get; set; } = default;
        public Sizes Size { get; set; } = default;

        private const int V = 2;

        #endregion

        #region Gameplay stats

        private readonly int[] LVL_EXP_TABLE = { 0, 300, 900, 2700, 6500, 14000, 23000, 34000, 48000, 64000, 85000, 100000, 120000, 140000, 165000, 195000, 225000, 305000, 355000 };

        public int ProficienciesBouns = 2;
        public int PlayerLevel = 1;
        public int Exp = 0;
        // Legend:             STR DEX CON INT WIS CHR
        public int[] Stats = { 10, 10, 10, 10, 10, 10 };
        public GameClasses Class { get; set; } = default;

        public int GetEXPToNextLvl() =>
            PlayerLevel > 20 ? LVL_EXP_TABLE[PlayerLevel + 1] : 0;

        #endregion

        public Character()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ability"></param>
        /// <returns></returns>
        public int GetAbilityValue(Abilities ability)
        {
            return Stats[(int)ability];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ability"></param>
        /// <returns></returns>
        public int GetAbilityScore(Abilities ability)
        {
            /*
             * For the point array [ ..., (10, 1), (11, 1), (12, 2), (13, 2), (14, 3), ... ]
             * The linear function f(x) = 0.5 * x - 5 gets the corret distribution of
             * values, such that for every jump of x + 2 get a f(x + 2) = f(x) + 1
             * Basically: x: 8 = -1, x: 9 = -1, x: 10 = 0, x: 11 = 0, x: 12 = 2 and so on.
            */

            float a = .5f;
            float b = -5;

            // Lambda function that calcs the ability score.
            int calcAbilityScore(int value) => (int)Math.Floor(a * value + b);

            int abilityValue = Stats[(int)ability];

            return calcAbilityScore(abilityValue);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="proficiency"></param>
        /// <returns></returns>
        public int GetSkillScore(Proficiency proficiency)
        {
            int modifier = 1;
            if (Class == GameClasses.Bard || Class == GameClasses.Rouge)
                modifier++;

            int profBouns = ProficienciesBouns * modifier;

            return GetAbilityScore(proficiency.AssociatedStat) + profBouns * proficiency.Proficient;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        public void AddExp(int amount)
        {

            if (PlayerLevel == LVL_EXP_TABLE.Length)
                return;

            if (Exp > LVL_EXP_TABLE[PlayerLevel+1])
            {
                Level();
            }

            Exp += amount;
        }

        private int Level(byte amount=1, bool allowEpic=false)
        {
            throw new NotImplementedException();
        }
    }

    public struct Characteristics
    {
        public string Hair { get; set; }
        public Eyes Eyes { get; set; }
        public string Skin { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public Genders Gender { get; set; }
    }

    public struct Eyes
    {
        public string LeftEye { get; set; }
        public string RightEye { get; set; }

        public Eyes(string color)
        {
            LeftEye = color;
            RightEye = color;
        }

        public Eyes(string left, string right)
        {
            LeftEye = left;
            RightEye = right;
        }
    }
}
