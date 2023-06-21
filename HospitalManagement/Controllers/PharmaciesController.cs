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
    public class PharmaciesController : Controller
    {
        private readonly ApplicationDBContext _context;

        public PharmaciesController(ApplicationDBContext context)
        {
            _context = context;
        }
        public void UpdateStockLevel(string medicineName, int quantity)
        {
            var pharmacy = _context.Pharmacy.FirstOrDefault(p => p.MedicineName == medicineName);
            if (pharmacy != null)
            {
                pharmacy.Stock += quantity;
                _context.SaveChanges();
            }
        }
        public List<Pharmacy> GetOutOfStockMedicines()
        {
            return _context.Pharmacy.Where(p => p.Stock == 0).ToList();
        }
        public List<Pharmacy> GetExpiringMedicines(int daysBeforeExpiry)
        {
            var expiryDate = DateTime.Now.AddDays(daysBeforeExpiry);
            return _context.Pharmacy.Where(p => p.ExpiryDate <= expiryDate).ToList();
        }
        public int CalculateInventoryValue()
        {
            return _context.Pharmacy.Sum(p => p.Stock * p.UnitPrice);
        }


        // GET: Pharmacies
        public async Task<IActionResult> Index()
        {
              return _context.Pharmacy != null ? 
                          View(await _context.Pharmacy.ToListAsync()) :
                          Problem("Entity set 'ApplicationDBContext.Pharmacy'  is null.");
        }

        // GET: Pharmacies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Pharmacy == null)
            {
                return NotFound();
            }

            var pharmacy = await _context.Pharmacy
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pharmacy == null)
            {
                return NotFound();
            }

            return View(pharmacy);
        }

        // GET: Pharmacies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pharmacies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MedicineName, Batch, Manufacturer, ExpiryDate, Stock, Supplier, UnitPrice, Total, Id")]Pharmacy pharmacy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pharmacy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pharmacy);
        }

        // GET: Pharmacies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Pharmacy == null)
            {
                return NotFound();
            }

            var pharmacy = await _context.Pharmacy.FindAsync(id);
            if (pharmacy == null)
            {
                return NotFound();
            }
            return View(pharmacy);
        }

        // POST: Pharmacies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Batch,Manufacturer,ExpiryDate,Stock,MedicinePrescription,DateDispendsed,UnitPrice,Total,Id")] Pharmacy pharmacy)
        {
            if (id != pharmacy.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pharmacy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PharmacyExists(pharmacy.Id))
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
            return View(pharmacy);
        }

        // GET: Pharmacies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Pharmacy == null)
            {
                return NotFound();
            }

            var pharmacy = await _context.Pharmacy
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pharmacy == null)
            {
                return NotFound();
            }

            return View(pharmacy);
        }

        // POST: Pharmacies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Pharmacy == null)
            {
                return Problem("Entity set 'ApplicationDBContext.Pharmacy'  is null.");
            }
            var pharmacy = await _context.Pharmacy.FindAsync(id);
            if (pharmacy != null)
            {
                _context.Pharmacy.Remove(pharmacy);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PharmacyExists(int id)
        {
          return (_context.Pharmacy?.Any(e => e.Id == id)).GetValueOrDefault();
        }
        //public IActionResult GenerateReport()
        //{
        //    byte[] reportBytes = ReportGenerator.GeneratePharmacyInventoryReport();

        //    // Assuming you want to download the report as a PDF file
        //    return File(reportBytes, "application/pdf", "PharmacyInventoryReport.pdf");
        //}
    }
}
