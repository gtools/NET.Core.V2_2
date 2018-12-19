using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NET.Core.V2_2.Models
{
    public class FileViewModel
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 路径
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// 是否是文件,true,文件,false,文件夹
        /// </summary>
        public bool DirectoryOrFile { get; set; }
    }
    public class FilesViewModel
    {
        /// <summary>
        /// 上级地址
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// 文件列表
        /// </summary>
        public List<FileViewModel> FileViewModels { get; set; }
    }
}
