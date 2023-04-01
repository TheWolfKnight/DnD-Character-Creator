using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstraction.Enumerators;
using Abstraction.Interface;

namespace Abstraction.Models
{
    public class GameClasses
    {
        #region Descriptors

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string HitDie { get; set; } = string.Empty;

        #endregion

        #region Ability score

        public Abilities[] PrimaryAbilities { get; set; } = null!;
        public Abilities[] Saves { get; set; } = null!;

        #endregion

        #region Features

        public IFeatures[] Features { get; set; } = null!;

        #endregion

        public bool HasSkillModifier = false;

    }
}
