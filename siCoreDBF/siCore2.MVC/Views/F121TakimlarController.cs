using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using siCoreDBF3.DAL.Model;

namespace siCore2.MVC.Views
{
    public class F121TakimlarController : Controller
    {
        private readonly siCoreContext _context;

        public F121TakimlarController(siCoreContext context)
        {
            _context = context;
        }

        // GET: F121Takimlar
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.F121Takimlar.Include(f => f.Takim).OrderByDescending(f => f.TakimPuan);
            return View(await siCoreContext.ToListAsync());
        }

        // GET: F121Takimlar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f121Takimlar = await _context.F121Takimlar
                .Include(f => f.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (f121Takimlar == null)
            {
                return NotFound();
            }

            return View(f121Takimlar);
        }

        // GET: F121Takimlar/Create
        public IActionResult Create()
        {
            ViewData["TakimId"] = new SelectList(_context.F1Takimlar, "TakimId", "TakimId");
            return View();
        }

        // POST: F121Takimlar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,TakimPuan")] F121Takimlar f121Takimlar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(f121Takimlar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TakimId"] = new SelectList(_context.F1Takimlar, "TakimId", "TakimId", f121Takimlar.TakimId);
            return View(f121Takimlar);
        }

        // GET: F121Takimlar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f121Takimlar = await _context.F121Takimlar.FindAsync(id);
            if (f121Takimlar == null)
            {
                return NotFound();
            }
            ViewData["TakimId"] = new SelectList(_context.F1Takimlar, "TakimId", "TakimId", f121Takimlar.TakimId);
            return View(f121Takimlar);
        }

        // POST: F121Takimlar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,TakimPuan")] F121Takimlar f121Takimlar)
        {
            if (id != f121Takimlar.TakimId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(f121Takimlar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!F121TakimlarExists(f121Takimlar.TakimId))
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
            ViewData["TakimId"] = new SelectList(_context.F1Takimlar, "TakimId", "TakimId", f121Takimlar.TakimId);
            return View(f121Takimlar);
        }

        // GET: F121Takimlar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f121Takimlar = await _context.F121Takimlar
                .Include(f => f.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (f121Takimlar == null)
            {
                return NotFound();
            }

            return View(f121Takimlar);
        }

        // POST: F121Takimlar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var f121Takimlar = await _context.F121Takimlar.FindAsync(id);
            _context.F121Takimlar.Remove(f121Takimlar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool F121TakimlarExists(int id)
        {
            return _context.F121Takimlar.Any(e => e.TakimId == id);
        }
    }
}
