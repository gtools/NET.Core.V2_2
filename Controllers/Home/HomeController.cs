using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NET.Core.V2_2.Data;
using NET.Core.V2_2.Models;
using NET.Core.V2_2.Models.Data;

namespace NET.Core.V2_2.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 上下文
        /// </summary>
        private readonly ApplicationDbContext _db;

        private readonly IHostingEnvironment _env;

        private readonly IConfiguration _config;

        private readonly IFileViewService _file;
        public HomeController(ApplicationDbContext context, IHostingEnvironment hosting, IConfiguration config, IFileViewService file)
        {
            _db = context;
            _env = hosting;
            _config = config;
            _file = file;
        }

        [Route("")]
        [Route("Index")]
        [Route("Home/Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Home/Index1")]
        public async Task<IActionResult> Index1()
        {
            var result = await _db.FTP_Pages
            .Where(t => t.Address.ToUpper().Contains("index".ToUpper()))//查询
            .Include(t => t.FTP_FileGroups)//关联查询
                .ThenInclude(group => group.FTP_FileUrls)//关联查询\关联查询
            .OrderByDescending(t => t.Sort)//排序
            .ToListAsync();
            return View(result[0].FTP_FileGroups);
        }

        public async Task<IActionResult> Index(int id)
        {
            var result = await _db.FTP_Pages
            .Where(t => t.PId == id)//查询
            .Include(t => t.FTP_FileGroups)//关联查询
                .ThenInclude(group => group.FTP_FileUrls)//关联查询\关联查询
            .OrderByDescending(t => t.Sort)//排序
            .ToListAsync();
            if (result.Count == 0)
                return Error();
            else
                return View(result[0].FTP_FileGroups);
            ////如果数据为空判断是首页
            //if (string.IsNullOrWhiteSpace(url))
            //    url = "index";

            ////返回数据
            //var result = await _db.FTP_Pages
            //    .Where(t => t.Address.ToUpper().Contains(url.ToUpper()))//查询
            //    .Include(t => t.FTP_FileGroups)//关联查询
            //        .ThenInclude(group => group.FTP_FileUrls)//关联查询\关联查询
            //    .OrderByDescending(t => t.Sort)//排序
            //    .ToListAsync();

            ////没有数据返回错误页
            //if (result.Count == 1)
            //    return View(result[0].FTP_FileGroups);
            //else
            //    return Error();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}

        [Route("Error")]
        [Route("Home/Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error", new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /// <summary>
        /// 初始化GET
        /// </summary>
        /// <returns></returns>
        [Route("InitialCreate")]
        public IActionResult InitialCreate()
        {
            return View("InitialCreate");
        }

        public IActionResult SaveChanges()
        {
            using (var context = _db)
            {
                //数据库构架是否存在，不存在创建，存在不创建。
                context.Database.EnsureCreated();
                
                #region 菜单
                var pid = Guid.Parse("{a9837ab8-f2da-4658-9f3e-f4b103922d91}");
                var id = pid;
                var navbar = context.SYS_Navbars.FirstOrDefault(t => t.Id.ToString().ToLower() == id.ToString().ToLower());//返回第一个匹配值
                if (navbar == null)
                {
                    context.SYS_Navbars.Add(new SYS_Navbar
                    {
                        Id = id,
                        Name = "测试页面",
                        Sort = 9
                    });
                }
                id = Guid.Parse("{4a8b8625-4d04-4e53-9b47-e0d36d637708}");
                navbar = context.SYS_Navbars.FirstOrDefault(t => t.Id.ToString().ToLower() == id.ToString().ToLower());
                if (navbar == null)
                {
                    context.SYS_Navbars.Add(new SYS_Navbar
                    {
                        Id = id,
                        Name = "文件页面设置",
                        Controller = "FTP_Page",
                        Action = "Index",
                        ParentId = pid
                    });
                }
                id = Guid.Parse("{654d88c1-3df4-469b-9d82-bccc3745fb92}");
                navbar = context.SYS_Navbars.FirstOrDefault(t => t.Id.ToString().ToLower() == id.ToString().ToLower());
                if (navbar == null)
                {
                    context.SYS_Navbars.Add(new SYS_Navbar
                    {
                        Id = id,
                        Name = "文件组设置",
                        Controller = "FTP_FileGroup",
                        Action = "Index",
                        ParentId = pid
                    });
                }
                id = Guid.Parse("{80f58e2b-725b-44b7-b907-653c7c186828}");
                navbar = context.SYS_Navbars.FirstOrDefault(t => t.Id.ToString().ToLower() == id.ToString().ToLower());
                if (navbar == null)
                {
                    context.SYS_Navbars.Add(new SYS_Navbar
                    {
                        Id = id,
                        Name = "文件地址设置",
                        Controller = "FTP_FileUrl",
                        Action = "Index",
                        ParentId = pid
                    });
                }
                id = Guid.Parse("{ef60c26d-dd8a-4420-b5ed-43df62e4691e}");
                navbar = context.SYS_Navbars.FirstOrDefault(t => t.Id.ToString().ToLower() == id.ToString().ToLower());
                if (navbar == null)
                {
                    context.SYS_Navbars.Add(new SYS_Navbar
                    {
                        Id = id,
                        Name = "文件上传",
                        Controller = "FileUpload",
                        Action = "Index",
                        ParentId = pid
                    });
                }
                id = Guid.Parse("{b6587a4f-f1df-4d14-814d-3b77ca6a3f06}");
                navbar = context.SYS_Navbars.FirstOrDefault(t => t.Id.ToString().ToLower() == id.ToString().ToLower());
                if (navbar == null)
                {
                    context.SYS_Navbars.Add(new SYS_Navbar
                    {
                        Id = id,
                        Name = "文件列表",
                        Controller = "FileViews",
                        Action = "Index",
                        ParentId = pid
                    });
                }
                pid = Guid.Parse("{d41c62a6-e8d5-48a3-b4b0-71c968c44b09}");
                id = pid;
                navbar = context.SYS_Navbars.FirstOrDefault(t => t.Id.ToString().ToLower() == id.ToString().ToLower());
                if (navbar == null)
                {
                    context.SYS_Navbars.Add(new SYS_Navbar
                    {
                        Id = id,
                        Name = "系统设置",
                        Sort = 8
                    });
                }
                id = Guid.Parse("{7ad48c8b-9d20-49e2-9959-ddf1515888f4}");
                navbar = context.SYS_Navbars.FirstOrDefault(t => t.Id.ToString().ToLower() == id.ToString().ToLower());
                if (navbar == null)
                {
                    context.SYS_Navbars.Add(new SYS_Navbar
                    {
                        Id = id,
                        Name = "菜单设置",
                        Controller = "SYS_Navbar",
                        Action = "Index",
                        ParentId = pid
                    });
                }
                #endregion

                //科室
                var sys_dept = context.SYS_Depts.FirstOrDefault(t => t.Dept_Code == "9999");
                if (sys_dept == null)
                {
                    context.SYS_Depts.Add(new SYS_Dept
                    {
                        Dept_Code = "9999",
                        Dept_Name = "测试科"
                    });
                }
                //人员
                var sys_emp = context.SYS_Emps.FirstOrDefault(t => t.Emp_Code == "999999");
                if (sys_emp == null)
                {
                    context.SYS_Emps.Add(new SYS_Emp
                    {
                        Emp_Code = "999999",
                        Emp_Name = "超级管理员",
                        Dept_Code = "9999"
                    });
                }
                //保存
                context.SaveChanges();
            }
            return View("Index");
        }




        //public IActionResult Privacy()
        //{
        //    ViewData["Path_Name"] = _config.GetSection("UserConfig")["DownloadDirectoryString"];
        //    ViewData["Path"] = _env.WebRootPath + ViewData["Path_Name"];
        //    return View("Privacy");
        //}


        public IActionResult Privacy(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                //当前目录
                ViewData["Path_Name"] = _config.GetSection("UserConfig")["DownloadDirectoryString"];
                //上级目录
                ViewData["Path_UpName"] = "";
            }
            else
            {
                ViewData["Path_Name"] = path;
                ViewData["Path_UpName"] = path.Remove(path.Remove(path.Length - 1).LastIndexOf(@"\") + 1);
            }
            //完全路径
            ViewData["Path"] = _env.WebRootPath + ViewData["Path_Name"];
            return View("Privacy");
        }
    }
}
