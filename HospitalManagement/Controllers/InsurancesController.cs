using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HospitalManagement.Data;
using HospitalManagement.Models;

namespace HospitalManagement.Controllers
{
    public class InsurancesController : Controller
    {
        private readonly ApplicationDBContext _context;

        public InsurancesController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: Insurances
        public async Task<IActionResult> Index()
        {
              return _context.Insurance != null ? 
                          View(await _context.Insurance.ToListAsync()) :
                          Problem("Entity set 'ApplicationDBContext.Insurance'  is null.");
        }

        // GET: Insurances/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Insurance == null)
            {
                return NotFound();
            }

            var insurance = await _context.Insurance
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insurance == null)
            {
                return NotFound();
            }

            return View(insurance);
        }

        // GET: Insurances/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Insurances/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PolicyNumber")] Insurance insurance)
        {
            if (ModelState.IsValid)
            {
                _context.Add(insurance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(insurance);
        }

        // GET: Insurances/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Insurance == null)
            {
                return NotFound();
            }

            var insurance = await _context.Insurance.FindAsync(id);
            if (insurance == null)
            {
                return NotFound();
            }
            return View(insurance);
        }

        // POST: Insurances/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PolicyNumber")] Insurance insurance)
        {
            if (id != insurance.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(insurance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsuranceExists(insurance.Id))
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
            return View(insurance);
        }

        // GET: Insurances/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Insurance == null)
            {
                return NotFound();
            }

            var insurance = await _context.Insurance
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insurance == null)
            {
                return NotFound();
            }

            return View(insurance);
        }

        // POST: Insurances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Insurance == null)
            {
                return Problem("Entity set 'ApplicationDBContext.Insurance'  is null.");
            }
            var insurance = await _context.Insurance.FindAsync(id);
            if (insurance != null)
            {
                _context.Insurance.Remove(insurance);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InsuranceExists(int id)
        {
          return (_context.Insurance?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
