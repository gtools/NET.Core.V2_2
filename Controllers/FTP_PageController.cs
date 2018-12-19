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
    public class FTP_PageController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FTP_PageController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FTP_Page
        public async Task<IActionResult> Index()
        {
            return View(await _context.FTP_Pages.ToListAsync());
        }

        // GET: FTP_Page/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fTP_Page = await _context.FTP_Pages
                .FirstOrDefaultAsync(m => m.PId == id);
            if (fTP_Page == null)
            {
                return NotFound();
            }

            return View(fTP_Page);
        }

        // GET: FTP_Page/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FTP_Page/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PId,Address,Explain,Sort")] FTP_Page fTP_Page)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fTP_Page);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fTP_Page);
        }

        // GET: FTP_Page/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fTP_Page = await _context.FTP_Pages.FindAsync(id);
            if (fTP_Page == null)
            {
                return NotFound();
            }
            return View(fTP_Page);
        }

        // POST: FTP_Page/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PId,Address,Explain,Sort")] FTP_Page fTP_Page)
        {
            if (id != fTP_Page.PId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fTP_Page);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FTP_PageExists(fTP_Page.PId))
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
            return View(fTP_Page);
        }

        // GET: FTP_Page/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fTP_Page = await _context.FTP_Pages
                .FirstOrDefaultAsync(m => m.PId == id);
            if (fTP_Page == null)
            {
                return NotFound();
            }

            return View(fTP_Page);
        }

        // POST: FTP_Page/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fTP_Page = await _context.FTP_Pages.FindAsync(id);
            _context.FTP_Pages.Remove(fTP_Page);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FTP_PageExists(int id)
        {
            return _context.FTP_Pages.Any(e => e.PId == id);
        }
    }
}
