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
    public class Basketbol2021SezonTrController : Controller
    {
        private readonly siCoreContext _context;

        public Basketbol2021SezonTrController(siCoreContext context)
        {
            _context = context;
        }

        // GET: Basketbol2021SezonTr
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.Basketbol2021SezonTr.Include(f => f.Takim).OrderByDescending(f => f.TakimPuan);
            return View(await siCoreContext.ToListAsync());
        }

        // GET: Basketbol2021SezonTr/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol2021SezonTr = await _context.Basketbol2021SezonTr
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (basketbol2021SezonTr == null)
            {
                return NotFound();
            }

            return View(basketbol2021SezonTr);
        }

        // GET: Basketbol2021SezonTr/Create
        public IActionResult Create()
        {
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId");
            return View();
        }

        // POST: Basketbol2021SezonTr/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,TakimGalibiyet,TakimMaglubiyet,TakimAtılanBasket,TakimYenilenBasket,TakimAveraj,TakimPuan")] Basketbol2021SezonTr basketbol2021SezonTr)
        {
            if (ModelState.IsValid)
            {
                _context.Add(basketbol2021SezonTr);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol2021SezonTr.TakimId);
            return View(basketbol2021SezonTr);
        }

        // GET: Basketbol2021SezonTr/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol2021SezonTr = await _context.Basketbol2021SezonTr.FindAsync(id);
            if (basketbol2021SezonTr == null)
            {
                return NotFound();
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol2021SezonTr.TakimId);
            return View(basketbol2021SezonTr);
        }

        // POST: Basketbol2021SezonTr/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,TakimGalibiyet,TakimMaglubiyet,TakimAtılanBasket,TakimYenilenBasket,TakimAveraj,TakimPuan")] Basketbol2021SezonTr basketbol2021SezonTr)
        {
            if (id != basketbol2021SezonTr.TakimId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(basketbol2021SezonTr);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Basketbol2021SezonTrExists(basketbol2021SezonTr.TakimId))
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
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbol2021SezonTr.TakimId);
            return View(basketbol2021SezonTr);
        }

        // GET: Basketbol2021SezonTr/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbol2021SezonTr = await _context.Basketbol2021SezonTr
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (basketbol2021SezonTr == null)
            {
                return NotFound();
            }

            return View(basketbol2021SezonTr);
        }

        // POST: Basketbol2021SezonTr/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var basketbol2021SezonTr = await _context.Basketbol2021SezonTr.FindAsync(id);
            _context.Basketbol2021SezonTr.Remove(basketbol2021SezonTr);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Basketbol2021SezonTrExists(int id)
        {
            return _context.Basketbol2021SezonTr.Any(e => e.TakimId == id);
        }
    }
}
