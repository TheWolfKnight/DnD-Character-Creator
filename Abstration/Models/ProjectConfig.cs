using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Models
{
    public class ProjectConfig
    {
        public string RootDir { get; set; } = string.Empty;
        public string CharDir { get; set; } = string.Empty;
        public string ItemDir { get; set; } = string.Empty;
        public string SpellDir { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;

        public ProjectConfig(string rootDir, string charDir, string itemDir, string spellDir, string imagePath)
        {
            RootDir = rootDir;
            CharDir = charDir;
            ItemDir = itemDir;
            SpellDir = spellDir;
            ImagePath = imagePath;
        }
    }
}
