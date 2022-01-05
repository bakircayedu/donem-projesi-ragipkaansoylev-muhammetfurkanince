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
    public class Futbol2021SezonEngController : Controller
    {
        private readonly siCoreContext _context;

        public Futbol2021SezonEngController(siCoreContext context)
        {
            _context = context;
        }

        // GET: Futbol2021SezonEng
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.Futbol2021SezonEng.Include(f => f.Takim).OrderByDescending(f => f.TakimPuan);
            return View(await siCoreContext.ToListAsync());
        }

        // GET: Futbol2021SezonEng/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var futbol2021SezonEng = await _context.Futbol2021SezonEng
                .Include(f => f.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (futbol2021SezonEng == null)
            {
                return NotFound();
            }

            return View(futbol2021SezonEng);
        }

        // GET: Futbol2021SezonEng/Create
        public IActionResult Create()
        {
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi");
            return View();
        }

        // POST: Futbol2021SezonEng/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,TakimGalibiyet,TakimMaglubiyet,TakimBeraberlik,TakimAtılanGol,TakimYenilenGol,TakimAveraj,TakimPuan")] Futbol2021SezonEng futbol2021SezonEng)
        {
            if (ModelState.IsValid)
            {
                _context.Add(futbol2021SezonEng);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi", futbol2021SezonEng.TakimId);
            return View(futbol2021SezonEng);
        }

        // GET: Futbol2021SezonEng/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var futbol2021SezonEng = await _context.Futbol2021SezonEng.FindAsync(id);
            if (futbol2021SezonEng == null)
            {
                return NotFound();
            }
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi", futbol2021SezonEng.TakimId);
            return View(futbol2021SezonEng);
        }

        // POST: Futbol2021SezonEng/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,TakimGalibiyet,TakimMaglubiyet,TakimBeraberlik,TakimAtılanGol,TakimYenilenGol,TakimAveraj,TakimPuan")] Futbol2021SezonEng futbol2021SezonEng)
        {
            if (id != futbol2021SezonEng.TakimId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(futbol2021SezonEng);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Futbol2021SezonEngExists(futbol2021SezonEng.TakimId))
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
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi", futbol2021SezonEng.TakimId);
            return View(futbol2021SezonEng);
        }

        // GET: Futbol2021SezonEng/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var futbol2021SezonEng = await _context.Futbol2021SezonEng
                .Include(f => f.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (futbol2021SezonEng == null)
            {
                return NotFound();
            }

            return View(futbol2021SezonEng);
        }

        // POST: Futbol2021SezonEng/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var futbol2021SezonEng = await _context.Futbol2021SezonEng.FindAsync(id);
            _context.Futbol2021SezonEng.Remove(futbol2021SezonEng);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Futbol2021SezonEngExists(int id)
        {
            return _context.Futbol2021SezonEng.Any(e => e.TakimId == id);
        }
    }
}
