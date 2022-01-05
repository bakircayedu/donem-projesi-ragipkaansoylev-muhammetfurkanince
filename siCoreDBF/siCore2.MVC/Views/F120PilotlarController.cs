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
    public class F120PilotlarController : Controller
    {
        private readonly siCoreContext _context;

        public F120PilotlarController(siCoreContext context)
        {
            _context = context;
        }

        // GET: F120Pilotlar
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.F120Pilotlar.Include(f => f.Pilot).Include(f => f.Takim).OrderByDescending(f => f.Puan);;
            return View(await siCoreContext.ToListAsync());
        }

        // GET: F120Pilotlar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f120Pilotlar = await _context.F120Pilotlar
                .Include(f => f.Pilot)
                .Include(f => f.Takim)
                .FirstOrDefaultAsync(m => m.PilotId == id);
            if (f120Pilotlar == null)
            {
                return NotFound();
            }

            return View(f120Pilotlar);
        }

        // GET: F120Pilotlar/Create
        public IActionResult Create()
        {
            ViewData["PilotId"] = new SelectList(_context.F1Pilotlar, "PilotId", "PilotId");
            ViewData["TakimId"] = new SelectList(_context.F1Takimlar, "TakimId", "TakimId");
            return View();
        }

        // POST: F120Pilotlar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,PilotId,Win,PolePosition,Podium,Puan")] F120Pilotlar f120Pilotlar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(f120Pilotlar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PilotId"] = new SelectList(_context.F1Pilotlar, "PilotId", "PilotId", f120Pilotlar.PilotId);
            ViewData["TakimId"] = new SelectList(_context.F1Takimlar, "TakimId", "TakimId", f120Pilotlar.TakimId);
            return View(f120Pilotlar);
        }

        // GET: F120Pilotlar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f120Pilotlar = await _context.F120Pilotlar.FindAsync(id);
            if (f120Pilotlar == null)
            {
                return NotFound();
            }
            ViewData["PilotId"] = new SelectList(_context.F1Pilotlar, "PilotId", "PilotId", f120Pilotlar.PilotId);
            ViewData["TakimId"] = new SelectList(_context.F1Takimlar, "TakimId", "TakimId", f120Pilotlar.TakimId);
            return View(f120Pilotlar);
        }

        // POST: F120Pilotlar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,PilotId,Win,PolePosition,Podium,Puan")] F120Pilotlar f120Pilotlar)
        {
            if (id != f120Pilotlar.PilotId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(f120Pilotlar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!F120PilotlarExists(f120Pilotlar.PilotId))
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
            ViewData["PilotId"] = new SelectList(_context.F1Pilotlar, "PilotId", "PilotId", f120Pilotlar.PilotId);
            ViewData["TakimId"] = new SelectList(_context.F1Takimlar, "TakimId", "TakimId", f120Pilotlar.TakimId);
            return View(f120Pilotlar);
        }

        // GET: F120Pilotlar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f120Pilotlar = await _context.F120Pilotlar
                .Include(f => f.Pilot)
                .Include(f => f.Takim)
                .FirstOrDefaultAsync(m => m.PilotId == id);
            if (f120Pilotlar == null)
            {
                return NotFound();
            }

            return View(f120Pilotlar);
        }

        // POST: F120Pilotlar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var f120Pilotlar = await _context.F120Pilotlar.FindAsync(id);
            _context.F120Pilotlar.Remove(f120Pilotlar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool F120PilotlarExists(int id)
        {
            return _context.F120Pilotlar.Any(e => e.PilotId == id);
        }
    }
}
