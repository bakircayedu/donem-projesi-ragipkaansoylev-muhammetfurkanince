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
    public class Basketbol2021SezonNbaEastController : Controller
    {
        private readonly siCoreContext _context;

        public Basketbol2021SezonNbaEastController(siCoreContext context)
        {
            _context = context;
        }

        // GET: Basketbol2021SezonNbaEast
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.Basketbol2021SezonNbaEast.Include(f => f.Takim).OrderByDescending(f => f.TakimGalibiyet);
            return View(await siCoreContext.ToListAsync());
        }

        // GET: Basketbol2021SezonNbaEast/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol2021SezonNbaEast = await _context.Basketbol2021SezonNbaEast
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (basketbol2021SezonNbaEast == null)
            {
                return NotFound();
            }

            return View(basketbol2021SezonNbaEast);
        }

        // GET: Basketbol2021SezonNbaEast/Create
        public IActionResult Create()
        {
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId");
            return View();
        }

        // POST: Basketbol2021SezonNbaEast/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,TakimGalibiyet,TakimMaglubiyet,TakimAtılanBasket,TakimYenilenBasket,TakimAveraj")] Basketbol2021SezonNbaEast basketbol2021SezonNbaEast)
        {
            if (ModelState.IsValid)
            {
                _context.Add(basketbol2021SezonNbaEast);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol2021SezonNbaEast.TakimId);
            return View(basketbol2021SezonNbaEast);
        }

        // GET: Basketbol2021SezonNbaEast/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol2021SezonNbaEast = await _context.Basketbol2021SezonNbaEast.FindAsync(id);
            if (basketbol2021SezonNbaEast == null)
            {
                return NotFound();
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol2021SezonNbaEast.TakimId);
            return View(basketbol2021SezonNbaEast);
        }

        // POST: Basketbol2021SezonNbaEast/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,TakimGalibiyet,TakimMaglubiyet,TakimAtılanBasket,TakimYenilenBasket,TakimAveraj")] Basketbol2021SezonNbaEast basketbol2021SezonNbaEast)
        {
            if (id != basketbol2021SezonNbaEast.TakimId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(basketbol2021SezonNbaEast);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Basketbol2021SezonNbaEastExists(basketbol2021SezonNbaEast.TakimId))
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
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol2021SezonNbaEast.TakimId);
            return View(basketbol2021SezonNbaEast);
        }

        // GET: Basketbol2021SezonNbaEast/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol2021SezonNbaEast = await _context.Basketbol2021SezonNbaEast
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (basketbol2021SezonNbaEast == null)
            {
                return NotFound();
            }

            return View(basketbol2021SezonNbaEast);
        }

        // POST: Basketbol2021SezonNbaEast/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var basketbol2021SezonNbaEast = await _context.Basketbol2021SezonNbaEast.FindAsync(id);
            _context.Basketbol2021SezonNbaEast.Remove(basketbol2021SezonNbaEast);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Basketbol2021SezonNbaEastExists(int id)
        {
            return _context.Basketbol2021SezonNbaEast.Any(e => e.TakimId == id);
        }
    }
}
