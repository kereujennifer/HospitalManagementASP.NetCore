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
    public class HospitalMngtsController : Controller
    {
        private readonly ApplicationDBContext _context;

        public HospitalMngtsController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: HospitalMngts
        public async Task<IActionResult> Index()
        {
              return _context.HospitalMngt != null ? 
                          View(await _context.HospitalMngt.ToListAsync()) :
                          Problem("Entity set 'HospitalManagementFinalContext.HospitalMngt'  is null.");
        }

        // GET: HospitalMngts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.HospitalMngt == null)
            {
                return NotFound();
            }

            var hospitalMngt = await _context.HospitalMngt
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hospitalMngt == null)
            {
                return NotFound();
            }

            return View(hospitalMngt);
        }

        // GET: HospitalMngts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HospitalMngts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Wards,Beds,WardCategory,Floors,IsOccupied,Stations")] HospitalMngt hospitalMngt)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hospitalMngt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hospitalMngt);
        }

        // GET: HospitalMngts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.HospitalMngt == null)
            {
                return NotFound();
            }

            var hospitalMngt = await _context.HospitalMngt.FindAsync(id);
            if (hospitalMngt == null)
            {
                return NotFound();
            }
            return View(hospitalMngt);
        }

        // POST: HospitalMngts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Wards,Beds,WardCategory,Floors,IsOccupied,Stations")] HospitalMngt hospitalMngt)
        {
            if (id != hospitalMngt.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hospitalMngt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HospitalMngtExists(hospitalMngt.Id))
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
            return View(hospitalMngt);
        }

        // GET: HospitalMngts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.HospitalMngt == null)
            {
                return NotFound();
            }

            var hospitalMngt = await _context.HospitalMngt
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hospitalMngt == null)
            {
                return NotFound();
            }

            return View(hospitalMngt);
        }

        // POST: HospitalMngts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.HospitalMngt == null)
            {
                return Problem("Entity set 'HospitalManagementFinalContext.HospitalMngt'  is null.");
            }
            var hospitalMngt = await _context.HospitalMngt.FindAsync(id);
            if (hospitalMngt != null)
            {
                _context.HospitalMngt.Remove(hospitalMngt);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HospitalMngtExists(int id)
        {
          return (_context.HospitalMngt?.Any(e => e.Id == id)).GetValueOrDefault();
        }
        // GET: HospitalManagement/CreateWard
        public IActionResult CreateWard()
        {
            return View();
        }

        // POST: HospitalManagement/CreateWard
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateWard(HospitalMngt ward)
        {
            if (ModelState.IsValid)
            {
                // Add the logic to save the new ward to the database
                // For example: _context.HospitalMngt.Add(ward);
                //               _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ward);
        }
        // GET: HospitalManagement/CreateRoomType
        public IActionResult CreateRoomType()
        {
            return View();
        }

        // POST: HospitalManagement/CreateRoomType
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateRoomType(HospitalMngt roomType)
        {
            if (ModelState.IsValid)
            {
                // Add the logic to save the new room type to the database
                // For example: _context.HospitalMngt.Add(roomType);
                //               _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(roomType);
        }
        // GET: HospitalManagement/CreateBed
        public IActionResult CreateBed()
        {
            return View();
        }

        // POST: HospitalManagement/CreateBed
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateBed(HospitalMngt bed)
        {
            if (ModelState.IsValid)
            {
                // Add the logic to save the new bed to the database
                // For example: _context.HospitalMngt.Add(bed);
                //               _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bed);
        }
        public IActionResult UpdateHospitalInfo()
        {
            HospitalMngt hospitalInfo = _context.HospitalMngt.FirstOrDefault(); // Retrieve the first hospital information from the database (you can modify this query as per your requirements)

            // Check if the hospital information exists in the database
            if (hospitalInfo == null)
            {
                // If not found, you may redirect to the CreateHospitalInfo action instead
                return RedirectToAction("CreateHospitalInfo");
            }

            return View(hospitalInfo);
        }

        // POST: HospitalManagement/UpdateHospitalInfo
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateHospitalInfo(HospitalMngt hospitalInfo)
        {
            if (ModelState.IsValid)
            {
                // Update the hospital information in the database
                _context.HospitalMngt.Update(hospitalInfo);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hospitalInfo);
        }



    }
}
