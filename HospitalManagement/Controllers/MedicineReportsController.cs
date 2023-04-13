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
    public class MedicineReportsController : Controller
    {
        private readonly ApplicationDBContext _context;

        public MedicineReportsController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: MedicineReports
        public async Task<IActionResult> Index()
        {
              return _context.MedicineReports != null ? 
                          View(await _context.MedicineReports.ToListAsync()) :
                          Problem("Entity set 'ApplicationDBContext.MedicineReports'  is null.");
        }

        // GET: MedicineReports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MedicineReports == null)
            {
                return NotFound();
            }

            var medicineReport = await _context.MedicineReports
                .FirstOrDefaultAsync(m => m.Id == id);
            if (medicineReport == null)
            {
                return NotFound();
            }

            return View(medicineReport);
        }

        // GET: MedicineReports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MedicineReports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Company,Quantity,Description")] MedicineReport medicineReport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medicineReport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(medicineReport);
        }

        // GET: MedicineReports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MedicineReports == null)
            {
                return NotFound();
            }

            var medicineReport = await _context.MedicineReports.FindAsync(id);
            if (medicineReport == null)
            {
                return NotFound();
            }
            return View(medicineReport);
        }

        // POST: MedicineReports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Company,Quantity,Description")] MedicineReport medicineReport)
        {
            if (id != medicineReport.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medicineReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicineReportExists(medicineReport.Id))
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
            return View(medicineReport);
        }

        // GET: MedicineReports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MedicineReports == null)
            {
                return NotFound();
            }

            var medicineReport = await _context.MedicineReports
                .FirstOrDefaultAsync(m => m.Id == id);
            if (medicineReport == null)
            {
                return NotFound();
            }

            return View(medicineReport);
        }

        // POST: MedicineReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MedicineReports == null)
            {
                return Problem("Entity set 'ApplicationDBContext.MedicineReports'  is null.");
            }
            var medicineReport = await _context.MedicineReports.FindAsync(id);
            if (medicineReport != null)
            {
                _context.MedicineReports.Remove(medicineReport);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicineReportExists(int id)
        {
          return (_context.MedicineReports?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
