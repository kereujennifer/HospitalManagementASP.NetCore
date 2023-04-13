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
    public class PatientReportsController : Controller
    {
        private readonly ApplicationDBContext _context;

        public PatientReportsController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: PatientReports
        public async Task<IActionResult> Index()
        {
              return _context.PatientReports != null ? 
                          View(await _context.PatientReports.ToListAsync()) :
                          Problem("Entity set 'ApplicationDBContext.PatientReports'  is null.");
        }

        // GET: PatientReports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PatientReports == null)
            {
                return NotFound();
            }

            var patientReport = await _context.PatientReports
                .FirstOrDefaultAsync(m => m.Id == id);
            if (patientReport == null)
            {
                return NotFound();
            }

            return View(patientReport);
        }

        // GET: PatientReports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PatientReports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Diagnose,MedicineName")] PatientReport patientReport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(patientReport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(patientReport);
        }

        // GET: PatientReports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PatientReports == null)
            {
                return NotFound();
            }

            var patientReport = await _context.PatientReports.FindAsync(id);
            if (patientReport == null)
            {
                return NotFound();
            }
            return View(patientReport);
        }

        // POST: PatientReports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Diagnose,MedicineName")] PatientReport patientReport)
        {
            if (id != patientReport.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(patientReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PatientReportExists(patientReport.Id))
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
            return View(patientReport);
        }

        // GET: PatientReports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PatientReports == null)
            {
                return NotFound();
            }

            var patientReport = await _context.PatientReports
                .FirstOrDefaultAsync(m => m.Id == id);
            if (patientReport == null)
            {
                return NotFound();
            }

            return View(patientReport);
        }

        // POST: PatientReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PatientReports == null)
            {
                return Problem("Entity set 'ApplicationDBContext.PatientReports'  is null.");
            }
            var patientReport = await _context.PatientReports.FindAsync(id);
            if (patientReport != null)
            {
                _context.PatientReports.Remove(patientReport);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PatientReportExists(int id)
        {
          return (_context.PatientReports?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
