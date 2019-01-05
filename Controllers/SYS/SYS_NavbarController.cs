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
    public class SYS_NavbarController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SYS_NavbarController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SYS_Navbar
        public async Task<IActionResult> Index()
        {
            return View(await _context.SYS_Navbars.Where(t => t.ParentId == null).Include(s => s.Childs).OrderBy(s => s.Sort).ToListAsync());
        }

        // GET: SYS_Navbar/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sYS_Navbar = await _context.SYS_Navbars
                .Include(s => s.Father)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sYS_Navbar == null)
            {
                return NotFound();
            }

            return View(sYS_Navbar);
        }

        // GET: SYS_Navbar/Create
        public IActionResult Create()
        {
            this.SelectList_Navbar(Guid.Empty);
            return View();
        }

        // POST: SYS_Navbar/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Url,Action,Controller,Sort,Is_Stop,ParentId")] SYS_Navbar sYS_Navbar)
        {
            if (ModelState.IsValid)
            {
                if (sYS_Navbar.ParentId == Guid.Empty)
                    sYS_Navbar.ParentId = null;
                _context.Add(sYS_Navbar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ParentId"] = new SelectList(_context.SYS_Navbars, "Id", "Name", sYS_Navbar.ParentId);
            return View(sYS_Navbar);
        }

        // GET: SYS_Navbar/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sYS_Navbar = await _context.SYS_Navbars.FindAsync(id);
            if (sYS_Navbar == null)
            {
                return NotFound();
            }
            this.SelectList_Navbar(sYS_Navbar.ParentId);
            return View(sYS_Navbar);
        }

        // POST: SYS_Navbar/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,Url,Action,Controller,Sort,Is_Stop,ParentId")] SYS_Navbar sYS_Navbar)
        {
            if (id != sYS_Navbar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sYS_Navbar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SYS_NavbarExists(sYS_Navbar.Id))
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
            ViewData["ParentId"] = new SelectList(_context.SYS_Navbars, "Id", "Name", sYS_Navbar.ParentId);
            return View(sYS_Navbar);
        }

        // GET: SYS_Navbar/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sYS_Navbar = await _context.SYS_Navbars
                .Include(s => s.Father)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sYS_Navbar == null)
            {
                return NotFound();
            }

            return View(sYS_Navbar);
        }

        // POST: SYS_Navbar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var sYS_Navbar = await _context.SYS_Navbars.FindAsync(id);
            _context.SYS_Navbars.Remove(sYS_Navbar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SYS_NavbarExists(Guid id)
        {
            return _context.SYS_Navbars.Any(e => e.Id == id);
        }

        /// <summary>
        /// 下拉选项数据
        /// </summary>
        /// <param name="pid"></param>
        private void SelectList_Navbar(Guid? pid)
        {
            var items = _context.SYS_Navbars.Where(t => t.ParentId == null).ToList();
            items.Add(new SYS_Navbar() { Id = Guid.Empty, Name = "请选择", Sort = -1 });
            ViewData["ParentId"] = new SelectList(items.OrderBy(t => t.Sort), "Id", "Name", pid);
        }
    }
}
