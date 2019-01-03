using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NET.Core.V2_2.Data;
using NET.Core.V2_2.Models;

namespace NET.Core.V2_2.Controllers
{
    public class SYS_DeptController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SYS_DeptController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SYS_Dept
        public async Task<IActionResult> Index()
        {
            return View(await _context.SYS_Depts.ToListAsync());
        }

        /*
        // GET: SYS_Dept/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sYS_Dept = await _context.SYS_Depts
                .FirstOrDefaultAsync(m => m.Dept_Code == id);
            if (sYS_Dept == null)
            {
                return NotFound();
            }

            return View(sYS_Dept);
        }
        */

        // GET: SYS_Dept/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SYS_Dept/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Dept_Code,Dept_Name")] SYS_Dept sYS_Dept)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sYS_Dept);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sYS_Dept);
        }

        // GET: SYS_Dept/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sYS_Dept = await _context.SYS_Depts.FindAsync(id);
            if (sYS_Dept == null)
            {
                return NotFound();
            }
            return View(sYS_Dept);
        }

        // POST: SYS_Dept/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Dept_Code,Dept_Name")] SYS_Dept sYS_Dept)
        {
            if (id != sYS_Dept.Dept_Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sYS_Dept);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SYS_DeptExists(sYS_Dept.Dept_Code))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(sYS_Dept);
        }

        /*
        // GET: SYS_Dept/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sYS_Dept = await _context.SYS_Depts
                .FirstOrDefaultAsync(m => m.Dept_Code == id);
            if (sYS_Dept == null)
            {
                return NotFound();
            }

            return View(sYS_Dept);
        }

        // POST: SYS_Dept/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var sYS_Dept = await _context.SYS_Depts.FindAsync(id);
            _context.SYS_Depts.Remove(sYS_Dept);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        */

        private bool SYS_DeptExists(string id)
        {
            return _context.SYS_Depts.Any(e => e.Dept_Code == id);
        }

        //远程验证
        [AcceptVerbs("Get", "Post")]
        public IActionResult VerifyDept_Code(string dept_code)
        {
            if (_context.SYS_Depts.Where(t => t.Dept_Code == dept_code).Count() > 0)
            {
                return Json($"部门代码 {dept_code} 已存在。");
            }

            return Json(true);
        }
    }
}
