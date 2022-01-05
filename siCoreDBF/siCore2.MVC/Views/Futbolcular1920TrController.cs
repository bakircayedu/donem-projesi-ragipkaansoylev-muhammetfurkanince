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
    public class Futbolcular1920TrController : Controller
    {
        private readonly siCoreContext _context;

        public Futbolcular1920TrController(siCoreContext context)
        {
            _context = context;
        }

        // GET: Futbolcular1920Tr
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.Futbolcular1920Tr.Include(f => f.Takim).OrderByDescending(f=>f.AtilanGol).Take(5);
            
            return View(await siCoreContext.ToListAsync());
        }

        public async Task<IActionResult> Index2()
        {
            var siCoreContext = _context.Futbolcular1920Tr.Include(f => f.Takim).OrderByDescending(f => f.YapilanAsist).Take(5);

            return View(await siCoreContext.ToListAsync());
        }


        // GET: Futbolcular1920Tr/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var futbolcular1920Tr = await _context.Futbolcular1920Tr
                .Include(f => f.Takim)
                .FirstOrDefaultAsync(m => m.FutbolcuId == id);
            if (futbolcular1920Tr == null)
            {
                return NotFound();
            }

            return View(futbolcular1920Tr);
        }

        // GET: Futbolcular1920Tr/Create
        public IActionResult Create()
        {
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi");
            return View();
        }

        // POST: Futbolcular1920Tr/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,FutbolcuId,FutbolcuIsim,AtilanGol,YapilanAsist")] Futbolcular1920Tr futbolcular1920Tr)
        {
            if (ModelState.IsValid)
            {
                _context.Add(futbolcular1920Tr);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi", futbolcular1920Tr.TakimId);
            return View(futbolcular1920Tr);
        }

        // GET: Futbolcular1920Tr/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var futbolcular1920Tr = await _context.Futbolcular1920Tr.FindAsync(id);
            if (futbolcular1920Tr == null)
            {
                return NotFound();
            }
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi", futbolcular1920Tr.TakimId);
            return View(futbolcular1920Tr);
        }

        // POST: Futbolcular1920Tr/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,FutbolcuId,FutbolcuIsim,AtilanGol,YapilanAsist")] Futbolcular1920Tr futbolcular1920Tr)
        {
            if (id != futbolcular1920Tr.FutbolcuId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(futbolcular1920Tr);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Futbolcular1920TrExists(futbolcular1920Tr.FutbolcuId))
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
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi", futbolcular1920Tr.TakimId);
            return View(futbolcular1920Tr);
        }

        // GET: Futbolcular1920Tr/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var futbolcular1920Tr = await _context.Futbolcular1920Tr
                .Include(f => f.Takim)
                .FirstOrDefaultAsync(m => m.FutbolcuId == id);
            if (futbolcular1920Tr == null)
            {
                return NotFound();
            }

            return View(futbolcular1920Tr);
        }

        // POST: Futbolcular1920Tr/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var futbolcular1920Tr = await _context.Futbolcular1920Tr.FindAsync(id);
            _context.Futbolcular1920Tr.Remove(futbolcular1920Tr);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Futbolcular1920TrExists(int id)
        {
            return _context.Futbolcular1920Tr.Any(e => e.FutbolcuId == id);
        }
    }
}
