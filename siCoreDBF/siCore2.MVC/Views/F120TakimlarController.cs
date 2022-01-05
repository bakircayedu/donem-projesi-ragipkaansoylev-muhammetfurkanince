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
    public class F120TakimlarController : Controller
    {
        private readonly siCoreContext _context;

        public F120TakimlarController(siCoreContext context)
        {
            _context = context;
        }

        // GET: F120Takimlar
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.F120Takimlar.Include(f => f.Takim).OrderByDescending(f => f.TakimPuan);
            return View(await siCoreContext.ToListAsync());
        }

        // GET: F120Takimlar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f120Takimlar = await _context.F120Takimlar
                .Include(f => f.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (f120Takimlar == null)
            {
                return NotFound();
            }

            return View(f120Takimlar);
        }

        // GET: F120Takimlar/Create
        public IActionResult Create()
        {
            ViewData["TakimId"] = new SelectList(_context.F1Takimlar, "TakimId", "TakimId");
            return View();
        }

        // POST: F120Takimlar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,TakimPuan")] F120Takimlar f120Takimlar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(f120Takimlar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TakimId"] = new SelectList(_context.F1Takimlar, "TakimId", "TakimId", f120Takimlar.TakimId);
            return View(f120Takimlar);
        }

        // GET: F120Takimlar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f120Takimlar = await _context.F120Takimlar.FindAsync(id);
            if (f120Takimlar == null)
            {
                return NotFound();
            }
            ViewData["TakimId"] = new SelectList(_context.F1Takimlar, "TakimId", "TakimId", f120Takimlar.TakimId);
            return View(f120Takimlar);
        }

        // POST: F120Takimlar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,TakimPuan")] F120Takimlar f120Takimlar)
        {
            if (id != f120Takimlar.TakimId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(f120Takimlar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!F120TakimlarExists(f120Takimlar.TakimId))
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
            ViewData["TakimId"] = new SelectList(_context.F1Takimlar, "TakimId", "TakimId", f120Takimlar.TakimId);
            return View(f120Takimlar);
        }

        // GET: F120Takimlar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f120Takimlar = await _context.F120Takimlar
                .Include(f => f.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (f120Takimlar == null)
            {
                return NotFound();
            }

            return View(f120Takimlar);
        }

        // POST: F120Takimlar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var f120Takimlar = await _context.F120Takimlar.FindAsync(id);
            _context.F120Takimlar.Remove(f120Takimlar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool F120TakimlarExists(int id)
        {
            return _context.F120Takimlar.Any(e => e.TakimId == id);
        }
    }
}
