using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DnD_Charactor_Creator.Src.Enumerators;

namespace DnD_Charactor_Creator.Src.Models
{
    public class Character
    {

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public uint Age { get; set; } = default;

        public Races Race { get; set; } = default;

        public CharacterLooks Looks { get; set; } = default;

        // Legend:             STR DEX CON INT WIS CHR
        public int[] Stats = { 10, 10, 10, 10, 10, 10 };

        public GameClasses Class { get; set; } = default;

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
             * For the point array [ (10, 1), (11, 1), (12, 2), (13, 2), (14, 3), ... ]
             * The linear function f(x) = 0.5 * x - 5 gets the corret distribution of
             * values, such that for every jump of x + 2 get a f(x-2) + 1
             * Basically: x: 8 = -1, x: 9 = -1, x: 10 = 0, x: 11 = 0, x: 12 = 2 and so on.
            */

            float a = .5f;
            float b = -5;

            // Lambda function that calcs the ability score.
            Func<int, int> calcAbilityScore = (value) => (int)Math.Floor(a * value + b);

            int abilityValue = Stats[(int)ability];

            return calcAbilityScore(abilityValue);
        }

    }

    public struct CharacterLooks
    {
    }
}
