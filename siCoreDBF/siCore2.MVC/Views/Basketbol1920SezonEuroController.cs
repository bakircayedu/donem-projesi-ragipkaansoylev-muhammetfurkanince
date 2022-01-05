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
    public class Basketbol1920SezonEuroController : Controller
    {
        private readonly siCoreContext _context;
        

        public Basketbol1920SezonEuroController(siCoreContext context)
        {
            _context = context;
        }

        // GET: Basketbol1920SezonEuro
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.Basketbol1920SezonEuro.Include(f => f.Takim).OrderByDescending(f => f.TakimGalibiyet);
            return View(await siCoreContext.ToListAsync());
        }

        // GET: Basketbol1920SezonEuro/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol1920SezonEuro = await _context.Basketbol1920SezonEuro
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (basketbol1920SezonEuro == null)
            {
                return NotFound();
            }

            return View(basketbol1920SezonEuro);
        }

        // GET: Basketbol1920SezonEuro/Create
        public IActionResult Create()
        {
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId");
            return View();
        }

        // POST: Basketbol1920SezonEuro/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,TakimGalibiyet,TakimMaglubiyet,TakimAtılanBasket,TakimYenilenBasket,TakimAveraj,TakimPuan")] Basketbol1920SezonEuro basketbol1920SezonEuro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(basketbol1920SezonEuro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol1920SezonEuro.TakimId);
            return View(basketbol1920SezonEuro);
        }

        // GET: Basketbol1920SezonEuro/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol1920SezonEuro = await _context.Basketbol1920SezonEuro.FindAsync(id);
            if (basketbol1920SezonEuro == null)
            {
                return NotFound();
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol1920SezonEuro.TakimId);
            return View(basketbol1920SezonEuro);
        }

        // POST: Basketbol1920SezonEuro/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,TakimGalibiyet,TakimMaglubiyet,TakimAtılanBasket,TakimYenilenBasket,TakimAveraj,TakimPuan")] Basketbol1920SezonEuro basketbol1920SezonEuro)
        {
            if (id != basketbol1920SezonEuro.TakimId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(basketbol1920SezonEuro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Basketbol1920SezonEuroExists(basketbol1920SezonEuro.TakimId))
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
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol1920SezonEuro.TakimId);
            return View(basketbol1920SezonEuro);
        }

        // GET: Basketbol1920SezonEuro/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol1920SezonEuro = await _context.Basketbol1920SezonEuro
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (basketbol1920SezonEuro == null)
            {
                return NotFound();
            }

            return View(basketbol1920SezonEuro);
        }

        // POST: Basketbol1920SezonEuro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var basketbol1920SezonEuro = await _context.Basketbol1920SezonEuro.FindAsync(id);
            _context.Basketbol1920SezonEuro.Remove(basketbol1920SezonEuro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Basketbol1920SezonEuroExists(int id)
        {
            return _context.Basketbol1920SezonEuro.Any(e => e.TakimId == id);
        }
    }
}
