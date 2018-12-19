using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NET.Core.V2_2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NET.Core.V2_2.Controllers
{
    /// <summary>
    /// 文件试图列表
    /// </summary>
    public class FileViewsController : Controller
    {
        private readonly IHostingEnvironment _environment;
        public FileViewsController(IHostingEnvironment environment)
        {
            _environment = environment;
        }

        private static FilesViewModel _FilesViewModel = new FilesViewModel();

        //public IActionResult Index()
        //{
        //    var filePath = _environment.WebRootPath + "\\download\\";
        //    _FileViewModel = listDirectory(filePath);
        //    return View(_FileViewModel);
        //    //return View();
        //}


        public IActionResult Index(string dir)
        {
            var path1 = "\\download";
            var path2 = "\\";
            var filePath = _environment.WebRootPath + path1 + path2;
            if (!string.IsNullOrWhiteSpace(dir))
            {
                if (_FilesViewModel.Path == "\\")
                    filePath = _environment.WebRootPath + path1 + path2 + dir + path2;
                else
                    filePath = _environment.WebRootPath + path1 + _FilesViewModel.Path + dir + path2;
            }
            _FilesViewModel.FileViewModels = listDirectory(filePath);
            _FilesViewModel.Path = filePath.Substring(filePath.IndexOf(path1) + path1.Length);
            return View("Index", _FilesViewModel);
        }

        [Route("FileViews/Back")]
        public IActionResult Back()
        {
            //path = path.Substring(0, path.Length - 1);
            if (_FilesViewModel.Path == "\\")
                return Index("");
            else
            {
                var path = _FilesViewModel.Path.Substring(0, _FilesViewModel.Path.Length - 1);
                var name = path.Substring(path.LastIndexOf("\\") + 1);
                path = path.Remove(path.LastIndexOf(name));
                path = path.Substring(0, path.Length - 1);
                name = path.Substring(path.LastIndexOf("\\") + 1);
                if (path == "")
                {
                    path = "\\";
                }
                else
                {
                    path = path.Remove(path.LastIndexOf(name));
                }
                _FilesViewModel.Path = path;
                return Index(name);
            }
        }



        private List<FileViewModel> listDirectory(string path)
        {
            var models = new List<FileViewModel>();
            DirectoryInfo dir = new DirectoryInfo(path);
            //遍历文件夹
            foreach (var item in dir.GetDirectories())
            {
                models.Add(new FileViewModel() { Name = item.Name, Path = item.FullName, DirectoryOrFile = false });
            }
            //遍历文件
            foreach (var item in dir.GetFiles())
            {
                var fvm = new FileViewModel() { Name = item.Name, Path = item.FullName, DirectoryOrFile = true };
                models.Add(fvm);

            }
            return models;
        }
    }
}
