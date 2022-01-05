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
    public class Basketbol1920SezonTrController : Controller
    {
        private readonly siCoreContext _context;

        public Basketbol1920SezonTrController(siCoreContext context)
        {
            _context = context;
        }

        // GET: Basketbol1920SezonTr
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.Basketbol1920SezonTr.Include(f => f.Takim).OrderByDescending(f => f.TakimPuan);
            return View(await siCoreContext.ToListAsync());
        }

        // GET: Basketbol1920SezonTr/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol1920SezonTr = await _context.Basketbol1920SezonTr
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (basketbol1920SezonTr == null)
            {
                return NotFound();
            }

            return View(basketbol1920SezonTr);
        }

        // GET: Basketbol1920SezonTr/Create
        public IActionResult Create()
        {
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId");
            return View();
        }

        // POST: Basketbol1920SezonTr/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,TakimGalibiyet,TakimMaglubiyet,TakimAtılanBasket,TakimYenilenBasket,TakimAveraj,TakimPuan")] Basketbol1920SezonTr basketbol1920SezonTr)
        {
            if (ModelState.IsValid)
            {
                _context.Add(basketbol1920SezonTr);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol1920SezonTr.TakimId);
            return View(basketbol1920SezonTr);
        }

        // GET: Basketbol1920SezonTr/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol1920SezonTr = await _context.Basketbol1920SezonTr.FindAsync(id);
            if (basketbol1920SezonTr == null)
            {
                return NotFound();
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol1920SezonTr.TakimId);
            return View(basketbol1920SezonTr);
        }

        // POST: Basketbol1920SezonTr/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,TakimGalibiyet,TakimMaglubiyet,TakimAtılanBasket,TakimYenilenBasket,TakimAveraj,TakimPuan")] Basketbol1920SezonTr basketbol1920SezonTr)
        {
            if (id != basketbol1920SezonTr.TakimId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(basketbol1920SezonTr);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Basketbol1920SezonTrExists(basketbol1920SezonTr.TakimId))
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
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol1920SezonTr.TakimId);
            return View(basketbol1920SezonTr);
        }

        // GET: Basketbol1920SezonTr/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol1920SezonTr = await _context.Basketbol1920SezonTr
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (basketbol1920SezonTr == null)
            {
                return NotFound();
            }

            return View(basketbol1920SezonTr);
        }

        // POST: Basketbol1920SezonTr/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var basketbol1920SezonTr = await _context.Basketbol1920SezonTr.FindAsync(id);
            _context.Basketbol1920SezonTr.Remove(basketbol1920SezonTr);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Basketbol1920SezonTrExists(int id)
        {
            return _context.Basketbol1920SezonTr.Any(e => e.TakimId == id);
        }
    }
}
