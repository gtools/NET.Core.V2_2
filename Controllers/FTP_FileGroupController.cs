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
    public class FTP_FileGroupController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FTP_FileGroupController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FTP_FileGroup
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.FTP_FileGroups.Include(f => f.FTP_Page);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: FTP_FileGroup/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fTP_FileGroup = await _context.FTP_FileGroups
                .Include(f => f.FTP_Page)
                .FirstOrDefaultAsync(m => m.FGId == id);
            if (fTP_FileGroup == null)
            {
                return NotFound();
            }

            return View(fTP_FileGroup);
        }

        // GET: FTP_FileGroup/Create
        public IActionResult Create()
        {
            ViewData["PId"] = new SelectList(_context.FTP_Pages, "PId", "Address");
            return View();
        }

        // POST: FTP_FileGroup/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FGId,Name,Sort,PId")] FTP_FileGroup fTP_FileGroup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fTP_FileGroup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PId"] = new SelectList(_context.FTP_Pages, "PId", "Address", fTP_FileGroup.PId);
            return View(fTP_FileGroup);
        }

        // GET: FTP_FileGroup/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fTP_FileGroup = await _context.FTP_FileGroups.FindAsync(id);
            if (fTP_FileGroup == null)
            {
                return NotFound();
            }
            ViewData["PId"] = new SelectList(_context.FTP_Pages, "PId", "Address", fTP_FileGroup.PId);
            return View(fTP_FileGroup);
        }

        // POST: FTP_FileGroup/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FGId,Name,Sort,PId")] FTP_FileGroup fTP_FileGroup)
        {
            if (id != fTP_FileGroup.FGId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fTP_FileGroup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FTP_FileGroupExists(fTP_FileGroup.FGId))
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
            ViewData["PId"] = new SelectList(_context.FTP_Pages, "PId", "Address", fTP_FileGroup.PId);
            return View(fTP_FileGroup);
        }

        // GET: FTP_FileGroup/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fTP_FileGroup = await _context.FTP_FileGroups
                .Include(f => f.FTP_Page)
                .FirstOrDefaultAsync(m => m.FGId == id);
            if (fTP_FileGroup == null)
            {
                return NotFound();
            }

            return View(fTP_FileGroup);
        }

        // POST: FTP_FileGroup/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fTP_FileGroup = await _context.FTP_FileGroups.FindAsync(id);
            _context.FTP_FileGroups.Remove(fTP_FileGroup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FTP_FileGroupExists(int id)
        {
            return _context.FTP_FileGroups.Any(e => e.FGId == id);
        }
    }
}
