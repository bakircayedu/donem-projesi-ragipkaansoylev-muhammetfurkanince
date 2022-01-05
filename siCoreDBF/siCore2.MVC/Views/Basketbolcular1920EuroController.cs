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
    public class Basketbolcular1920EuroController : Controller
    {
        private readonly siCoreContext _context;

        public Basketbolcular1920EuroController(siCoreContext context)
        {
            _context = context;
        }

        // GET: Basketbolcular1920Euro
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.Basketbolcular1920Euro.Include(b => b.Takim).OrderByDescending(b => b.AtilanBasketOrtalamasi).Take(5);
            return View(await siCoreContext.ToListAsync());
        }

        
        public async Task<IActionResult> Index2()
        {
            var siCoreContext = _context.Basketbolcular1920Euro.Include(b => b.Takim).OrderByDescending(b => b.YapilanAsistOrtalamasi).Take(5);
            return View(await siCoreContext.ToListAsync());
        }

        // GET: Basketbolcular1920Euro/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbolcular1920Euro = await _context.Basketbolcular1920Euro
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.FutbolcuId == id);
            if (basketbolcular1920Euro == null)
            {
                return NotFound();
            }

            return View(basketbolcular1920Euro);
        }

        // GET: Basketbolcular1920Euro/Create
        public IActionResult Create()
        {
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId");
            return View();
        }

        // POST: Basketbolcular1920Euro/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,FutbolcuId,FutbolcuIsim,AtilanBasketOrtalamasi,YapilanAsistOrtalamasi")] Basketbolcular1920Euro basketbolcular1920Euro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(basketbolcular1920Euro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbolcular1920Euro.TakimId);
            return View(basketbolcular1920Euro);
        }

        // GET: Basketbolcular1920Euro/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbolcular1920Euro = await _context.Basketbolcular1920Euro.FindAsync(id);
            if (basketbolcular1920Euro == null)
            {
                return NotFound();
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbolcular1920Euro.TakimId);
            return View(basketbolcular1920Euro);
        }

        // POST: Basketbolcular1920Euro/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,FutbolcuId,FutbolcuIsim,AtilanBasketOrtalamasi,YapilanAsistOrtalamasi")] Basketbolcular1920Euro basketbolcular1920Euro)
        {
            if (id != basketbolcular1920Euro.FutbolcuId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(basketbolcular1920Euro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Basketbolcular1920EuroExists(basketbolcular1920Euro.FutbolcuId))
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
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbolcular1920Euro.TakimId);
            return View(basketbolcular1920Euro);
        }

        // GET: Basketbolcular1920Euro/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbolcular1920Euro = await _context.Basketbolcular1920Euro
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.FutbolcuId == id);
            if (basketbolcular1920Euro == null)
            {
                return NotFound();
            }

            return View(basketbolcular1920Euro);
        }

        // POST: Basketbolcular1920Euro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var basketbolcular1920Euro = await _context.Basketbolcular1920Euro.FindAsync(id);
            _context.Basketbolcular1920Euro.Remove(basketbolcular1920Euro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Basketbolcular1920EuroExists(int id)
        {
            return _context.Basketbolcular1920Euro.Any(e => e.FutbolcuId == id);
        }
    }
}
