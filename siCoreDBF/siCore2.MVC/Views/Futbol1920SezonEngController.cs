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
    public class Futbol1920SezonEngController : Controller
    {
        private readonly siCoreContext _context;

        public Futbol1920SezonEngController(siCoreContext context)
        {
            _context = context;
        }

        // GET: Futbol1920SezonEng
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.Futbol1920SezonEng.Include(f => f.Takim);
            return View(await siCoreContext.ToListAsync());
        }

        // GET: Futbol1920SezonEng/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var futbol1920SezonEng = await _context.Futbol1920SezonEng
                .Include(f => f.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (futbol1920SezonEng == null)
            {
                return NotFound();
            }

            return View(futbol1920SezonEng);
        }

        // GET: Futbol1920SezonEng/Create
        public IActionResult Create()
        {
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi");
            return View();
        }

        // POST: Futbol1920SezonEng/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,TakimGalibiyet,TakimMaglubiyet,TakimBeraberlik,TakimAtılanGol,TakimYenilenGol,TakimAveraj,TakimPuan")] Futbol1920SezonEng futbol1920SezonEng)
        {
            if (ModelState.IsValid)
            {
                _context.Add(futbol1920SezonEng);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi", futbol1920SezonEng.TakimId);
            return View(futbol1920SezonEng);
        }

        // GET: Futbol1920SezonEng/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var futbol1920SezonEng = await _context.Futbol1920SezonEng.FindAsync(id);
            if (futbol1920SezonEng == null)
            {
                return NotFound();
            }
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi", futbol1920SezonEng.TakimId);
            return View(futbol1920SezonEng);
        }

        // POST: Futbol1920SezonEng/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,TakimGalibiyet,TakimMaglubiyet,TakimBeraberlik,TakimAtılanGol,TakimYenilenGol,TakimAveraj,TakimPuan")] Futbol1920SezonEng futbol1920SezonEng)
        {
            if (id != futbol1920SezonEng.TakimId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(futbol1920SezonEng);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Futbol1920SezonEngExists(futbol1920SezonEng.TakimId))
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
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi", futbol1920SezonEng.TakimId);
            return View(futbol1920SezonEng);
        }

        // GET: Futbol1920SezonEng/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var futbol1920SezonEng = await _context.Futbol1920SezonEng
                .Include(f => f.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (futbol1920SezonEng == null)
            {
                return NotFound();
            }

            return View(futbol1920SezonEng);
        }

        // POST: Futbol1920SezonEng/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var futbol1920SezonEng = await _context.Futbol1920SezonEng.FindAsync(id);
            _context.Futbol1920SezonEng.Remove(futbol1920SezonEng);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Futbol1920SezonEngExists(int id)
        {
            return _context.Futbol1920SezonEng.Any(e => e.TakimId == id);
        }
    }
}
