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
    public class Basketbol2021SezonNbaWestController : Controller
    {
        private readonly siCoreContext _context;

        public Basketbol2021SezonNbaWestController(siCoreContext context)
        {
            _context = context;
        }

        // GET: Basketbol2021SezonNbaWest
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.Basketbol2021SezonNbaWest.Include(f => f.Takim).OrderByDescending(f => f.TakimGalibiyet);
            return View(await siCoreContext.ToListAsync());
        }

        // GET: Basketbol2021SezonNbaWest/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol2021SezonNbaWest = await _context.Basketbol2021SezonNbaWest
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (basketbol2021SezonNbaWest == null)
            {
                return NotFound();
            }

            return View(basketbol2021SezonNbaWest);
        }

        // GET: Basketbol2021SezonNbaWest/Create
        public IActionResult Create()
        {
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId");
            return View();
        }

        // POST: Basketbol2021SezonNbaWest/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,TakimGalibiyet,TakimMaglubiyet,TakimAtılanBasket,TakimYenilenBasket,TakimAveraj")] Basketbol2021SezonNbaWest basketbol2021SezonNbaWest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(basketbol2021SezonNbaWest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol2021SezonNbaWest.TakimId);
            return View(basketbol2021SezonNbaWest);
        }

        // GET: Basketbol2021SezonNbaWest/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol2021SezonNbaWest = await _context.Basketbol2021SezonNbaWest.FindAsync(id);
            if (basketbol2021SezonNbaWest == null)
            {
                return NotFound();
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol2021SezonNbaWest.TakimId);
            return View(basketbol2021SezonNbaWest);
        }

        // POST: Basketbol2021SezonNbaWest/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,TakimGalibiyet,TakimMaglubiyet,TakimAtılanBasket,TakimYenilenBasket,TakimAveraj")] Basketbol2021SezonNbaWest basketbol2021SezonNbaWest)
        {
            if (id != basketbol2021SezonNbaWest.TakimId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(basketbol2021SezonNbaWest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Basketbol2021SezonNbaWestExists(basketbol2021SezonNbaWest.TakimId))
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
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol2021SezonNbaWest.TakimId);
            return View(basketbol2021SezonNbaWest);
        }

        // GET: Basketbol2021SezonNbaWest/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol2021SezonNbaWest = await _context.Basketbol2021SezonNbaWest
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (basketbol2021SezonNbaWest == null)
            {
                return NotFound();
            }

            return View(basketbol2021SezonNbaWest);
        }

        // POST: Basketbol2021SezonNbaWest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var basketbol2021SezonNbaWest = await _context.Basketbol2021SezonNbaWest.FindAsync(id);
            _context.Basketbol2021SezonNbaWest.Remove(basketbol2021SezonNbaWest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Basketbol2021SezonNbaWestExists(int id)
        {
            return _context.Basketbol2021SezonNbaWest.Any(e => e.TakimId == id);
        }
    }
}
