using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

using Abstraction.Models;

namespace DnD_Character_Creator.ViewModels
{
    public class MainWindowViewModel
    {

        private Character _Character { get; set; } = null!;
        private string _Path { get; set; } = "";

        public MainWindowViewModel()
        {
        }

        public string GetCharacterImagePath
        {
            get => _Path;
            set => _Path = value;
        }

        public string GetCharacterName
        {
            get => _Character.FullName;
            set => _Character.SetFullName(value);
        }

        public string GetExpToNextLvlString
        {
            get => $"Next Level: {_Character.GetEXPToNextLvl()}";
        }
    }
}
