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
    public class Basketbol2122SezonTrController : Controller
    {
        private readonly siCoreContext _context;

        public Basketbol2122SezonTrController(siCoreContext context)
        {
            _context = context;
        }

        // GET: Basketbol2122SezonTr
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.Basketbol2122SezonTr.Include(f => f.Takim).OrderByDescending(f => f.TakimPuan);
            return View(await siCoreContext.ToListAsync());
        }

        // GET: Basketbol2122SezonTr/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol2122SezonTr = await _context.Basketbol2122SezonTr
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (basketbol2122SezonTr == null)
            {
                return NotFound();
            }

            return View(basketbol2122SezonTr);
        }

        // GET: Basketbol2122SezonTr/Create
        public IActionResult Create()
        {
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId");
            return View();
        }

        // POST: Basketbol2122SezonTr/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,TakimGalibiyet,TakimMaglubiyet,TakimAtılanBasket,TakimYenilenBasket,TakimAveraj,TakimPuan")] Basketbol2122SezonTr basketbol2122SezonTr)
        {
            if (ModelState.IsValid)
            {
                _context.Add(basketbol2122SezonTr);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol2122SezonTr.TakimId);
            return View(basketbol2122SezonTr);
        }

        // GET: Basketbol2122SezonTr/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol2122SezonTr = await _context.Basketbol2122SezonTr.FindAsync(id);
            if (basketbol2122SezonTr == null)
            {
                return NotFound();
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol2122SezonTr.TakimId);
            return View(basketbol2122SezonTr);
        }

        // POST: Basketbol2122SezonTr/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,TakimGalibiyet,TakimMaglubiyet,TakimAtılanBasket,TakimYenilenBasket,TakimAveraj,TakimPuan")] Basketbol2122SezonTr basketbol2122SezonTr)
        {
            if (id != basketbol2122SezonTr.TakimId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(basketbol2122SezonTr);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Basketbol2122SezonTrExists(basketbol2122SezonTr.TakimId))
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
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol2122SezonTr.TakimId);
            return View(basketbol2122SezonTr);
        }

        // GET: Basketbol2122SezonTr/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol2122SezonTr = await _context.Basketbol2122SezonTr
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (basketbol2122SezonTr == null)
            {
                return NotFound();
            }

            return View(basketbol2122SezonTr);
        }

        // POST: Basketbol2122SezonTr/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var basketbol2122SezonTr = await _context.Basketbol2122SezonTr.FindAsync(id);
            _context.Basketbol2122SezonTr.Remove(basketbol2122SezonTr);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Basketbol2122SezonTrExists(int id)
        {
            return _context.Basketbol2122SezonTr.Any(e => e.TakimId == id);
        }
    }
}
