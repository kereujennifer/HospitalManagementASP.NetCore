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
    public class VitalSignsController : Controller
    {
        private readonly ApplicationDBContext _context;

        public VitalSignsController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: VitalSigns
        public async Task<IActionResult> Index()
        {
              return _context.VitalSigns != null ? 
                          View(await _context.VitalSigns.ToListAsync()) :
                          Problem("Entity set 'ApplicationDBContext.VitalSigns'  is null.");
        }

        // GET: VitalSigns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.VitalSigns == null)
            {
                return NotFound();
            }

            var vitalSigns = await _context.VitalSigns
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vitalSigns == null)
            {
                return NotFound();
            }

            return View(vitalSigns);
        }

        // GET: VitalSigns/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VitalSigns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PatientId,Weight,Height,BloodPressure,Temprature,BMI")] VitalSigns vitalSigns)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vitalSigns);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vitalSigns);
        }

        // GET: VitalSigns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.VitalSigns == null)
            {
                return NotFound();
            }

            var vitalSigns = await _context.VitalSigns.FindAsync(id);
            if (vitalSigns == null)
            {
                return NotFound();
            }
            return View(vitalSigns);
        }

        // POST: VitalSigns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PatientId,Weight,Height,BloodPressure,Temprature,BMI")] VitalSigns vitalSigns)
        {
            if (id != vitalSigns.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vitalSigns);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VitalSignsExists(vitalSigns.Id))
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
            return View(vitalSigns);
        }

        // GET: VitalSigns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.VitalSigns == null)
            {
                return NotFound();
            }

            var vitalSigns = await _context.VitalSigns
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vitalSigns == null)
            {
                return NotFound();
            }

            return View(vitalSigns);
        }

        // POST: VitalSigns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.VitalSigns == null)
            {
                return Problem("Entity set 'ApplicationDBContext.VitalSigns'  is null.");
            }
            var vitalSigns = await _context.VitalSigns.FindAsync(id);
            if (vitalSigns != null)
            {
                _context.VitalSigns.Remove(vitalSigns);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VitalSignsExists(int id)
        {
          return (_context.VitalSigns?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
