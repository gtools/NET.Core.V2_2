using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NET.Core.V2_2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NET.Core.V2_2.Controllers
{
    public class FileUploadController : Controller
    {
        private readonly IHostingEnvironment _environment;
        public FileUploadController(IHostingEnvironment environment)
        {
            _environment = environment;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            //FileUpload.Title = "默认";
            return View();
        }

        //[BindProperty]
        //public FileUpload FileUpload { get; set; }

        //public async Task<IActionResult> FileUp()
        //{
        //    // Perform an initial check to catch FileUpload class attribute violations.
        //    if (!ModelState.IsValid)
        //    {
        //        return View("index");
        //    }

        //    var filePath = _environment.WebRootPath + "\\download\\" + FileUpload.UploadPrivateSchedule.FileName;
        //    //var filePath = _hostingEnvironment.ContentRootPath;
        //    //Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "download", "123.txt");

        //    using (var fileStream = new FileStream(filePath, FileMode.Create))
        //    {
        //        await FileUpload.UploadPublicSchedule.CopyToAsync(fileStream);
        //    }

        //    return View("index");
        //}


        public async Task<IActionResult> FileUp(List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);
            // full path to file in temp location

            List<object> obj = new List<object>();

            foreach (var formFile in files)
            {
                var filePath = _environment.WebRootPath + "\\download\\" + formFile.FileName;
                if (formFile.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        obj.Add(new { count = files.Count, size, filePath });
                        await formFile.CopyToAsync(stream);
                    }
                }
            }

            // process uploaded files
            // Don't rely on or trust the FileName property without validation.


            return Ok(obj);
        }
    }
}
