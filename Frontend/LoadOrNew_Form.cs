using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;

using DnD_Charactor_Creator.Src.Services;

namespace DnD_Charactor_Creator.Frontend
{
    public partial class LoadOrNew_Form : Form
    {
        private MainWindow_Form _Owner;

        public LoadOrNew_Form(MainWindow_Form owner)
        {
            _Owner = owner;

            InitializeComponent();
        }

        private void onButtonClick(object sender, EventArgs e)
        {
            Button source = (Button)sender;

            if (source.Name == "btn_NewChar")
                OnNewClick();
            else if (source.Name == "btn_LoadChar")
                OnLoadClick();
            else
                throw new Exception("Unrechable Code");

            this.Close();
        }

        private void OnNewClick()
        {
            _Owner.CurrentProject.Loaded = false;
            _Owner.CurrentProject.ConfigPath = string.Empty;
        }

        private void OnLoadClick()
        {
            LoadCharacterService loadCharacter = new LoadCharacterService("");
            _Owner.CurrentProject.Loaded = true;
            _Owner.CurrentProject.ConfigPath = "";
            _Owner.CurrentProject.Character = loadCharacter.Load();
        }
    }
}