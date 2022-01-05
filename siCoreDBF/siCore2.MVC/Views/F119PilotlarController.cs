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
    public class F119PilotlarController : Controller
    {
        private readonly siCoreContext _context;

        public F119PilotlarController(siCoreContext context)
        {
            _context = context;
        }

        // GET: F119Pilotlar
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.F119Pilotlar.Include(f => f.Pilot).Include(f => f.Takim).OrderByDescending(f => f.Puan);
            return View(await siCoreContext.ToListAsync());
        }

        // GET: F119Pilotlar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f119Pilotlar = await _context.F119Pilotlar
                .Include(f => f.Pilot)
                .Include(f => f.Takim)
                .FirstOrDefaultAsync(m => m.PilotId == id);
            if (f119Pilotlar == null)
            {
                return NotFound();
            }

            return View(f119Pilotlar);
        }

        // GET: F119Pilotlar/Create
        public IActionResult Create()
        {
            ViewData["PilotId"] = new SelectList(_context.F1Pilotlar, "PilotId", "PilotId");
            ViewData["TakimId"] = new SelectList(_context.F1Takimlar, "TakimId", "TakimId");
            return View();
        }

        // POST: F119Pilotlar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,PilotId,Win,PolePosition,Podium,Puan")] F119Pilotlar f119Pilotlar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(f119Pilotlar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PilotId"] = new SelectList(_context.F1Pilotlar, "PilotId", "PilotId", f119Pilotlar.PilotId);
            ViewData["TakimId"] = new SelectList(_context.F1Takimlar, "TakimId", "TakimId", f119Pilotlar.TakimId);
            return View(f119Pilotlar);
        }

        // GET: F119Pilotlar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f119Pilotlar = await _context.F119Pilotlar.FindAsync(id);
            if (f119Pilotlar == null)
            {
                return NotFound();
            }
            ViewData["PilotId"] = new SelectList(_context.F1Pilotlar, "PilotId", "PilotId", f119Pilotlar.PilotId);
            ViewData["TakimId"] = new SelectList(_context.F1Takimlar, "TakimId", "TakimId", f119Pilotlar.TakimId);
            return View(f119Pilotlar);
        }

        // POST: F119Pilotlar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,PilotId,Win,PolePosition,Podium,Puan")] F119Pilotlar f119Pilotlar)
        {
            if (id != f119Pilotlar.PilotId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(f119Pilotlar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!F119PilotlarExists(f119Pilotlar.PilotId))
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
            ViewData["PilotId"] = new SelectList(_context.F1Pilotlar, "PilotId", "PilotId", f119Pilotlar.PilotId);
            ViewData["TakimId"] = new SelectList(_context.F1Takimlar, "TakimId", "TakimId", f119Pilotlar.TakimId);
            return View(f119Pilotlar);
        }

        // GET: F119Pilotlar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var f119Pilotlar = await _context.F119Pilotlar
                .Include(f => f.Pilot)
                .Include(f => f.Takim)
                .FirstOrDefaultAsync(m => m.PilotId == id);
            if (f119Pilotlar == null)
            {
                return NotFound();
            }

            return View(f119Pilotlar);
        }

        // POST: F119Pilotlar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var f119Pilotlar = await _context.F119Pilotlar.FindAsync(id);
            _context.F119Pilotlar.Remove(f119Pilotlar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool F119PilotlarExists(int id)
        {
            return _context.F119Pilotlar.Any(e => e.PilotId == id);
        }
    }
}
