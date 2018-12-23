using System;
using System.Collections.Generic;
using System.IO;

namespace NET.Core.V2_2.Models.ViewModels
{
    /// <summary>
    /// 文件视图
    /// </summary>
    public class FileViewModel
    {
        /// <summary>
        /// 文件夹名或文件名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 上级文件夹
        /// </summary>
        public string UpFolder { get; set; }
        /// <summary>
        /// 完整的路径名
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// 是否是文件,true,文件,false,文件夹
        /// </summary>
        public bool IsFile { get; set; }
    }
}