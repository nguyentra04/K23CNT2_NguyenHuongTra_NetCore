using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NHTLesson10.Models;

namespace NHTLesson10.Controllers
{
    public class NhtcatesController : Controller
    {
        private readonly Nhtlesson10K23cnt2Context _context;

        public NhtcatesController(Nhtlesson10K23cnt2Context context)
        {
            _context = context;
        }

        // GET: Nhtcates
        public async Task<IActionResult> Index()
        {
            return View(await _context.Nhtcates.ToListAsync());
        }

        // GET: Nhtcates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhtcate = await _context.Nhtcates
                .FirstOrDefaultAsync(m => m.CateId == id);
            if (nhtcate == null)
            {
                return NotFound();
            }

            return View(nhtcate);
        }

        // GET: Nhtcates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Nhtcates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CateId,CateName,CateStatus")] Nhtcate nhtcate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nhtcate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nhtcate);
        }

        // GET: Nhtcates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhtcate = await _context.Nhtcates.FindAsync(id);
            if (nhtcate == null)
            {
                return NotFound();
            }
            return View(nhtcate);
        }

        // POST: Nhtcates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CateId,CateName,CateStatus")] Nhtcate nhtcate)
        {
            if (id != nhtcate.CateId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nhtcate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NhtcateExists(nhtcate.CateId))
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
            return View(nhtcate);
        }

        // GET: Nhtcates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhtcate = await _context.Nhtcates
                .FirstOrDefaultAsync(m => m.CateId == id);
            if (nhtcate == null)
            {
                return NotFound();
            }

            return View(nhtcate);
        }

        // POST: Nhtcates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nhtcate = await _context.Nhtcates.FindAsync(id);
            if (nhtcate != null)
            {
                _context.Nhtcates.Remove(nhtcate);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NhtcateExists(int id)
        {
            return _context.Nhtcates.Any(e => e.CateId == id);
        }
    }
}
