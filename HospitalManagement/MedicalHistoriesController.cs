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
    public class MedicalHistoriesController : Controller
    {
        private readonly ApplicationDBContext _context;

        public MedicalHistoriesController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: MedicalHistories
        public async Task<IActionResult> Index()
        {

              return _context.MedicalHistory != null ? 
                          View(await _context.MedicalHistory.ToListAsync()) :
                          Problem("Entity set 'ApplicationDBContext.MedicalHistory'  is null.");
        }

        // GET: MedicalHistories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MedicalHistory == null)
            {
                return NotFound();
            }

            var medicalHistory = await _context.MedicalHistory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (medicalHistory == null)
            {
                return NotFound();
            }

            return View(medicalHistory);
        }

        // GET: MedicalHistories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MedicalHistories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Medications,Allergies,MedicalCondition")] MedicalHistory medicalHistory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medicalHistory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(medicalHistory);
        }

        // GET: MedicalHistories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MedicalHistory == null)
            {
                return NotFound();
            }

            var medicalHistory = await _context.MedicalHistory.FindAsync(id);
            if (medicalHistory == null)
            {
                return NotFound();
            }
            return View(medicalHistory);
        }

        // POST: MedicalHistories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Medications,Allergies,MedicalCondition")] MedicalHistory medicalHistory)
        {
            if (id != medicalHistory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medicalHistory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicalHistoryExists(medicalHistory.Id))
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
            return View(medicalHistory);
        }

        // GET: MedicalHistories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MedicalHistory == null)
            {
                return NotFound();
            }

            var medicalHistory = await _context.MedicalHistory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (medicalHistory == null)
            {
                return NotFound();
            }

            return View(medicalHistory);
        }

        // POST: MedicalHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MedicalHistory == null)
            {
                return Problem("Entity set 'ApplicationDBContext.MedicalHistory'  is null.");
            }
            var medicalHistory = await _context.MedicalHistory.FindAsync(id);
            if (medicalHistory != null)
            {
                _context.MedicalHistory.Remove(medicalHistory);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicalHistoryExists(int id)
        {
          return (_context.MedicalHistory?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
