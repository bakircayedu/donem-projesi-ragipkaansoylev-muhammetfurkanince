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
    public class Futbolcular1920EngController : Controller
    {
        private readonly siCoreContext _context;

        public Futbolcular1920EngController(siCoreContext context)
        {
            _context = context;
        }

        // GET: Futbolcular1920Eng
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.Futbolcular1920Eng.Include(f => f.Takim).OrderByDescending(f=>f.AtilanGol).Take(5);
            return View(await siCoreContext.ToListAsync());
        }
        public async Task<IActionResult> Index2()
        {
            var siCoreContext = _context.Futbolcular1920Eng.Include(f => f.Takim).OrderByDescending(f=>f.YapilanAsist).Take(5);
            return View(await siCoreContext.ToListAsync());
        }


        // GET: Futbolcular1920Eng/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var futbolcular1920Eng = await _context.Futbolcular1920Eng
                .Include(f => f.Takim)
                .FirstOrDefaultAsync(m => m.FutbolcuId == id);
            if (futbolcular1920Eng == null)
            {
                return NotFound();
            }

            return View(futbolcular1920Eng);
        }

        // GET: Futbolcular1920Eng/Create
        public IActionResult Create()
        {
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi");
            return View();
        }

        // POST: Futbolcular1920Eng/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,FutbolcuId,FutbolcuIsim,AtilanGol,YapilanAsist")] Futbolcular1920Eng futbolcular1920Eng)
        {
            if (ModelState.IsValid)
            {
                _context.Add(futbolcular1920Eng);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi", futbolcular1920Eng.TakimId);
            return View(futbolcular1920Eng);
        }

        // GET: Futbolcular1920Eng/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var futbolcular1920Eng = await _context.Futbolcular1920Eng.FindAsync(id);
            if (futbolcular1920Eng == null)
            {
                return NotFound();
            }
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi", futbolcular1920Eng.TakimId);
            return View(futbolcular1920Eng);
        }

        // POST: Futbolcular1920Eng/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,FutbolcuId,FutbolcuIsim,AtilanGol,YapilanAsist")] Futbolcular1920Eng futbolcular1920Eng)
        {
            if (id != futbolcular1920Eng.FutbolcuId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(futbolcular1920Eng);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Futbolcular1920EngExists(futbolcular1920Eng.FutbolcuId))
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
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi", futbolcular1920Eng.TakimId);
            return View(futbolcular1920Eng);
        }

        // GET: Futbolcular1920Eng/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var futbolcular1920Eng = await _context.Futbolcular1920Eng
                .Include(f => f.Takim)
                .FirstOrDefaultAsync(m => m.FutbolcuId == id);
            if (futbolcular1920Eng == null)
            {
                return NotFound();
            }

            return View(futbolcular1920Eng);
        }

        // POST: Futbolcular1920Eng/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var futbolcular1920Eng = await _context.Futbolcular1920Eng.FindAsync(id);
            _context.Futbolcular1920Eng.Remove(futbolcular1920Eng);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Futbolcular1920EngExists(int id)
        {
            return _context.Futbolcular1920Eng.Any(e => e.FutbolcuId == id);
        }
    }
}
