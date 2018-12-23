using System;
using System.Collections.Generic;

namespace NET.Core.V2_2.Models.ViewModels
{
    /// <summary>
    /// 文件列表视图
    /// </summary>
    public class FileListViewModel
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
