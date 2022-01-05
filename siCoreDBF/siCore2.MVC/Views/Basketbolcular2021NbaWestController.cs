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
    public class Basketbolcular2021NbaWestController : Controller
    {
        private readonly siCoreContext _context;

        public Basketbolcular2021NbaWestController(siCoreContext context)
        {
            _context = context;
        }

        // GET: Basketbolcular2021NbaWest
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.Basketbolcular2021NbaWest.Include(b => b.Takim).OrderByDescending(b => b.AtilanBasketOrtalamasi).Take(5);;
            return View(await siCoreContext.ToListAsync());
        }
   public async Task<IActionResult> Index2()
        {
            var siCoreContext = _context.Basketbolcular2021NbaWest.Include(b => b.Takim).OrderByDescending(b => b.YapilanAsistOrtalamasi).Take(5);
            return View(await siCoreContext.ToListAsync());
        }
        // GET: Basketbolcular2021NbaWest/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbolcular2021NbaWest = await _context.Basketbolcular2021NbaWest
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.FutbolcuId == id);
            if (basketbolcular2021NbaWest == null)
            {
                return NotFound();
            }

            return View(basketbolcular2021NbaWest);
        }

        // GET: Basketbolcular2021NbaWest/Create
        public IActionResult Create()
        {
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId");
            return View();
        }

        // POST: Basketbolcular2021NbaWest/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,FutbolcuId,FutbolcuIsim,AtilanBasketOrtalamasi,YapilanAsistOrtalamasi")] Basketbolcular2021NbaWest basketbolcular2021NbaWest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(basketbolcular2021NbaWest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbolcular2021NbaWest.TakimId);
            return View(basketbolcular2021NbaWest);
        }

        // GET: Basketbolcular2021NbaWest/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbolcular2021NbaWest = await _context.Basketbolcular2021NbaWest.FindAsync(id);
            if (basketbolcular2021NbaWest == null)
            {
                return NotFound();
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbolcular2021NbaWest.TakimId);
            return View(basketbolcular2021NbaWest);
        }

        // POST: Basketbolcular2021NbaWest/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,FutbolcuId,FutbolcuIsim,AtilanBasketOrtalamasi,YapilanAsistOrtalamasi")] Basketbolcular2021NbaWest basketbolcular2021NbaWest)
        {
            if (id != basketbolcular2021NbaWest.FutbolcuId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(basketbolcular2021NbaWest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Basketbolcular2021NbaWestExists(basketbolcular2021NbaWest.FutbolcuId))
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
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbolcular2021NbaWest.TakimId);
            return View(basketbolcular2021NbaWest);
        }

        // GET: Basketbolcular2021NbaWest/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbolcular2021NbaWest = await _context.Basketbolcular2021NbaWest
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.FutbolcuId == id);
            if (basketbolcular2021NbaWest == null)
            {
                return NotFound();
            }

            return View(basketbolcular2021NbaWest);
        }

        // POST: Basketbolcular2021NbaWest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var basketbolcular2021NbaWest = await _context.Basketbolcular2021NbaWest.FindAsync(id);
            _context.Basketbolcular2021NbaWest.Remove(basketbolcular2021NbaWest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Basketbolcular2021NbaWestExists(int id)
        {
            return _context.Basketbolcular2021NbaWest.Any(e => e.FutbolcuId == id);
        }
    }
}
