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
    public class DoctorManagementController : Controller
    {
        private readonly HospitalDBContext _context;

        public DoctorManagementController(HospitalDBContext context)
        {
            _context = context;
        }

        // GET: DoctorManagement
        public async Task<IActionResult> Index()
        {
              return _context.DoctorViewModel != null ? 
                          View(await _context.DoctorViewModel.ToListAsync()) :
                          Problem("Entity set 'HospitalDBContext.DoctorViewModel'  is null.");
        }

        // GET: DoctorManagement/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DoctorViewModel == null)
            {
                return NotFound();
            }

            var doctorViewModel = await _context.DoctorViewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doctorViewModel == null)
            {
                return NotFound();
            }

            return View(doctorViewModel);
        }

        // GET: DoctorManagement/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DoctorManagement/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Speciality,Email,Address,Phone")] DoctorViewModel doctorViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doctorViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(doctorViewModel);
        }

        // GET: DoctorManagement/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DoctorViewModel == null)
            {
                return NotFound();
            }

            var doctorViewModel = await _context.DoctorViewModel.FindAsync(id);
            if (doctorViewModel == null)
            {
                return NotFound();
            }
            return View(doctorViewModel);
        }

        // POST: DoctorManagement/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Speciality,Email,Address,Phone")] DoctorViewModel doctorViewModel)
        {
            if (id != doctorViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doctorViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoctorViewModelExists(doctorViewModel.Id))
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
            return View(doctorViewModel);
        }

        // GET: DoctorManagement/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DoctorViewModel == null)
            {
                return NotFound();
            }

            var doctorViewModel = await _context.DoctorViewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doctorViewModel == null)
            {
                return NotFound();
            }

            return View(doctorViewModel);
        }

        // POST: DoctorManagement/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DoctorViewModel == null)
            {
                return Problem("Entity set 'HospitalDBContext.DoctorViewModel'  is null.");
            }
            var doctorViewModel = await _context.DoctorViewModel.FindAsync(id);
            if (doctorViewModel != null)
            {
                _context.DoctorViewModel.Remove(doctorViewModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoctorViewModelExists(int id)
        {
          return (_context.DoctorViewModel?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
