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
    public class SYS_EmpController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SYS_EmpController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SYS_Emp
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SYS_Emps.Include(s => s.SYS_Dept);
            return View(await applicationDbContext.ToListAsync());
        }

        /*
        // GET: SYS_Emp/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sYS_Emp = await _context.SYS_Emps
                .Include(s => s.SYS_Dept)
                .FirstOrDefaultAsync(m => m.Emp_Code == id);
            if (sYS_Emp == null)
            {
                return NotFound();
            }

            return View(sYS_Emp);
        }
        */

        // GET: SYS_Emp/Create
        public IActionResult Create()
        {
            //ViewData["Dept_Code"] = new SelectList(_context.SYS_Depts, "Dept_Code", "Dept_Code");
            ViewData["Dept_Code"] = new SelectList(_context.SYS_Depts, "Dept_Code", "Dept_Name");
            return View();
        }

        // POST: SYS_Emp/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Emp_Code,Emp_Name,Dept_Code")] SYS_Emp sYS_Emp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sYS_Emp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Dept_Code"] = new SelectList(_context.SYS_Depts, "Dept_Code", "Dept_Code", sYS_Emp.Dept_Code);
            return View(sYS_Emp);
        }

        // GET: SYS_Emp/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sYS_Emp = await _context.SYS_Emps.FindAsync(id);
            if (sYS_Emp == null)
            {
                return NotFound();
            }
            ViewData["Dept_Code"] = new SelectList(_context.SYS_Depts, "Dept_Code", "Dept_Code", sYS_Emp.Dept_Code);
            return View(sYS_Emp);
        }

        // POST: SYS_Emp/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Emp_Code,Emp_Name,Dept_Code")] SYS_Emp sYS_Emp)
        {
            if (id != sYS_Emp.Emp_Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sYS_Emp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SYS_EmpExists(sYS_Emp.Emp_Code))
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
            ViewData["Dept_Code"] = new SelectList(_context.SYS_Depts, "Dept_Code", "Dept_Code", sYS_Emp.Dept_Code);
            return View(sYS_Emp);
        }

        /*
        // GET: SYS_Emp/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sYS_Emp = await _context.SYS_Emps
                .Include(s => s.SYS_Dept)
                .FirstOrDefaultAsync(m => m.Emp_Code == id);
            if (sYS_Emp == null)
            {
                return NotFound();
            }

            return View(sYS_Emp);
        }

        // POST: SYS_Emp/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var sYS_Emp = await _context.SYS_Emps.FindAsync(id);
            _context.SYS_Emps.Remove(sYS_Emp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        */

        private bool SYS_EmpExists(string id)
        {
            return _context.SYS_Emps.Any(e => e.Emp_Code == id);
        }

        [AcceptVerbs("Get", "Post")]
        public IActionResult VerifyEmp_Code(string emp_code)
        {
            if (_context.SYS_Emps.Where(t => t.Emp_Code.Contains(emp_code)).Count() > 0)
            {
                return Json($"工号 {emp_code} 已存在。");
            }

            return Json(true);
        }
    }
}
