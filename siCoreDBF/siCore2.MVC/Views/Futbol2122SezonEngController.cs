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
    public class Futbol2122SezonEngController : Controller
    {
        private readonly siCoreContext _context;

        public Futbol2122SezonEngController(siCoreContext context)
        {
            _context = context;
        }

        // GET: Futbol2122SezonEng
        public async Task<IActionResult> Index()
        {
              var siCoreContext = _context.Futbol2122SezonEng.Include(f => f.Takim).OrderByDescending(f=>f.TakimPuan);
            return View(await siCoreContext.ToListAsync());
        }


      


        // GET: Futbol2122SezonEng/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            
            if (id == null)
            {
                return NotFound();
            }

            var futbol2122SezonEng = await _context.Futbol2122SezonEng
                .Include(f => f.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (futbol2122SezonEng == null)
            {
                return NotFound();
            }

            return View(futbol2122SezonEng);
        }

        // GET: Futbol2122SezonEng/Create
        public IActionResult Create()
        {
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi");
            return View();
        }

        // POST: Futbol2122SezonEng/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,TakimGalibiyet,TakimMaglubiyet,TakimBeraberlik,TakimAtılanGol,TakimYenilenGol,TakimAveraj,TakimPuan")] Futbol2122SezonEng futbol2122SezonEng)
        {
            if (ModelState.IsValid)
            {
                _context.Add(futbol2122SezonEng);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi", futbol2122SezonEng.TakimId);
            return View(futbol2122SezonEng);
        }

        // GET: Futbol2122SezonEng/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var futbol2122SezonEng = await _context.Futbol2122SezonEng.FindAsync(id);
            if (futbol2122SezonEng == null)
            {
                return NotFound();
            }
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi", futbol2122SezonEng.TakimId);
            return View(futbol2122SezonEng);
        }

        // POST: Futbol2122SezonEng/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,TakimGalibiyet,TakimMaglubiyet,TakimBeraberlik,TakimAtılanGol,TakimYenilenGol,TakimAveraj,TakimPuan")] Futbol2122SezonEng futbol2122SezonEng)
        {
            if (id != futbol2122SezonEng.TakimId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(futbol2122SezonEng);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Futbol2122SezonEngExists(futbol2122SezonEng.TakimId))
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
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi", futbol2122SezonEng.TakimId);
            return View(futbol2122SezonEng);
        }

        // GET: Futbol2122SezonEng/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var futbol2122SezonEng = await _context.Futbol2122SezonEng
                .Include(f => f.Takim)
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (futbol2122SezonEng == null)
            {
                return NotFound();
            }

            return View(futbol2122SezonEng);
        }

        // POST: Futbol2122SezonEng/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var futbol2122SezonEng = await _context.Futbol2122SezonEng.FindAsync(id);
            _context.Futbol2122SezonEng.Remove(futbol2122SezonEng);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Futbol2122SezonEngExists(int id)
        {
            return _context.Futbol2122SezonEng.Any(e => e.TakimId == id);
        }
    }
}
