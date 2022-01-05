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
    public class Basketbolcular1920NbaEastController : Controller
    {
        private readonly siCoreContext _context;

        public Basketbolcular1920NbaEastController(siCoreContext context)
        {
            _context = context;
        }

        // GET: Basketbolcular1920NbaEast
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.Basketbolcular1920NbaEast.Include(b => b.Takim).OrderByDescending(b => b.AtilanBasketOrtalamasi).Take(5);;
            return View(await siCoreContext.ToListAsync());
        }
           public async Task<IActionResult> Index2()
        {
            var siCoreContext = _context.Basketbolcular1920NbaEast.Include(b => b.Takim).OrderByDescending(b => b.YapilanAsistOrtalamasi).Take(5);
            return View(await siCoreContext.ToListAsync());
        }

        // GET: Basketbolcular1920NbaEast/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbolcular1920NbaEast = await _context.Basketbolcular1920NbaEast
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.FutbolcuId == id);
            if (basketbolcular1920NbaEast == null)
            {
                return NotFound();
            }

            return View(basketbolcular1920NbaEast);
        }

        // GET: Basketbolcular1920NbaEast/Create
        public IActionResult Create()
        {
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId");
            return View();
        }

        // POST: Basketbolcular1920NbaEast/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,FutbolcuId,FutbolcuIsim,AtilanBasketOrtalamasi,YapilanAsistOrtalamasi")] Basketbolcular1920NbaEast basketbolcular1920NbaEast)
        {
            if (ModelState.IsValid)
            {
                _context.Add(basketbolcular1920NbaEast);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbolcular1920NbaEast.TakimId);
            return View(basketbolcular1920NbaEast);
        }

        // GET: Basketbolcular1920NbaEast/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbolcular1920NbaEast = await _context.Basketbolcular1920NbaEast.FindAsync(id);
            if (basketbolcular1920NbaEast == null)
            {
                return NotFound();
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbolcular1920NbaEast.TakimId);
            return View(basketbolcular1920NbaEast);
        }

        // POST: Basketbolcular1920NbaEast/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,FutbolcuId,FutbolcuIsim,AtilanBasketOrtalamasi,YapilanAsistOrtalamasi")] Basketbolcular1920NbaEast basketbolcular1920NbaEast)
        {
            if (id != basketbolcular1920NbaEast.FutbolcuId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(basketbolcular1920NbaEast);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Basketbolcular1920NbaEastExists(basketbolcular1920NbaEast.FutbolcuId))
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
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbolcular1920NbaEast.TakimId);
            return View(basketbolcular1920NbaEast);
        }

        // GET: Basketbolcular1920NbaEast/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbolcular1920NbaEast = await _context.Basketbolcular1920NbaEast
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.FutbolcuId == id);
            if (basketbolcular1920NbaEast == null)
            {
                return NotFound();
            }

            return View(basketbolcular1920NbaEast);
        }

        // POST: Basketbolcular1920NbaEast/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var basketbolcular1920NbaEast = await _context.Basketbolcular1920NbaEast.FindAsync(id);
            _context.Basketbolcular1920NbaEast.Remove(basketbolcular1920NbaEast);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Basketbolcular1920NbaEastExists(int id)
        {
            return _context.Basketbolcular1920NbaEast.Any(e => e.FutbolcuId == id);
        }
    }
}
