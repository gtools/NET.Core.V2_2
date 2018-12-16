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
    public class FTP_FileUrlController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FTP_FileUrlController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FTP_FileUrl
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.FTP_FileUrls.Include(f => f.FTP_FileGroup);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: FTP_FileUrl/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fTP_FileUrl = await _context.FTP_FileUrls
                .Include(f => f.FTP_FileGroup)
                .FirstOrDefaultAsync(m => m.FUId == id);
            if (fTP_FileUrl == null)
            {
                return NotFound();
            }

            return View(fTP_FileUrl);
        }

        // GET: FTP_FileUrl/Create
        public IActionResult Create()
        {
            ViewData["FGId"] = new SelectList(_context.FTP_FileGroups, "FGId", "Name");
            return View();
        }

        // POST: FTP_FileUrl/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FUId,Name,Url,Sort,FGId")] FTP_FileUrl fTP_FileUrl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fTP_FileUrl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FGId"] = new SelectList(_context.FTP_FileGroups, "FGId", "Name", fTP_FileUrl.FGId);
            return View(fTP_FileUrl);
        }

        // GET: FTP_FileUrl/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fTP_FileUrl = await _context.FTP_FileUrls.FindAsync(id);
            if (fTP_FileUrl == null)
            {
                return NotFound();
            }
            ViewData["FGId"] = new SelectList(_context.FTP_FileGroups, "FGId", "Name", fTP_FileUrl.FGId);
            return View(fTP_FileUrl);
        }

        // POST: FTP_FileUrl/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FUId,Name,Url,Sort,FGId")] FTP_FileUrl fTP_FileUrl)
        {
            if (id != fTP_FileUrl.FUId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fTP_FileUrl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FTP_FileUrlExists(fTP_FileUrl.FUId))
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
            ViewData["FGId"] = new SelectList(_context.FTP_FileGroups, "FGId", "Name", fTP_FileUrl.FGId);
            return View(fTP_FileUrl);
        }

        // GET: FTP_FileUrl/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fTP_FileUrl = await _context.FTP_FileUrls
                .Include(f => f.FTP_FileGroup)
                .FirstOrDefaultAsync(m => m.FUId == id);
            if (fTP_FileUrl == null)
            {
                return NotFound();
            }

            return View(fTP_FileUrl);
        }

        // POST: FTP_FileUrl/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fTP_FileUrl = await _context.FTP_FileUrls.FindAsync(id);
            _context.FTP_FileUrls.Remove(fTP_FileUrl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FTP_FileUrlExists(int id)
        {
            return _context.FTP_FileUrls.Any(e => e.FUId == id);
        }
    }
}
