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
    public class BasketbolTakimlarsController : Controller
    {
        private readonly siCoreContext _context;

        public BasketbolTakimlarsController(siCoreContext context)
        {
            _context = context;
        }

        // GET: BasketbolTakimlars
        public async Task<IActionResult> Index()
        {
            return View(await _context.BasketbolTakimlar.ToListAsync());
        }

        // GET: BasketbolTakimlars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbolTakimlar = await _context.BasketbolTakimlar
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (basketbolTakimlar == null)
            {
                return NotFound();
            }

            return View(basketbolTakimlar);
        }

        // GET: BasketbolTakimlars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BasketbolTakimlars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakimId,TakimAdi")] BasketbolTakimlar basketbolTakimlar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(basketbolTakimlar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(basketbolTakimlar);
        }

        // GET: BasketbolTakimlars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbolTakimlar = await _context.BasketbolTakimlar.FindAsync(id);
            if (basketbolTakimlar == null)
            {
                return NotFound();
            }
            return View(basketbolTakimlar);
        }

        // POST: BasketbolTakimlars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakimId,TakimAdi")] BasketbolTakimlar basketbolTakimlar)
        {
            if (id != basketbolTakimlar.TakimId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(basketbolTakimlar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BasketbolTakimlarExists(basketbolTakimlar.TakimId))
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
            return View(basketbolTakimlar);
        }

        // GET: BasketbolTakimlars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketbolTakimlar = await _context.BasketbolTakimlar
                .FirstOrDefaultAsync(m => m.TakimId == id);
            if (basketbolTakimlar == null)
            {
                return NotFound();
            }

            return View(basketbolTakimlar);
        }

        // POST: BasketbolTakimlars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var basketbolTakimlar = await _context.BasketbolTakimlar.FindAsync(id);
            _context.BasketbolTakimlar.Remove(basketbolTakimlar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BasketbolTakimlarExists(int id)
        {
            return _context.BasketbolTakimlar.Any(e => e.TakimId == id);
        }
    }
}
