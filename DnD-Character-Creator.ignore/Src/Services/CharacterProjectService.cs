using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DnD_Charactor_Creator.Src.Services
{
    public class CharacterProjectService
    {
        /// <summary>
        /// Finds the path to a Character project folder.
        /// </summary>
        /// <param name="projectPath"> Returns the path of the selected Character project </param>
        /// <returns> Returns true or false, showing if a project was found </returns>
        public static bool FindProject(out string projectPath)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = @"%USERPROFILE%";
                fileDialog.Filter = "JSON (*.json)|.json|All files (*.*)|*.*";
                fileDialog.FilterIndex = 1;
                fileDialog.RestoreDirectory = true;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    projectPath = fileDialog.FileName;
                    return true;
                }
                projectPath = null!;
                return false;
            }
        }

    }
}
