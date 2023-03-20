using System;
using System.Windows.Forms;

using DnD_Charactor_Creator.Frontend;

namespace DnD_Charactor_Creator.Src.FormHandlers
{
    public class MainForm_MenuBarFileHandler
    {
        private MainWindow_Form _Owner;

        public MainForm_MenuBarFileHandler(MainWindow_Form owner)
        {
            _Owner = owner;
        }

        public void onFileChildElementClickEvent(ToolStripMenuItem elementClicked)
        {
            switch (elementClicked.Name)
            {
                case "file.Exit":
                    _Owner.Close();
                break;
                default:
                    throw new Exception("Unrechable code");
            }
        }
    }
}
