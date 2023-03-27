using Abstraction.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstration.Models
{
    public class Proficiency
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public Abilities AssociatedStat = default;
        public int Proficient = 0;

        public bool IsProficient { get => Proficient != 0; }

        public Proficiency(string name, string description, Abilities associatedStat, bool isProficient=false)
        {
            Name = name;
            Description = description;
            AssociatedStat = associatedStat;
            Proficient = isProficient ? 1 : 0;
        }
    }
}
