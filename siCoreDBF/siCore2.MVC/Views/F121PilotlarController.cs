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
    public class F121PilotlarController : Controller
    {
        private readonly siCoreContext _context;

        public F121PilotlarController(siCoreContext context)
        {
            _context = context;
        }

        // GET: F121Pilotlar
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.F121Pilotlar.Include(f => f.Pilot).Include(f => f.Takim).OrderByDescending(f => f.Puan);
            return View(await siCoreContext.ToListAsync());
        }

        // GET: F121Pilotlar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f121Pilotlar = await _context.F121Pilotlar
                .Include(f => f.Pilot)
                .Include(f => f.Takim)
                .FirstOrDefaultAsync(m => m.PilotId == id);
            if (f121Pilotlar == null)
            {
                return NotFound();
            }

            return View(f121Pilotlar);
        }

        // GET: F121Pilotlar/Create
        public IActionResult Create()
        {
            ViewData["PilotId"] = new SelectList(_context.F1Pilotlar, "PilotId", "PilotId");
            ViewData["TakimId"] = new SelectList(_context.F1Takimlar, "TakimId", "TakimId");
            return View();
        }

        // POST: F121Pilotlar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,PilotId,Win,PolePosition,Podium,Puan")] F121Pilotlar f121Pilotlar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(f121Pilotlar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PilotId"] = new SelectList(_context.F1Pilotlar, "PilotId", "PilotId", f121Pilotlar.PilotId);
            ViewData["TakimId"] = new SelectList(_context.F1Takimlar, "TakimId", "TakimId", f121Pilotlar.TakimId);
            return View(f121Pilotlar);
        }

        // GET: F121Pilotlar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f121Pilotlar = await _context.F121Pilotlar.FindAsync(id);
            if (f121Pilotlar == null)
            {
                return NotFound();
            }
            ViewData["PilotId"] = new SelectList(_context.F1Pilotlar, "PilotId", "PilotId", f121Pilotlar.PilotId);
            ViewData["TakimId"] = new SelectList(_context.F1Takimlar, "TakimId", "TakimId", f121Pilotlar.TakimId);
            return View(f121Pilotlar);
        }

        // POST: F121Pilotlar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,PilotId,Win,PolePosition,Podium,Puan")] F121Pilotlar f121Pilotlar)
        {
            if (id != f121Pilotlar.PilotId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(f121Pilotlar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!F121PilotlarExists(f121Pilotlar.PilotId))
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
            ViewData["PilotId"] = new SelectList(_context.F1Pilotlar, "PilotId", "PilotId", f121Pilotlar.PilotId);
            ViewData["TakimId"] = new SelectList(_context.F1Takimlar, "TakimId", "TakimId", f121Pilotlar.TakimId);
            return View(f121Pilotlar);
        }

        // GET: F121Pilotlar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f121Pilotlar = await _context.F121Pilotlar
                .Include(f => f.Pilot)
                .Include(f => f.Takim)
                .FirstOrDefaultAsync(m => m.PilotId == id);
            if (f121Pilotlar == null)
            {
                return NotFound();
            }

            return View(f121Pilotlar);
        }

        // POST: F121Pilotlar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var f121Pilotlar = await _context.F121Pilotlar.FindAsync(id);
            _context.F121Pilotlar.Remove(f121Pilotlar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool F121PilotlarExists(int id)
        {
            return _context.F121Pilotlar.Any(e => e.PilotId == id);
        }
    }
}
