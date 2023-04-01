using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Abstraction.Models;

namespace DnD_Character_Creator.View
{
    /// <summary>
    /// Interaction logic for CharacterView.xaml
    /// </summary>
    public partial class CharacterView : Page
    {
        private Character _Character;

        public CharacterView(ref Character character)
        {
            InitializeComponent();
            _Character = character;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="updatedCharacter"></param>
        public void ChangeCharacter(ref Character updatedCharacter)
        {
            throw new NotImplementedException();
        }
    }
}
