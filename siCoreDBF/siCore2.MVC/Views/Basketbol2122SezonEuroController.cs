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
    public class Basketbol2122SezonEuroController : Controller
    {
        private readonly siCoreContext _context;

        public Basketbol2122SezonEuroController(siCoreContext context)
        {
            _context = context;
        }

        // GET: Basketbol2122SezonEuro
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.Basketbol2122SezonEuro.Include(f => f.Takim).OrderByDescending(f => f.TakimGalibiyet);
            return View(await siCoreContext.ToListAsync());
        }

        // GET: Basketbol2122SezonEuro/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol2122SezonEuro = await _context.Basketbol2122SezonEuro
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (basketbol2122SezonEuro == null)
            {
                return NotFound();
            }

            return View(basketbol2122SezonEuro);
        }

        // GET: Basketbol2122SezonEuro/Create
        public IActionResult Create()
        {
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId");
            return View();
        }

        // POST: Basketbol2122SezonEuro/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,TakimGalibiyet,TakimMaglubiyet,TakimAtılanBasket,TakimYenilenBasket,TakimAveraj,TakimPuan")] Basketbol2122SezonEuro basketbol2122SezonEuro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(basketbol2122SezonEuro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol2122SezonEuro.TakimId);
            return View(basketbol2122SezonEuro);
        }

        // GET: Basketbol2122SezonEuro/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol2122SezonEuro = await _context.Basketbol2122SezonEuro.FindAsync(id);
            if (basketbol2122SezonEuro == null)
            {
                return NotFound();
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol2122SezonEuro.TakimId);
            return View(basketbol2122SezonEuro);
        }

        // POST: Basketbol2122SezonEuro/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,TakimGalibiyet,TakimMaglubiyet,TakimAtılanBasket,TakimYenilenBasket,TakimAveraj,TakimPuan")] Basketbol2122SezonEuro basketbol2122SezonEuro)
        {
            if (id != basketbol2122SezonEuro.TakimId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(basketbol2122SezonEuro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Basketbol2122SezonEuroExists(basketbol2122SezonEuro.TakimId))
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
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol2122SezonEuro.TakimId);
            return View(basketbol2122SezonEuro);
        }

        // GET: Basketbol2122SezonEuro/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol2122SezonEuro = await _context.Basketbol2122SezonEuro
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (basketbol2122SezonEuro == null)
            {
                return NotFound();
            }

            return View(basketbol2122SezonEuro);
        }

        // POST: Basketbol2122SezonEuro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var basketbol2122SezonEuro = await _context.Basketbol2122SezonEuro.FindAsync(id);
            _context.Basketbol2122SezonEuro.Remove(basketbol2122SezonEuro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Basketbol2122SezonEuroExists(int id)
        {
            return _context.Basketbol2122SezonEuro.Any(e => e.TakimId == id);
        }
    }
}
