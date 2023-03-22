using System;
using System.Windows.Forms;

using Abstraction.Models;
using DnD_Charactor_Creator.Src.Services;
using DnD_Charactor_Creator.Src.FormHandlers;
using System.Drawing;

namespace DnD_Charactor_Creator.Frontend
{
    public partial class MainWindow_Form : Form
    {
        public ProjectStatus CurrentProject = null!;

        public MainWindow_Form()
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
                DisplayCharacter(CurrentProject.Character);
            }
            else
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
            //throw new NotImplementedException();
        }

        private void mp_MainStripItemClick(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem? item = e.ClickedItem;

            if (item == null)
                return;

            switch (item.Name)
            {
                case string when item.Name.StartsWith("tmi_"):
                    return;
                case string filePrefix when filePrefix.StartsWith("file_"):
                    MainForm_MenuBarFileHandler fileHandler = new MainForm_MenuBarFileHandler(this);
                    fileHandler.onFileChildElementClickEvent(item);
                    break;
                case string optionsPrefix when optionsPrefix.StartsWith("opt_"):
                    MainForm_MenuBarOptionsHandler optionsHandler = new MainForm_MenuBarOptionsHandler(this);
                    break;
                case string invetoryPrefix when invetoryPrefix.StartsWith("inv_"):
                    break;
                case string spellPrefix when spellPrefix.StartsWith("spl_"):
                    break;
                default:
                    throw new Exception($"Unrechable Code\r\nName gotten: {item.Name}");
            }
        }
    }
}
