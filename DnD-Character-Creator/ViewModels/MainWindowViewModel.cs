using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

using Abstraction.Models;

using DnD_Character_Creator.View;

namespace DnD_Character_Creator.ViewModels
{
    public class MainWindowViewModel
    {

        private Character _Character = null!;
        private string _Path { get; set; } = "";

        private CharacterView _CharacterView = null!;

        public MainWindowViewModel()
        {
            _Character = new Character();
            _CharacterView = new CharacterView(ref _Character);
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
            get => $"Next Level: {_Character.Exp}/{_Character.GetEXPToNextLvl()}";
            set { }
        }

        public CharacterView ShowCharacterInfo
        {
            get => _CharacterView;
            set { }
        }
    }
}
