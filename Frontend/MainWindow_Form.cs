using System;
using System.Windows.Forms;

using DnD_Charactor_Creator.Src.Models;
using DnD_Charactor_Creator.Src.Services;

namespace DnD_Charactor_Creator.Frontend
{
    public partial class MainWindow_Form : Form
    {
        public ProjectStatus CurrentProject = null!;

        public MainWindow_Form(Character loaded = null!)
        {
            InitializeComponent();
        }

        private void MainWindow_Form_Load(object sender, EventArgs e)
        {
            CurrentProject = new ProjectStatus(false, string.Empty);
            LoadOrNew_Form form = new LoadOrNew_Form(this);
            form.ShowDialog();

            if (CurrentProject.Loaded)
            {
                LoadCharacterService loadService = new LoadCharacterService(CurrentProject.ConfigPath);
                CurrentProject.Character = loadService.Load();
            } else
            {
                LoadEmptyCharacter();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chara"></param>
        private void DisplayCharacter(Character chara)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        private void LoadEmptyCharacter()
        {
            throw new NotImplementedException();
        }

    }
}
