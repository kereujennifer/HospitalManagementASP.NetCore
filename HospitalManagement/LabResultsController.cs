using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HospitalManagement.Data;
using HospitalManagement.Models;

namespace HospitalManagement
{
    public class LabResultsController : Controller
    {
        private readonly ApplicationDBContext _context;

        public LabResultsController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: LabResults
        public async Task<IActionResult> Index()
        {
              return _context.LabResults != null ? 
                          View(await _context.LabResults.ToListAsync()) :
                          Problem("Entity set 'ApplicationDBContext.LabResults'  is null.");
        }

        // GET: LabResults/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.LabResults == null)
            {
                return NotFound();
            }

            var labResults = await _context.LabResults
                .FirstOrDefaultAsync(m => m.Id == id);
            if (labResults == null)
            {
                return NotFound();
            }

            return View(labResults);
        }

        // GET: LabResults/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LabResults/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TestPerformed,TestPerformedBy,Report")] LabResults labResults)
        {
            if (ModelState.IsValid)
            {
                _context.Add(labResults);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(labResults);
        }

        // GET: LabResults/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.LabResults == null)
            {
                return NotFound();
            }

            var labResults = await _context.LabResults.FindAsync(id);
            if (labResults == null)
            {
                return NotFound();
            }
            return View(labResults);
        }

        // POST: LabResults/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TestPerformed,TestPerformedBy,Report")] LabResults labResults)
        {
            if (id != labResults.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(labResults);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LabResultsExists(labResults.Id))
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
            return View(labResults);
        }

        // GET: LabResults/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.LabResults == null)
            {
                return NotFound();
            }

            var labResults = await _context.LabResults
                .FirstOrDefaultAsync(m => m.Id == id);
            if (labResults == null)
            {
                return NotFound();
            }

            return View(labResults);
        }

        // POST: LabResults/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.LabResults == null)
            {
                return Problem("Entity set 'ApplicationDBContext.LabResults'  is null.");
            }
            var labResults = await _context.LabResults.FindAsync(id);
            if (labResults != null)
            {
                _context.LabResults.Remove(labResults);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LabResultsExists(int id)
        {
          return (_context.LabResults?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
