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
    public class Basketbolcular2021TrController : Controller
    {
        private readonly siCoreContext _context;

        public Basketbolcular2021TrController(siCoreContext context)
        {
            _context = context;
        }

        // GET: Basketbolcular2021Tr
        public async Task<IActionResult> Index()
        {
            var siCoreContext = _context.Basketbolcular2021Tr.Include(b => b.Takim).OrderByDescending(b => b.AtilanBasketOrtalamasi).Take(5);;
            return View(await siCoreContext.ToListAsync());
        }


           public async Task<IActionResult> Index2()
        {
            var siCoreContext = _context.Basketbolcular2021Tr.Include(b => b.Takim).OrderByDescending(b => b.YapilanAsistOrtalamasi).Take(5);
            return View(await siCoreContext.ToListAsync());
        }
        // GET: Basketbolcular2021Tr/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbolcular2021Tr = await _context.Basketbolcular2021Tr
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.FutbolcuId == id);
            if (basketbolcular2021Tr == null)
            {
                return NotFound();
            }

            return View(basketbolcular2021Tr);
        }

        // GET: Basketbolcular2021Tr/Create
        public IActionResult Create()
        {
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId");
            return View();
        }

        // POST: Basketbolcular2021Tr/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,FutbolcuId,FutbolcuIsim,AtilanBasketOrtalamasi,YapilanAsistOrtalamasi")] Basketbolcular2021Tr basketbolcular2021Tr)
        {
            if (ModelState.IsValid)
            {
                _context.Add(basketbolcular2021Tr);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbolcular2021Tr.TakimId);
            return View(basketbolcular2021Tr);
        }

        // GET: Basketbolcular2021Tr/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbolcular2021Tr = await _context.Basketbolcular2021Tr.FindAsync(id);
            if (basketbolcular2021Tr == null)
            {
                return NotFound();
            }
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbolcular2021Tr.TakimId);
            return View(basketbolcular2021Tr);
        }

        // POST: Basketbolcular2021Tr/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,FutbolcuId,FutbolcuIsim,AtilanBasketOrtalamasi,YapilanAsistOrtalamasi")] Basketbolcular2021Tr basketbolcular2021Tr)
        {
            if (id != basketbolcular2021Tr.FutbolcuId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(basketbolcular2021Tr);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Basketbolcular2021TrExists(basketbolcular2021Tr.FutbolcuId))
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
            ViewData["TakimId"] = new SelectList(_context.BasketbolTakimlar, "TakimId", "TakimId", basketbolcular2021Tr.TakimId);
            return View(basketbolcular2021Tr);
        }

        // GET: Basketbolcular2021Tr/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbolcular2021Tr = await _context.Basketbolcular2021Tr
                .Include(b => b.Takim)
                .FirstOrDefaultAsync(m => m.FutbolcuId == id);
            if (basketbolcular2021Tr == null)
            {
                return NotFound();
            }

            return View(basketbolcular2021Tr);
        }

        // POST: Basketbolcular2021Tr/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var basketbolcular2021Tr = await _context.Basketbolcular2021Tr.FindAsync(id);
            _context.Basketbolcular2021Tr.Remove(basketbolcular2021Tr);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Basketbolcular2021TrExists(int id)
        {
            return _context.Basketbolcular2021Tr.Any(e => e.FutbolcuId == id);
        }
    }
}
