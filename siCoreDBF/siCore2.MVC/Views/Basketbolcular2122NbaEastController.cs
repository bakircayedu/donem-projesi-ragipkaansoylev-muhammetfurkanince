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
    public class Basketbolcular2122NbaEastController : Controller
    {
        private readonly siCoreContext _context;

        public Basketbolcular2122NbaEastController(siCoreContext context)
        {
            _context = context;
        }

        // GET: Basketbolcular2122NbaEast
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.Basketbolcular2122NbaEast.Include(b => b.Takim).OrderByDescending(b => b.AtilanBasketOrtalamasi).Take(5);;
            return View(await siCoreContext.ToListAsync());

        }
           public async Task<IActionResult> Index2()
        {
            var siCoreContext = _context.Basketbolcular2122NbaEast.Include(b => b.Takim).OrderByDescending(b => b.YapilanAsistOrtalamasi).Take(5);
            return View(await siCoreContext.ToListAsync());
        }

        // GET: Basketbolcular2122NbaEast/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbolcular2122NbaEast = await _context.Basketbolcular2122NbaEast
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.FutbolcuId == id);
            if (basketbolcular2122NbaEast == null)
            {
                return NotFound();
            }

            return View(basketbolcular2122NbaEast);
        }

        // GET: Basketbolcular2122NbaEast/Create
        public IActionResult Create()
        {
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId");
            return View();
        }

        // POST: Basketbolcular2122NbaEast/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,FutbolcuId,FutbolcuIsim,AtilanBasketOrtalamasi,YapilanAsistOrtalamasi")] Basketbolcular2122NbaEast basketbolcular2122NbaEast)
        {
            if (ModelState.IsValid)
            {
                _context.Add(basketbolcular2122NbaEast);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbolcular2122NbaEast.TakimId);
            return View(basketbolcular2122NbaEast);
        }

        // GET: Basketbolcular2122NbaEast/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbolcular2122NbaEast = await _context.Basketbolcular2122NbaEast.FindAsync(id);
            if (basketbolcular2122NbaEast == null)
            {
                return NotFound();
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbolcular2122NbaEast.TakimId);
            return View(basketbolcular2122NbaEast);
        }

        // POST: Basketbolcular2122NbaEast/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,FutbolcuId,FutbolcuIsim,AtilanBasketOrtalamasi,YapilanAsistOrtalamasi")] Basketbolcular2122NbaEast basketbolcular2122NbaEast)
        {
            if (id != basketbolcular2122NbaEast.FutbolcuId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(basketbolcular2122NbaEast);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Basketbolcular2122NbaEastExists(basketbolcular2122NbaEast.FutbolcuId))
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
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbolcular2122NbaEast.TakimId);
            return View(basketbolcular2122NbaEast);
        }

        // GET: Basketbolcular2122NbaEast/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbolcular2122NbaEast = await _context.Basketbolcular2122NbaEast
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.FutbolcuId == id);
            if (basketbolcular2122NbaEast == null)
            {
                return NotFound();
            }

            return View(basketbolcular2122NbaEast);
        }

        // POST: Basketbolcular2122NbaEast/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var basketbolcular2122NbaEast = await _context.Basketbolcular2122NbaEast.FindAsync(id);
            _context.Basketbolcular2122NbaEast.Remove(basketbolcular2122NbaEast);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Basketbolcular2122NbaEastExists(int id)
        {
            return _context.Basketbolcular2122NbaEast.Any(e => e.FutbolcuId == id);
        }
    }
}
