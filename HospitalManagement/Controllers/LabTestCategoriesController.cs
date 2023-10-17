using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HospitalManagement.Models;
using HospitalManagement.Data;

namespace HospitalManagementFinal
{
    public class LabTestCategoriesController : Controller
    {
        private readonly ApplicationDBContext _context;

        public LabTestCategoriesController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: LabTestCategories
        public async Task<IActionResult> Index()
        {
            var labTestCategories = _context.LabTestCategory.ToList();
            return View(labTestCategories);
        }

        // GET: LabTestCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.LabTestCategory == null)
            {
                return NotFound();
            }

            var labTestCategory = await _context.LabTestCategory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (labTestCategory == null)
            {
                return NotFound();
            }

            return View(labTestCategory);
        }

        // GET: LabTestCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LabTestCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CategoryName")] LabTestCategory labTestCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(labTestCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Laboratories");
            }
            return View(labTestCategory);
        }

        // GET: LabTestCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.LabTestCategory == null)
            {
                return NotFound();
            }

            var labTestCategory = await _context.LabTestCategory.FindAsync(id);
            if (labTestCategory == null)
            {
                return NotFound();
            }
            return View(labTestCategory);
        }

        // POST: LabTestCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CategoryName")] LabTestCategory labTestCategory)
        {
            if (id != labTestCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(labTestCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LabTestCategoryExists(labTestCategory.Id))
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
            return View(labTestCategory);
        }

        // GET: LabTestCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.LabTestCategory == null)
            {
                return NotFound();
            }

            var labTestCategory = await _context.LabTestCategory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (labTestCategory == null)
            {
                return NotFound();
            }

            return View(labTestCategory);
        }

        // POST: LabTestCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.LabTestCategory == null)
            {
                return Problem("Entity set 'HospitalManagementFinalContext.LabTestCategory'  is null.");
            }
            var labTestCategory = await _context.LabTestCategory.FindAsync(id);
            if (labTestCategory != null)
            {
                _context.LabTestCategory.Remove(labTestCategory);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Laboratories");
        }

        private bool LabTestCategoryExists(int id)
        {
          return (_context.LabTestCategory?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
