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
    public class Futbolcular1920ItaController : Controller
    {
        private readonly siCoreContext _context;

        public Futbolcular1920ItaController(siCoreContext context)
        {
            _context = context;
        }

        // GET: Futbolcular1920Ita
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.Futbolcular1920Ita.Include(f => f.Takim).OrderByDescending(f=> f.AtilanGol).Take(5);
            return View(await siCoreContext.ToListAsync());
        }

        public async Task<IActionResult> Indexv2()
        {
            var siCoreContext = _context.Futbolcular1920Ita.Include(f => f.Takim).OrderByDescending(f => f.YapilanAsist).Take(5);
            return View(await siCoreContext.ToListAsync());
        }

        // GET: Futbolcular1920Ita/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var futbolcular1920Ita = await _context.Futbolcular1920Ita
                .Include(f => f.Takim)
                .FirstOrDefaultAsync(m => m.FutbolcuId == id);
            if (futbolcular1920Ita == null)
            {
                return NotFound();
            }

            return View(futbolcular1920Ita);
        }

        // GET: Futbolcular1920Ita/Create
        public IActionResult Create()
        {
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi");
            return View();
        }

        // POST: Futbolcular1920Ita/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,FutbolcuId,FutbolcuIsim,AtilanGol,YapilanAsist")] Futbolcular1920Ita futbolcular1920Ita)
        {
            if (ModelState.IsValid)
            {
                _context.Add(futbolcular1920Ita);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi", futbolcular1920Ita.TakimId);
            return View(futbolcular1920Ita);
        }

        // GET: Futbolcular1920Ita/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var futbolcular1920Ita = await _context.Futbolcular1920Ita.FindAsync(id);
            if (futbolcular1920Ita == null)
            {
                return NotFound();
            }
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi", futbolcular1920Ita.TakimId);
            return View(futbolcular1920Ita);
        }

        // POST: Futbolcular1920Ita/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,FutbolcuId,FutbolcuIsim,AtilanGol,YapilanAsist")] Futbolcular1920Ita futbolcular1920Ita)
        {
            if (id != futbolcular1920Ita.FutbolcuId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(futbolcular1920Ita);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Futbolcular1920ItaExists(futbolcular1920Ita.FutbolcuId))
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
            ViewData["TakimId"] = new SelectList(_context.FutbolTakimlar, "TakimId", "TakimAdi", futbolcular1920Ita.TakimId);
            return View(futbolcular1920Ita);
        }

        // GET: Futbolcular1920Ita/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var futbolcular1920Ita = await _context.Futbolcular1920Ita
                .Include(f => f.Takim)
                .FirstOrDefaultAsync(m => m.FutbolcuId == id);
            if (futbolcular1920Ita == null)
            {
                return NotFound();
            }

            return View(futbolcular1920Ita);
        }

        // POST: Futbolcular1920Ita/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var futbolcular1920Ita = await _context.Futbolcular1920Ita.FindAsync(id);
            _context.Futbolcular1920Ita.Remove(futbolcular1920Ita);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Futbolcular1920ItaExists(int id)
        {
            return _context.Futbolcular1920Ita.Any(e => e.FutbolcuId == id);
        }
    }
}
