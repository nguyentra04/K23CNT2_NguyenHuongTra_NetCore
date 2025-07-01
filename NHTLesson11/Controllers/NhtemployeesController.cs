using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NHTLesson11.Models;

namespace NHTLesson11.Controllers
{
    public class NhtemployeesController : Controller
    {
        private readonly NguyenHuongTra2310900106Context _context;

        public NhtemployeesController(NguyenHuongTra2310900106Context context)
        {
            _context = context;
        }

        // GET: Nhtemployees
        public async Task<IActionResult> NHTIndex()
        {
            return View(await _context.Nhtemployees.ToListAsync());
        }

        // GET: Nhtemployees/Details/5
        public async Task<IActionResult> NHTDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhtemployee = await _context.Nhtemployees
                .FirstOrDefaultAsync(m => m.NhtempId == id);
            if (nhtemployee == null)
            {
                return NotFound();
            }

            return View(nhtemployee);
        }

        // GET: Nhtemployees/Create
        public IActionResult NHTCreate()
        {
            return View();
        }

        // POST: Nhtemployees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NHTCreate([Bind("NhtempId,NhtempName,NhtempLevel,NhtempStartDate,NhtempStatus")] Nhtemployee nhtemployee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nhtemployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(NHTIndex));
            }
            return View(nhtemployee);
        }

        // GET: Nhtemployees/Edit/5
        public async Task<IActionResult> NHTEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhtemployee = await _context.Nhtemployees.FindAsync(id);
            if (nhtemployee == null)
            {
                return NotFound();
            }
            return View(nhtemployee);
        }

        // POST: Nhtemployees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NHTEdit(int id, [Bind("NhtempId,NhtempName,NhtempLevel,NhtempStartDate,NhtempStatus")] Nhtemployee nhtemployee)
        {
            if (id != nhtemployee.NhtempId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nhtemployee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NhtemployeeExists(nhtemployee.NhtempId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(NHTIndex));
            }
            return View(nhtemployee);
        }

        // GET: Nhtemployees/Delete/5
        public async Task<IActionResult> NHTDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhtemployee = await _context.Nhtemployees
                .FirstOrDefaultAsync(m => m.NhtempId == id);
            if (nhtemployee == null)
            {
                return NotFound();
            }

            return View(nhtemployee);
        }

        // POST: Nhtemployees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NHTDeleteConfirmed(int id)
        {
            var nhtemployee = await _context.Nhtemployees.FindAsync(id);
            if (nhtemployee != null)
            {
                _context.Nhtemployees.Remove(nhtemployee);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(NHTIndex));
        }

        private bool NhtemployeeExists(int id)
        {
            return _context.Nhtemployees.Any(e => e.NhtempId == id);
        }
    }
}
