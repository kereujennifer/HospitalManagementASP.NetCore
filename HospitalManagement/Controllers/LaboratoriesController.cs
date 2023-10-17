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

namespace HospitalManagement.Controllers
{
    public class LaboratoriesController : Controller
    {
        private readonly ApplicationDBContext _context;

        public LaboratoriesController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: Laboratories
        public async Task<IActionResult> Index()
        {
            var laboratories = _context.Laboratory.ToList();
            var labTests = _context.LabTest.ToList();
            var labTestCategory = _context.LabTestCategory.ToList();
            var labRequests = _context.LabRequests.Include(lr => lr.Patient).ToList();

            var viewModel = new IndexLabViewModel
            {
                Laboratories = laboratories,
                LabRequests = labRequests,
                LabTest = labTests,
                LabTestCategories = labTestCategory
            };
       
            return View(viewModel);
        }


        // GET: Laboratories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Laboratory == null)
            {
                return NotFound();
            }

            var laboratory = await _context.Laboratory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (laboratory == null)
            {
                return NotFound();
            }

            return View(laboratory);
        }

        // GET: Laboratories/Create
        public IActionResult Create(int labRequestId)
        {
            // Find the lab request by Id from the database
            var labRequest = _context.LabRequests.Include(lr => lr.Patient).FirstOrDefault(lr => lr.Id == labRequestId);

            if (labRequest == null)
            {
                return NotFound();
            }

            var laboratory = new Laboratory
            {
                PatientName = labRequest.PatientName,
                Patient = labRequest.Patient,
                LabRequestId = labRequest.Id,
                TestName = labRequest.RequestedTests,
                // You can set other properties here based on the lab request if needed
            };

            return View(laboratory);
        }

        // POST: Laboratories/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Test,TestName,Report,Id,Priority,OrderDate,CollectionDate,SpecimenId,Specimen,CollectionMethod,LabRequestId,Patient.Id,Patient.FirstName,Patient.LastName")] Laboratory laboratory)
        {
            
                // Set the patient information in the laboratory record
                if (ModelState.IsValid)
                {
                // Find the lab request by Id from the database
                var labRequest = _context.LabRequests.Include(lr => lr.Patient).FirstOrDefault(lr => lr.Id == laboratory.LabRequestId);

                if (labRequest != null)
                    {
                    // Set the patient information in the laboratory record
                    laboratory.Patient = labRequest.Patient;
                    laboratory.PatientName = labRequest.Patient.FirstName + " " + labRequest.Patient.LastName;

                        _context.Add(laboratory);
                        await _context.SaveChangesAsync();

                        // Update the lab request status to "Processed"
                        labRequest.Status = "Processed";
                        await _context.SaveChangesAsync();

                        return RedirectToAction(nameof(Index));
                    }
             
            }

            return View(laboratory);
        }


        // GET: Laboratories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Laboratory == null)
            {
                return NotFound();
            }

            var laboratory = await _context.Laboratory.FindAsync(id);
            if (laboratory == null)
            {
                return NotFound();
            }
            return View(laboratory);
        }

        // POST: Laboratories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PatientName,TestPerformedBy,Report,Id")] Laboratory laboratory)
        {
            if (id != laboratory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(laboratory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LaboratoryExists(laboratory.Id))
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
            return View(laboratory);
        }

        // GET: Laboratories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Laboratory == null)
            {
                return NotFound();
            }

            var laboratory = await _context.Laboratory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (laboratory == null)
            {
                return NotFound();
            }

            return View(laboratory);
        }

        // POST: Laboratories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Laboratory == null)
            {
                return Problem("Entity set 'ApplicationDBContext.Laboratory'  is null.");
            }
            var laboratory = await _context.Laboratory.FindAsync(id);
            if (laboratory != null)
            {
                _context.Laboratory.Remove(laboratory);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LaboratoryExists(int id)
        {
          return (_context.Laboratory?.Any(e => e.Id == id)).GetValueOrDefault();
        }
        public IActionResult LaboratoryInterface()
        {
            var labRequests = _context.LabRequests.ToList();
            return View(labRequests);
        }
    }
}
