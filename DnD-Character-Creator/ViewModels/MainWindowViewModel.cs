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
        private string _Path { get; set; } = string.Empty;

        private CharacterView _CharacterView = null!;
        private InventoryView _InventoryView = null!;

        public MainWindowViewModel()
        {
            _Character = new Character();
            _CharacterView = new CharacterView(ref _Character);
            _InventoryView = new InventoryView();
        }

        public string GetCharacterImagePath
        {
            get
            {
                if (string.IsNullOrEmpty(_Path))
                    return "";
                return _Path;
            }
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

        public InventoryView ShowInventory
        {
            get => _InventoryView;
            set { }
        }
    }
}
