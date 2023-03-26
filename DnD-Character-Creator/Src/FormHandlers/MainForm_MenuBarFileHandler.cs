using System;
using System.Windows.Forms;

using DnD_Charactor_Creator.Frontend;
using Abstraction.Models;
using DnD_Charactor_Creator.Src.Services;

namespace DnD_Charactor_Creator.Src.FormHandlers
{
    public class MainForm_MenuBarFileHandler
    {
        private MainWindow_Form _Owner;

        public MainForm_MenuBarFileHandler(MainWindow_Form owner)
        {
            _Owner = owner;
        }

        public void onFileChildElementClickEvent(ToolStripItem elementClicked)
        {
            switch (elementClicked.Name)
            {
                case "file.New":
                    break;
                case "file.Open":

                    break;
                case string recentFile when recentFile.StartsWith("file.Recent."):
                    // path somehow
                    LoadProjectFromPath("");
                    break;
                case "file.Save":
                    SaveProject();
                    break;
                case "file.SaveAs":
                    SaveProjectAs();
                    break;
                case "file.Exit":
                    _Owner.Close();
                break;
                default:
                    throw new Exception("Unrechable code");
            }
        }

        private void LoadProject()
        {
            throw new NotImplementedException();
        }

        private void LoadProjectFromPath(string path)
        {
            throw new NotImplementedException();
        }

        private void SaveProject()
        {
            ProjectConfigSingleton projectConfig = ProjectConfigSingleton.Instance();

            if (string.IsNullOrEmpty(projectConfig.GetRootDir()))
            {
                SaveProjectAs();
                return;
            }
            // TODO: save in the project folder
        }

        private void SaveProjectAs()
        {
            throw new NotImplementedException();
        }
    }
}
