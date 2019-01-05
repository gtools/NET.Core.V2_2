using Microsoft.AspNetCore.Mvc;
using NET.Core.V2_2.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace NET.Core.V2_2.Controllers.ViewComponents
{
    public class NavbarViewComponent : ViewComponent
    {

        private readonly ApplicationDbContext _db;

        public NavbarViewComponent(ApplicationDbContext context)
        {
            _db = context;
        }

        //public async Task<IViewComponentResult> InvokeAsync()
        //{
        //    return View();
        //}
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _db.SYS_Navbars.Where(t => t.ParentId == null).Include(t => t.Childs).ToListAsync());
        }
    }
}
