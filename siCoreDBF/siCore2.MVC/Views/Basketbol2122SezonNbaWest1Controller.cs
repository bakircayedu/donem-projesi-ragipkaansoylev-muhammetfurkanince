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
    public class Basketbol2122SezonNbaWest1Controller : Controller
    {
        private readonly siCoreContext _context;

        public Basketbol2122SezonNbaWest1Controller(siCoreContext context)
        {
            _context = context;
        }

        // GET: Basketbol2122SezonNbaWest1
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.Basketbol2122SezonNbaWest.Include(b => b.Takim);
            return View(await siCoreContext.ToListAsync());
        }

        // GET: Basketbol2122SezonNbaWest1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol2122SezonNbaWest = await _context.Basketbol2122SezonNbaWest
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (basketbol2122SezonNbaWest == null)
            {
                return NotFound();
            }

            return View(basketbol2122SezonNbaWest);
        }

        // GET: Basketbol2122SezonNbaWest1/Create
        public IActionResult Create()
        {
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId");
            return View();
        }

        // POST: Basketbol2122SezonNbaWest1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,TakimGalibiyet,TakimMaglubiyet,TakimAtılanBasket,TakimYenilenBasket,TakimAveraj")] Basketbol2122SezonNbaWest basketbol2122SezonNbaWest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(basketbol2122SezonNbaWest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol2122SezonNbaWest.TakimId);
            return View(basketbol2122SezonNbaWest);
        }

        // GET: Basketbol2122SezonNbaWest1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol2122SezonNbaWest = await _context.Basketbol2122SezonNbaWest.FindAsync(id);
            if (basketbol2122SezonNbaWest == null)
            {
                return NotFound();
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol2122SezonNbaWest.TakimId);
            return View(basketbol2122SezonNbaWest);
        }

        // POST: Basketbol2122SezonNbaWest1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,TakimGalibiyet,TakimMaglubiyet,TakimAtılanBasket,TakimYenilenBasket,TakimAveraj")] Basketbol2122SezonNbaWest basketbol2122SezonNbaWest)
        {
            if (id != basketbol2122SezonNbaWest.TakimId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(basketbol2122SezonNbaWest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Basketbol2122SezonNbaWestExists(basketbol2122SezonNbaWest.TakimId))
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
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol2122SezonNbaWest.TakimId);
            return View(basketbol2122SezonNbaWest);
        }

        // GET: Basketbol2122SezonNbaWest1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol2122SezonNbaWest = await _context.Basketbol2122SezonNbaWest
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (basketbol2122SezonNbaWest == null)
            {
                return NotFound();
            }

            return View(basketbol2122SezonNbaWest);
        }

        // POST: Basketbol2122SezonNbaWest1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var basketbol2122SezonNbaWest = await _context.Basketbol2122SezonNbaWest.FindAsync(id);
            _context.Basketbol2122SezonNbaWest.Remove(basketbol2122SezonNbaWest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Basketbol2122SezonNbaWestExists(int id)
        {
            return _context.Basketbol2122SezonNbaWest.Any(e => e.TakimId == id);
        }
    }
}
