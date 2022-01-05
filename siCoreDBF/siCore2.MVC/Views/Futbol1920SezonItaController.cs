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
    public class Futbol1920SezonItaController : Controller
    {
        private readonly siCoreContext _context;

        public Futbol1920SezonItaController(siCoreContext context)
        {
            _context = context;
        }

        // GET: Futbol1920SezonIta
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.Futbol1920SezonIta.Include(f => f.Takim);
            return View(await siCoreContext.ToListAsync());
        }

        // GET: Futbol1920SezonIta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var futbol1920SezonIta = await _context.Futbol1920SezonIta
                .Include(f => f.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (futbol1920SezonIta == null)
            {
                return NotFound();
            }

            return View(futbol1920SezonIta);
        }

        // GET: Futbol1920SezonIta/Create
        public IActionResult Create()
        {
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi");
            return View();
        }

        // POST: Futbol1920SezonIta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,TakimGalibiyet,TakimMaglubiyet,TakimBeraberlik,TakimAtılanGol,TakimYenilenGol,TakimAveraj,TakimPuan")] Futbol1920SezonIta futbol1920SezonIta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(futbol1920SezonIta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi", futbol1920SezonIta.TakimId);
            return View(futbol1920SezonIta);
        }

        // GET: Futbol1920SezonIta/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var futbol1920SezonIta = await _context.Futbol1920SezonIta.FindAsync(id);
            if (futbol1920SezonIta == null)
            {
                return NotFound();
            }
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi", futbol1920SezonIta.TakimId);
            return View(futbol1920SezonIta);
        }

        // POST: Futbol1920SezonIta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,TakimGalibiyet,TakimMaglubiyet,TakimBeraberlik,TakimAtılanGol,TakimYenilenGol,TakimAveraj,TakimPuan")] Futbol1920SezonIta futbol1920SezonIta)
        {
            if (id != futbol1920SezonIta.TakimId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(futbol1920SezonIta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Futbol1920SezonItaExists(futbol1920SezonIta.TakimId))
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
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi", futbol1920SezonIta.TakimId);
            return View(futbol1920SezonIta);
        }

        // GET: Futbol1920SezonIta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var futbol1920SezonIta = await _context.Futbol1920SezonIta
                .Include(f => f.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (futbol1920SezonIta == null)
            {
                return NotFound();
            }

            return View(futbol1920SezonIta);
        }

        // POST: Futbol1920SezonIta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var futbol1920SezonIta = await _context.Futbol1920SezonIta.FindAsync(id);
            _context.Futbol1920SezonIta.Remove(futbol1920SezonIta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Futbol1920SezonItaExists(int id)
        {
            return _context.Futbol1920SezonIta.Any(e => e.TakimId == id);
        }
    }
}
