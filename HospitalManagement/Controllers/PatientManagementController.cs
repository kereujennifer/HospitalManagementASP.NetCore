using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HospitalManagement.Data;
using HospitalManagement.ViewModels;

namespace HospitalManagement.Controllers
{
    public class PatientManagementController : Controller
    {
        private readonly HospitalDBContext _context;

        public PatientManagementController(HospitalDBContext context)
        {
            _context = context;
        }

        // GET: PatientManagement
        public async Task<IActionResult> Index()
        {
              return _context.Hospital != null ? 
                          View(await _context.Hospital.ToListAsync()) :
                          Problem("Entity set 'HospitalDBContext.Hospital'  is null.");
        }

        // GET: PatientManagement/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Hospital == null)
            {
                return NotFound();
            }

            var hospitalMngnt = await _context.Hospital
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hospitalMngnt == null)
            {
                return NotFound();
            }

            return View(hospitalMngnt);
        }

        // GET: PatientManagement/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PatientManagement/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Gender,Age,Mobile,Email,Address,Allergies,CurrentMedication")] PatientViewModel hospitalMngnt)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hospitalMngnt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hospitalMngnt);
        }

        // GET: PatientManagement/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Hospital == null)
            {
                return NotFound();
            }

            var hospitalMngnt = await _context.Hospital.FindAsync(id);
            if (hospitalMngnt == null)
            {
                return NotFound();
            }
            return View(hospitalMngnt);
        }

        // POST: PatientManagement/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Gender,Age,Mobile,Email,Address,Allergies,CurrentMedication")] PatientViewModel hospitalMngnt)
        {
            if (id != hospitalMngnt.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hospitalMngnt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HospitalMngntExists(hospitalMngnt.Id))
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
            return View(hospitalMngnt);
        }

        // GET: PatientManagement/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Hospital == null)
            {
                return NotFound();
            }

            var hospitalMngnt = await _context.Hospital
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hospitalMngnt == null)
            {
                return NotFound();
            }

            return View(hospitalMngnt);
        }

        // POST: PatientManagement/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Hospital == null)
            {
                return Problem("Entity set 'HospitalDBContext.Hospital'  is null.");
            }
            var hospitalMngnt = await _context.Hospital.FindAsync(id);
            if (hospitalMngnt != null)
            {
                _context.Hospital.Remove(hospitalMngnt);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HospitalMngntExists(int id)
        {
          return (_context.Hospital?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
