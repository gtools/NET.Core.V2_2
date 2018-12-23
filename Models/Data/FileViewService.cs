using Microsoft.AspNetCore.Hosting;
using NET.Core.V2_2.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NET.Core.V2_2.Models.Data
{
    public interface IFileViewService
    {
        IEnumerable<FileViewModel> ToList(string path);
        Task<IEnumerable<FileViewModel>> ToListAsync(string path);
    }
    public class FileViewService : IFileViewService
    {
        //private readonly IHostingEnvironment _env;
        //public FileViewService(IHostingEnvironment hosting)
        //{
        //    _env = hosting;
        //}

        //默认数据
        //private Func<List<FileViewModel>> _file = () =>
        //{
        //    var models = new FileList(_env.WebRootPath + path);






        //    var tags = new List<Tag>();
        //    for (int i = 0; i < 100; ++i)
        //    {
        //        tags.Add(new Tag { Id = $"No.{i}", Name = $"Tag{i}", Description = "Tag entity", CreatedOn = DateTime.Now });
        //    }
        //    return tags;
        //};

        public IEnumerable<FileViewModel> ToList(string path)
        {
            return FileList(path);
        }

        public async Task<IEnumerable<FileViewModel>> ToListAsync(string path)
        {
            return await Task.Run(() => FileList(path));
        }

        /// <summary>
        /// 文件列表数据
        /// </summary>
        /// <param name="path">路径</param>
        /// <returns></returns>
        private static List<FileViewModel> FileList(string path)
        {
            var models = new List<FileViewModel>();
            //FullName.Substring(FullName.LastIndexOf(@"\"))
            DirectoryInfo dir = new DirectoryInfo(path);
            //遍历文件夹
            foreach (var item in dir.GetDirectories())
            {
                models.Add(new FileViewModel() { Name = item.Name, FullName = item.FullName, IsFile = false, UpFolder = item.Parent.Name });
            }
            //遍历文件
            foreach (var item in dir.GetFiles())
            {
                var fvm = new FileViewModel() { Name = item.Name, FullName = item.FullName, IsFile = true };
                models.Add(fvm);

            }
            return models;
        }
    }
}
