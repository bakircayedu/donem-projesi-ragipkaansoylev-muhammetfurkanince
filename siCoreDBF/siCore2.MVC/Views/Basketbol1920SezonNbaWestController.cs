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
    public class Basketbol1920SezonNbaWestController : Controller
    {
        private readonly siCoreContext _context;

        public Basketbol1920SezonNbaWestController(siCoreContext context)
        {
            _context = context;
        }

        // GET: Basketbol1920SezonNbaWest
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.Basketbol1920SezonNbaWest.Include(f => f.Takim).OrderByDescending(f => f.TakimGalibiyet);
            return View(await siCoreContext.ToListAsync());
        }

        // GET: Basketbol1920SezonNbaWest/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol1920SezonNbaWest = await _context.Basketbol1920SezonNbaWest
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (basketbol1920SezonNbaWest == null)
            {
                return NotFound();
            }

            return View(basketbol1920SezonNbaWest);
        }

        // GET: Basketbol1920SezonNbaWest/Create
        public IActionResult Create()
        {
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId");
            return View();
        }

        // POST: Basketbol1920SezonNbaWest/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,TakimGalibiyet,TakimMaglubiyet,TakimAtılanBasket,TakimYenilenBasket,TakimAveraj")] Basketbol1920SezonNbaWest basketbol1920SezonNbaWest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(basketbol1920SezonNbaWest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol1920SezonNbaWest.TakimId);
            return View(basketbol1920SezonNbaWest);
        }

        // GET: Basketbol1920SezonNbaWest/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol1920SezonNbaWest = await _context.Basketbol1920SezonNbaWest.FindAsync(id);
            if (basketbol1920SezonNbaWest == null)
            {
                return NotFound();
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol1920SezonNbaWest.TakimId);
            return View(basketbol1920SezonNbaWest);
        }

        // POST: Basketbol1920SezonNbaWest/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,TakimGalibiyet,TakimMaglubiyet,TakimAtılanBasket,TakimYenilenBasket,TakimAveraj")] Basketbol1920SezonNbaWest basketbol1920SezonNbaWest)
        {
            if (id != basketbol1920SezonNbaWest.TakimId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(basketbol1920SezonNbaWest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Basketbol1920SezonNbaWestExists(basketbol1920SezonNbaWest.TakimId))
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
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol1920SezonNbaWest.TakimId);
            return View(basketbol1920SezonNbaWest);
        }

        // GET: Basketbol1920SezonNbaWest/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol1920SezonNbaWest = await _context.Basketbol1920SezonNbaWest
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (basketbol1920SezonNbaWest == null)
            {
                return NotFound();
            }

            return View(basketbol1920SezonNbaWest);
        }

        // POST: Basketbol1920SezonNbaWest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var basketbol1920SezonNbaWest = await _context.Basketbol1920SezonNbaWest.FindAsync(id);
            _context.Basketbol1920SezonNbaWest.Remove(basketbol1920SezonNbaWest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Basketbol1920SezonNbaWestExists(int id)
        {
            return _context.Basketbol1920SezonNbaWest.Any(e => e.TakimId == id);
        }
    }
}
