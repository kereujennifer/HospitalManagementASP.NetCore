using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SalesCRMApp.Data;
using SalesCRMApp.Models;

namespace SalesCRMApp.Controllers
{
    public class SalesLeadController : Controller
    {
        private readonly ApplicationDBContext _context;

        public SalesLeadController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: SalesLead
        public async Task<IActionResult> Index()
        {
              return _context.SalesLead != null ? 
                          View(await _context.SalesLead.ToListAsync()) :
                          Problem("Entity set 'ApplicationDBContext.SalesLead'  is null.");
        }

        // GET: SalesLead/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SalesLead == null)
            {
                return NotFound();
            }

            var salesLeadEntity = await _context.SalesLead
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salesLeadEntity == null)
            {
                return NotFound();
            }

            return View(salesLeadEntity);
        }

        // GET: SalesLead/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SalesLead/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Mobile,Email,Source")] SalesLeadEntity salesLeadEntity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(salesLeadEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(salesLeadEntity);
        }

        // GET: SalesLead/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SalesLead == null)
            {
                return NotFound();
            }

            var salesLeadEntity = await _context.SalesLead.FindAsync(id);
            if (salesLeadEntity == null)
            {
                return NotFound();
            }
            return View(salesLeadEntity);
        }

        // POST: SalesLead/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Mobile,Email,Source")] SalesLeadEntity salesLeadEntity)
        {
            if (id != salesLeadEntity.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(salesLeadEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SalesLeadEntityExists(salesLeadEntity.Id))
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
            return View(salesLeadEntity);
        }

        // GET: SalesLead/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SalesLead == null)
            {
                return NotFound();
            }

            var salesLeadEntity = await _context.SalesLead
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salesLeadEntity == null)
            {
                return NotFound();
            }

            return View(salesLeadEntity);
        }

        // POST: SalesLead/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SalesLead == null)
            {
                return Problem("Entity set 'ApplicationDBContext.SalesLead'  is null.");
            }
            var salesLeadEntity = await _context.SalesLead.FindAsync(id);
            if (salesLeadEntity != null)
            {
                _context.SalesLead.Remove(salesLeadEntity);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SalesLeadEntityExists(int id)
        {
          return (_context.SalesLead?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
