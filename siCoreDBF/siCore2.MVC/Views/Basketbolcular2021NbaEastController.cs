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
    public class Basketbolcular2021NbaEastController : Controller
    {
        private readonly siCoreContext _context;

        public Basketbolcular2021NbaEastController(siCoreContext context)
        {
            _context = context;
        }

        // GET: Basketbolcular2021NbaEast
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.Basketbolcular2021NbaEast.Include(b => b.Takim).OrderByDescending(b => b.AtilanBasketOrtalamasi).Take(3);
            return View(await siCoreContext.ToListAsync());
        }
           public async Task<IActionResult> Index2()

{
       var siCoreContext = _context.Basketbolcular2021NbaEast.Include(b => b.Takim).OrderByDescending(b => b.YapilanAsistOrtalamasi).Take(3);
            return View(await siCoreContext.ToListAsync());
    }

        // GET: Basketbolcular2021NbaEast/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbolcular2021NbaEast = await _context.Basketbolcular2021NbaEast
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.FutbolcuId == id);
            if (basketbolcular2021NbaEast == null)
            {
                return NotFound();
            }

            return View(basketbolcular2021NbaEast);
        }

        // GET: Basketbolcular2021NbaEast/Create
        public IActionResult Create()
        {
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId");
            return View();
        }

        // POST: Basketbolcular2021NbaEast/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,FutbolcuId,FutbolcuIsim,AtilanBasketOrtalamasi,YapilanAsistOrtalamasi")] Basketbolcular2021NbaEast basketbolcular2021NbaEast)
        {
            if (ModelState.IsValid)
            {
                _context.Add(basketbolcular2021NbaEast);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbolcular2021NbaEast.TakimId);
            return View(basketbolcular2021NbaEast);
        }

        // GET: Basketbolcular2021NbaEast/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbolcular2021NbaEast = await _context.Basketbolcular2021NbaEast.FindAsync(id);
            if (basketbolcular2021NbaEast == null)
            {
                return NotFound();
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbolcular2021NbaEast.TakimId);
            return View(basketbolcular2021NbaEast);
        }

        // POST: Basketbolcular2021NbaEast/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,FutbolcuId,FutbolcuIsim,AtilanBasketOrtalamasi,YapilanAsistOrtalamasi")] Basketbolcular2021NbaEast basketbolcular2021NbaEast)
        {
            if (id != basketbolcular2021NbaEast.FutbolcuId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(basketbolcular2021NbaEast);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Basketbolcular2021NbaEastExists(basketbolcular2021NbaEast.FutbolcuId))
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
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbolcular2021NbaEast.TakimId);
            return View(basketbolcular2021NbaEast);
        }

        // GET: Basketbolcular2021NbaEast/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbolcular2021NbaEast = await _context.Basketbolcular2021NbaEast
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.FutbolcuId == id);
            if (basketbolcular2021NbaEast == null)
            {
                return NotFound();
            }

            return View(basketbolcular2021NbaEast);
        }

        // POST: Basketbolcular2021NbaEast/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var basketbolcular2021NbaEast = await _context.Basketbolcular2021NbaEast.FindAsync(id);
            _context.Basketbolcular2021NbaEast.Remove(basketbolcular2021NbaEast);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Basketbolcular2021NbaEastExists(int id)
        {
            return _context.Basketbolcular2021NbaEast.Any(e => e.FutbolcuId == id);
        }
    }
}
