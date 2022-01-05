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
    public class Basketbol2021SezonEuroController : Controller
    {
        private readonly siCoreContext _context;

        public Basketbol2021SezonEuroController(siCoreContext context)
        {
            _context = context;
        }

        // GET: Basketbol2021SezonEuro
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.Basketbol2021SezonEuro.Include(f => f.Takim).OrderByDescending(f => f.TakimGalibiyet);
            return View(await siCoreContext.ToListAsync());
        }

        // GET: Basketbol2021SezonEuro/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol2021SezonEuro = await _context.Basketbol2021SezonEuro
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (basketbol2021SezonEuro == null)
            {
                return NotFound();
            }

            return View(basketbol2021SezonEuro);
        }

        // GET: Basketbol2021SezonEuro/Create
        public IActionResult Create()
        {
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId");
            return View();
        }

        // POST: Basketbol2021SezonEuro/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,TakimGalibiyet,TakimMaglubiyet,TakimAtılanBasket,TakimYenilenBasket,TakimAveraj,TakimPuan")] Basketbol2021SezonEuro basketbol2021SezonEuro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(basketbol2021SezonEuro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol2021SezonEuro.TakimId);
            return View(basketbol2021SezonEuro);
        }

        // GET: Basketbol2021SezonEuro/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol2021SezonEuro = await _context.Basketbol2021SezonEuro.FindAsync(id);
            if (basketbol2021SezonEuro == null)
            {
                return NotFound();
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol2021SezonEuro.TakimId);
            return View(basketbol2021SezonEuro);
        }

        // POST: Basketbol2021SezonEuro/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,TakimGalibiyet,TakimMaglubiyet,TakimAtılanBasket,TakimYenilenBasket,TakimAveraj,TakimPuan")] Basketbol2021SezonEuro basketbol2021SezonEuro)
        {
            if (id != basketbol2021SezonEuro.TakimId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(basketbol2021SezonEuro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Basketbol2021SezonEuroExists(basketbol2021SezonEuro.TakimId))
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
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol2021SezonEuro.TakimId);
            return View(basketbol2021SezonEuro);
        }

        // GET: Basketbol2021SezonEuro/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol2021SezonEuro = await _context.Basketbol2021SezonEuro
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (basketbol2021SezonEuro == null)
            {
                return NotFound();
            }

            return View(basketbol2021SezonEuro);
        }

        // POST: Basketbol2021SezonEuro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var basketbol2021SezonEuro = await _context.Basketbol2021SezonEuro.FindAsync(id);
            _context.Basketbol2021SezonEuro.Remove(basketbol2021SezonEuro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Basketbol2021SezonEuroExists(int id)
        {
            return _context.Basketbol2021SezonEuro.Any(e => e.TakimId == id);
        }
    }
}
