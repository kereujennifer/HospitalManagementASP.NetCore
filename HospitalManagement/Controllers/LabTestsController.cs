using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HospitalManagement.Models;
using HospitalManagement.Data;
using HospitalManagement.Controllers;

namespace HospitalManagement
{
    public class LabTestsController : Controller
    {
        private readonly ApplicationDBContext _context;

        public LabTestsController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: LabTests
        public async Task<IActionResult> Index()
        {
            var labTests = await _context.LabTest.Include(l => l.LabTestCategory).ToListAsync();
            return View(labTests);
        }

        public async Task<IActionResult> Index1()
        {
           
            var labTests = _context.LabTest.Include(l => l.LabTestCategory).ToList();
            return View(labTests);
        }

        // GET: LabTests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.LabTest == null)
            {
                return NotFound();
            }

            var labTest = await _context.LabTest
                .FirstOrDefaultAsync(m => m.Id == id);
            if (labTest == null)
            {
                return NotFound();
            }

            return View(labTest);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["LabTestCategoryID"] = new SelectList(_context.LabTestCategory, "Id", "CategoryName");
            return View();
        }


       

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id, TestName, Description, LabTestCategoryID")] LabTest labTest)
        {
            if (ModelState.IsValid)
            {
                labTest.LabTestCategory = await _context.LabTestCategory.FindAsync(labTest.LabTestCategoryID);

                _context.Add(labTest);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Laboratories");
            }

            ViewData["LabTestCategoryID"] = new SelectList(_context.LabTestCategory, "Id", "CategoryName", labTest.LabTestCategoryID);
            return View(labTest);
        }






        // GET: LabTests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.LabTest == null)
            {
                return NotFound();
            }

            var labTest = await _context.LabTest.FindAsync(id);
            if (labTest == null)
            {
                return NotFound();
            }
            return View(labTest);
        }

        // POST: LabTests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TestName,Description")] LabTest labTest)
        {
            if (id != labTest.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(labTest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LabTestExists(labTest.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", "Laboratories");
            }
            return View(labTest);
        }

        // GET: LabTests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.LabTest == null)
            {
                return NotFound();
            }

            var labTest = await _context.LabTest
                .FirstOrDefaultAsync(m => m.Id == id);
            if (labTest == null)
            {
                return NotFound();
            }

            return View(labTest);
        }

        // POST: LabTests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.LabTest == null)
            {
                return Problem("Entity set 'HospitalManagementFinalContext.LabTest'  is null.");
            }
            var labTest = await _context.LabTest.FindAsync(id);
            if (labTest != null)
            {
                _context.LabTest.Remove(labTest);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Laboratories");
        }

        private bool LabTestExists(int id)
        {
          return (_context.LabTest?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
