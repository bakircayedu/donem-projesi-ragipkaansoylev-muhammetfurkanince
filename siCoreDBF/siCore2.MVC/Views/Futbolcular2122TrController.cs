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
    public class Futbolcular2122TrController : Controller
    {
        private readonly siCoreContext _context;

        public Futbolcular2122TrController(siCoreContext context)
        {
            _context = context;
        }

        // GET: Futbolcular2122Tr
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.Futbolcular2122Tr.Include(f => f.Takim).OrderByDescending(f => f.AtilanGol).Take(5);

            return View(await siCoreContext.ToListAsync());
        }

        public async Task<IActionResult> Index2()
        {
            var siCoreContext = _context.Futbolcular2122Tr.Include(f => f.Takim).OrderByDescending(f => f.YapilanAsist).Take(5);

            return View(await siCoreContext.ToListAsync());
        }
        // GET: Futbolcular2122Tr/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var futbolcular2122Tr = await _context.Futbolcular2122Tr
                .Include(f => f.Takim)
                .FirstOrDefaultAsync(m => m.FutbolcuId == id);
            if (futbolcular2122Tr == null)
            {
                return NotFound();
            }

            return View(futbolcular2122Tr);
        }

        // GET: Futbolcular2122Tr/Create
        public IActionResult Create()
        {
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi");
            return View();
        }

        // POST: Futbolcular2122Tr/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,FutbolcuId,FutbolcuIsim,AtilanGol,YapilanAsist")] Futbolcular2122Tr futbolcular2122Tr)
        {
            if (ModelState.IsValid)
            {
                _context.Add(futbolcular2122Tr);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi", futbolcular2122Tr.TakimId);
            return View(futbolcular2122Tr);
        }

        // GET: Futbolcular2122Tr/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var futbolcular2122Tr = await _context.Futbolcular2122Tr.FindAsync(id);
            if (futbolcular2122Tr == null)
            {
                return NotFound();
            }
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi", futbolcular2122Tr.TakimId);
            return View(futbolcular2122Tr);
        }

        // POST: Futbolcular2122Tr/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,FutbolcuId,FutbolcuIsim,AtilanGol,YapilanAsist")] Futbolcular2122Tr futbolcular2122Tr)
        {
            if (id != futbolcular2122Tr.FutbolcuId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(futbolcular2122Tr);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Futbolcular2122TrExists(futbolcular2122Tr.FutbolcuId))
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
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi", futbolcular2122Tr.TakimId);
            return View(futbolcular2122Tr);
        }

        // GET: Futbolcular2122Tr/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var futbolcular2122Tr = await _context.Futbolcular2122Tr
                .Include(f => f.Takim)
                .FirstOrDefaultAsync(m => m.FutbolcuId == id);
            if (futbolcular2122Tr == null)
            {
                return NotFound();
            }

            return View(futbolcular2122Tr);
        }

        // POST: Futbolcular2122Tr/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var futbolcular2122Tr = await _context.Futbolcular2122Tr.FindAsync(id);
            _context.Futbolcular2122Tr.Remove(futbolcular2122Tr);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Futbolcular2122TrExists(int id)
        {
            return _context.Futbolcular2122Tr.Any(e => e.FutbolcuId == id);
        }
    }
}
