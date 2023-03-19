﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Charactor_Creator.Src.Models
{
    public class FileContex
    {

        public string FullPath { get; private set; } = null!;

        /// <summary>
        /// 
        /// </summary>
        public string FileExtension { get {
                int lastDotIdx = FullPath.LastIndexOf('.');
                return FullPath.Substring(lastDotIdx, FullPath.Length - lastDotIdx);
            } }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        public FileContex(string path) => FullPath = path;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public FileStream GetFileStream(FileMode mode)
        {
            return File.Open(FullPath, mode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public StreamWriter GetWriteStream()
        {
            return new StreamWriter(FullPath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public StreamReader GetReadStream()
        {
            return new StreamReader(FullPath);
        }

    }
}
