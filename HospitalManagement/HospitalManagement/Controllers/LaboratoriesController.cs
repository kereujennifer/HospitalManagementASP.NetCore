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
              return _context.Laboratory != null ? 
                          View(await _context.Laboratory.ToListAsync()) :
                          Problem("Entity set 'ApplicationDBContext.Laboratory'  is null.");
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
        public IActionResult Create()
        {
            return View();
        }

        // POST: Laboratories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TestPerformed,TestPerformedBy,Report,Id")] Laboratory laboratory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(laboratory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
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
        public async Task<IActionResult> Edit(int id, [Bind("TestPerformed,TestPerformedBy,Report,Id")] Laboratory laboratory)
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
    }
}
