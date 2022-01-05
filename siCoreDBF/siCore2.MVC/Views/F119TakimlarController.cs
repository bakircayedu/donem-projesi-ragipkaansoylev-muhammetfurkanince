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
    public class F119TakimlarController : Controller
    {
        private readonly siCoreContext _context;

        public F119TakimlarController(siCoreContext context)
        {
            _context = context;
        }

        // GET: F119Takimlar
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.F119Takimlar.Include(f => f.Takim).OrderByDescending(f => f.TakimPuan);
            return View(await siCoreContext.ToListAsync());
        }

        // GET: F119Takimlar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f119Takimlar = await _context.F119Takimlar
                .Include(f => f.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (f119Takimlar == null)
            {
                return NotFound();
            }

            return View(f119Takimlar);
        }

        // GET: F119Takimlar/Create
        public IActionResult Create()
        {
            ViewData["TakimId"] = new SelectList(_context.F1Takimlar, "TakimId", "TakimId");
            return View();
        }

        // POST: F119Takimlar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,TakimPuan")] F119Takimlar f119Takimlar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(f119Takimlar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TakimId"] = new SelectList(_context.F1Takimlar, "TakimId", "TakimId", f119Takimlar.TakimId);
            return View(f119Takimlar);
        }

        // GET: F119Takimlar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f119Takimlar = await _context.F119Takimlar.FindAsync(id);
            if (f119Takimlar == null)
            {
                return NotFound();
            }
            ViewData["TakimId"] = new SelectList(_context.F1Takimlar, "TakimId", "TakimId", f119Takimlar.TakimId);
            return View(f119Takimlar);
        }

        // POST: F119Takimlar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,TakimPuan")] F119Takimlar f119Takimlar)
        {
            if (id != f119Takimlar.TakimId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(f119Takimlar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!F119TakimlarExists(f119Takimlar.TakimId))
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
            ViewData["TakimId"] = new SelectList(_context.F1Takimlar, "TakimId", "TakimId", f119Takimlar.TakimId);
            return View(f119Takimlar);
        }

        // GET: F119Takimlar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f119Takimlar = await _context.F119Takimlar
                .Include(f => f.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (f119Takimlar == null)
            {
                return NotFound();
            }

            return View(f119Takimlar);
        }

        // POST: F119Takimlar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var f119Takimlar = await _context.F119Takimlar.FindAsync(id);
            _context.F119Takimlar.Remove(f119Takimlar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool F119TakimlarExists(int id)
        {
            return _context.F119Takimlar.Any(e => e.TakimId == id);
        }
    }
}
