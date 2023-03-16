using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Charactor_Creator.Src.Models
{
    public class ProjectStatus
    {
        public bool Loaded { get; set; }
        public string ConfigPath { get; set; }
        public Character Character { get; set; }

        public ProjectStatus(bool loaded, string configPath, Character character=null!)
        {
            Loaded = loaded;
            ConfigPath = configPath;
            Character = character;
        }
    }
}
