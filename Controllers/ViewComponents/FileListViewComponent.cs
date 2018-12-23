using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NET.Core.V2_2.Data;
using NET.Core.V2_2.Models.Data;
using NET.Core.V2_2.Models.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace NET.Core.V2_2.Controllers.ViewComponents
{
    public class FileListViewComponent : ViewComponent
    {

        private readonly ApplicationDbContext _db;

        private readonly IHostingEnvironment _env;

        private readonly IFileViewService _file;

        public FileListViewComponent(ApplicationDbContext context, IHostingEnvironment hosting, IFileViewService file)
        {
            _db = context;
            _env = hosting;
            _file = file;
        }

        public async Task<IViewComponentResult> InvokeAsync(
            string path)
        {
            //ViewData["Path"] = path;
            var model = await _file.ToListAsync(ViewData["Path"].ToString());
            return View(model);
        }
    }
}
