using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace DnD_Charactor_Creator.Src.Services
{
    public static class FileService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string FullRead(string path)
        {
            string result = "";

            using (StreamReader reader = new StreamReader(path))
            {
                result = reader.ReadToEnd();
            }

            return result;
        }

        /// <summary>
        /// Appends some <paramref name="content"/> to a given <paramref name="path"/>
        /// </summary>
        /// <param name="path"> The destination for the <paramref name="content"/> to be writen </param>
        /// <param name="content"> The value that will be appended to <paramref name="path"/> </param>
        public static void AppendFile(string path, string content)
        {
            using (StreamWriter writer = new StreamWriter(path, append: true))
            {
                writer.Write(content);
                writer.Flush();
            }
        }

        /// <summary>
        /// Writes a string of <paramref name="content"/> to a given <paramref name="path"/> <br/> <b>WARNING:</b> Will overwrite content if any is present 
        /// </summary>
        /// <param name="path"> The destination of the <paramref name="content"/> </param>
        /// <param name="content"> The value to be writen into <paramref name="path"/> </param>
        public static void WriteFile(string path, string content)
        {
            using (StreamWriter writer = new StreamWriter(path, append: false))
            {
                writer.Write(content);
                writer.Flush();
            }
        }
    }
}
