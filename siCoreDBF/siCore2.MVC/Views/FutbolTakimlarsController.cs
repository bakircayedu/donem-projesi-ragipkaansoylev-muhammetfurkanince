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
    public class FutbolTakimlarsController : Controller
    {
        private readonly siCoreContext _context;

        public FutbolTakimlarsController(siCoreContext context)
        {
            _context = context;
        }

        // GET: FutbolTakimlars
        public async Task<IActionResult> Index()
        {
            return View(await _context.FutbolTakimlar.ToListAsync());
        }

        // GET: FutbolTakimlars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var futbolTakimlar = await _context.FutbolTakimlar
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (futbolTakimlar == null)
            {
                return NotFound();
            }

            return View(futbolTakimlar);
        }

        // GET: FutbolTakimlars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FutbolTakimlars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,TakimAdi")] FutbolTakimlar futbolTakimlar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(futbolTakimlar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(futbolTakimlar);
        }

        // GET: FutbolTakimlars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var futbolTakimlar = await _context.FutbolTakimlar.FindAsync(id);
            if (futbolTakimlar == null)
            {
                return NotFound();
            }
            return View(futbolTakimlar);
        }

        // POST: FutbolTakimlars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,TakimAdi")] FutbolTakimlar futbolTakimlar)
        {
            if (id != futbolTakimlar.TakimId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(futbolTakimlar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FutbolTakimlarExists(futbolTakimlar.TakimId))
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
            return View(futbolTakimlar);
        }

        // GET: FutbolTakimlars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var futbolTakimlar = await _context.FutbolTakimlar
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (futbolTakimlar == null)
            {
                return NotFound();
            }

            return View(futbolTakimlar);
        }

        // POST: FutbolTakimlars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var futbolTakimlar = await _context.FutbolTakimlar.FindAsync(id);
            _context.FutbolTakimlar.Remove(futbolTakimlar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FutbolTakimlarExists(int id)
        {
            return _context.FutbolTakimlar.Any(e => e.TakimId == id);
        }
    }
}
