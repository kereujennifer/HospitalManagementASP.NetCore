using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HospitalManagement.Data;
using HospitalManagement.Models;
using HospitalManagement.ViewModels;
using System.Numerics;

namespace HospitalManagement.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly ApplicationDBContext _context;

        public DoctorsController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: Doctors
        public async Task<IActionResult> Index()
        {
              return _context.Doctors != null ? 
                          View(await _context.Doctors.ToListAsync()) :
                          Problem("Entity set 'ApplicationDBContext.Doctors'  is null.");
        }

        // GET: Doctors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Doctors == null)
            {
                return NotFound();
            }

            var doctors = await _context.Doctors
                .FirstOrDefaultAsync(m => m.DoctorId == id);
            if (doctors == null)
            {
                return NotFound();
            }

            return View(doctors);
        }

        // GET: Doctors/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        // POST: Doctors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        public IActionResult Create()
        {
            var viewModel = new CreateDoctorViewModel();
            viewModel.Department = _context.Department.ToList();
            return View(viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateDoctorViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                viewModel.Department = _context.Department.ToList();
                ViewData["ErrorMessages"] = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();

                return View(viewModel);
            }

            var department = _context.Department.FirstOrDefault(d => d.DepartmentName == viewModel.DepartmentName);
            if (department == null)
            {
                ModelState.AddModelError("Department", "Please select a valid department.");
                viewModel.Department = _context.Department.ToList();
                return View(viewModel);
            }
            var doctor = new Doctors
            {
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                Phone = viewModel.Phone,
                Email = viewModel.Email,
                Address = viewModel.Address,
                Speciality = viewModel.Speciality,
                DepartmentName = viewModel.DepartmentName,
                Department = new List<Department> { department }
            };

            _context.Add(doctor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

 public async Task<IActionResult> Edit(int? id)
{
    if (id == null)
    {
        return NotFound();
    }

    var doctor = await _context.Doctors.Include(d => d.Department).FirstOrDefaultAsync(d => d.DoctorId == id);
    if (doctor == null)
    {
        return NotFound();
    }

    var viewModel = new CreateDoctorViewModel
    {
        DoctorId = doctor.DoctorId,
        FirstName = doctor.FirstName,
        LastName = doctor.LastName,
        Phone = doctor.Phone,
        Email = doctor.Email,
        Address = doctor.Address,
        Speciality = doctor.Speciality,
        DepartmentName = doctor.DepartmentName,
        Department = _context.Department.ToList()
    };

    return View(viewModel);
}

[HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> Edit(int? id, CreateDoctorViewModel viewModel)
{
    if (id != viewModel.DoctorId)
    {
        return NotFound();
    }

    if (!ModelState.IsValid)
    {
                var department = _context.Department.FirstOrDefault(d => d.DepartmentName == viewModel.DepartmentName);

                var doctor = await _context.Doctors.Include(d => d.Department).FirstOrDefaultAsync(d => d.DoctorId == id);
        if (doctor == null)
        {
            return NotFound();
        }

        doctor.FirstName = viewModel.FirstName;
        doctor.LastName = viewModel.LastName;
        doctor.Phone = viewModel.Phone;
        doctor.Email = viewModel.Email;
        doctor.Address = viewModel.Address;
        doctor.Speciality = viewModel.Speciality;
        doctor.DepartmentName = viewModel.DepartmentName;
        doctor.Department = new List<Department> { department };

        // Update the doctor entity and save changes to the database
        _context.Doctors.Update(doctor);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    // If model state is not valid, retrieve the department list and return the view with the updated view model
    viewModel.Department = _context.Department.ToList();
    return View(viewModel);
}



        // GET: Doctors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Doctors == null)
            {
                return NotFound();
            }

            var doctors = await _context.Doctors
                .FirstOrDefaultAsync(m => m.DoctorId == id);
            if (doctors == null)
            {
                return NotFound();
            }

            return View(doctors);
        }

        // POST: Doctors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Doctors == null)
            {
                return Problem("Entity set 'ApplicationDBContext.Doctors'  is null.");
            }
            var doctors = await _context.Doctors.FindAsync(id);
            if (doctors != null)
            {
                _context.Doctors.Remove(doctors);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoctorsExists(int id)
        {
          return (_context.Doctors?.Any(e => e.DoctorId == id)).GetValueOrDefault();
        }
    }
}
