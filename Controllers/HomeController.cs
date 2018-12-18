using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NET.Core.V2_2.Data;
using NET.Core.V2_2.Models;

namespace NET.Core.V2_2.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 上下文
        /// </summary>
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
        [Route("")]
        [Route("Index")]
        [Route("Home/Index")]
        public async Task<IActionResult> Index()
        {
            var result = await _context.FTP_Pages
            .Where(t => t.Address.ToUpper().Contains("index".ToUpper()))//查询
            .Include(t => t.FTP_FileGroups)//关联查询
                .ThenInclude(group => group.FTP_FileUrls)//关联查询\关联查询
            .OrderByDescending(t => t.Sort)//排序
            .ToListAsync();
            return View(result[0].FTP_FileGroups);
        }

        public async Task<IActionResult> Index(int id)
        {
            var result = await _context.FTP_Pages
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
            //var result = await _context.FTP_Pages
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

        public IActionResult Privacy()
        {
            return View("Privacy");
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
    }
}
