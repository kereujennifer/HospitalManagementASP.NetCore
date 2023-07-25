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
    public class PatientsController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly RegistrationNumberGenerator _registrationNumberGenerator;

        public PatientsController(ApplicationDBContext context)
        {
            _context = context;
            _registrationNumberGenerator = new RegistrationNumberGenerator();
            Patients.RegistrationNumberCounter = 0001;
        }
        public int CalculateAge(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;

            // Check if the birthday has already occurred this year
            if (dateOfBirth.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
        // GET: Patients
        public async Task<IActionResult> Index()
        {
              return _context.Patient != null ? 
                          View(await _context.Patient.ToListAsync()) :
                          Problem("Entity set 'ApplicationDBContext.Patients'  is null.");

        }

        // GET: Patients/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient = await _context.Patient
                .FirstOrDefaultAsync(m => m.Id == id);

            if (patient == null)
            {
                return NotFound();
            }

            var viewModel = new PatientViewModel
            {
                Patient = patient,
                RegistrationNumber = patient.RegistrationNumber
            };

            viewModel.MedicalHistories = await _context.MedicalHistories
                .Where(m => m.Patient.Id == id)
                .ToListAsync();

            viewModel.Prescriptions = await _context.Prescriptions
                .Where(r => r.Patient.Id == id)
                .ToListAsync();

            viewModel.LabResults = await _context.LabResults
                .Where(l => l.Patient.Id == id)
                .ToListAsync();

            viewModel.VitalSigns = await _context.VitalSigns
                .Where(v => v.Patient.Id == id)
                .ToListAsync();

            return View(viewModel);
        }


        //public async Task<IActionResult> Details(string registrationNumber)
        //{
        //    if (string.IsNullOrEmpty(registrationNumber))
        //    {
        //        return NotFound();
        //    }

        //    var patient = await _context.Patient.FirstOrDefaultAsync(m => m.RegistrationNumber == registrationNumber);

        //    if (patient == null)
        //    {
        //        return NotFound();
        //    }

        //    var viewModel = new PatientViewModel
        //    {
        //        Patient = patient,
        //        RegistrationNumber = patient.RegistrationNumber
        //    };

        //    viewModel.MedicalHistories = await _context.MedicalHistories
        //        .Where(m => m.Patient.RegistrationNumber == registrationNumber) // Compare with the foreign key
        //        .ToListAsync();

        //    viewModel.Prescriptions = await _context.Prescriptions
        //        .Where(r => r.Patient.RegistrationNumber == registrationNumber) // Compare with the foreign key
        //        .ToListAsync();

        //    viewModel.LabResults = await _context.LabResults
        //        .Where(l => l.Patient.RegistrationNumber == registrationNumber) // Compare with the foreign key
        //        .ToListAsync();

        //    viewModel.VitalSigns = await _context.VitalSigns
        //        .Where(v => v.Patient.RegistrationNumber == registrationNumber) // Compare with the foreign key
        //        .ToListAsync();

        //    return View(viewModel);
        //}



        // GET: Patients/Create
        public IActionResult Create()
        {
            List<Doctors> doctors = _context.Doctors.ToList();

            // Create a list of SelectListItems to be used for the dropdown
            List<SelectListItem> doctorList = doctors
                .Select(d => new SelectListItem { Value = d.DoctorId.ToString(), Text = d.LastName })
                .ToList();

            // Pass the doctorList to the view
            ViewBag.DoctorList = doctorList;

            return View();
        }
      

        // POST: Patients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RegistrationNumber,RegDate,DateOfBirth,Age,Gender,NextOfKin,NextOfKinPhone,Id,FirstName,LastName,Phone,Address,ParentGuardianName,AssignedDoctor,GetDoctors,MiddleName,NextOfKinName,NextOfKinAddress,NextOfKinPhone")] Patients patients)
        {
            if (ModelState.IsValid)
            {
                if (int.TryParse(Request.Form["AssignedDoctor"], out int doctorId))
                {
                    // Retrieve the selected doctor from the database
                    Doctors selectedDoctor = await _context.Doctors.FindAsync(doctorId);

                    // Assign the selected doctor ID to the patient
                    if (selectedDoctor != null)
                    {
                        patients.AssignedDoctorId = selectedDoctor.DoctorId;
                    }
                }
       
                // Retrieve the list of doctors from the database
                var doctors = await _context.Doctors.ToListAsync();

                // Create a list of SelectListItem objects
                var doctorList = doctors.Select(d => new SelectListItem
                {
                    Value = d.DoctorId.ToString(), // Use the doctor's ID as the value
                    Text = $"{d.DoctorId} - {d.LastName}" // Display the ID and last name
                }).ToList();

                // Pass the doctorList to the view
                ViewBag.DoctorList = doctorList;

                Patients.RegistrationNumberCounter++;
                patients.RegistrationNumber = $"HMS-{DateTime.Now.Year % 100}-{Patients.RegistrationNumberCounter:0000}";
                // Calculate age based on DateOfBirth
                patients.Age = CalculateAge(patients.DateOfBirth);


                // Show ParentGuardianName field if the age is less than 18
                if (patients.Age < 18)
                {
                    ModelState.AddModelError("ParentGuardianName", "The Parent/Guardian Name field is required for patients under 18 years old.");
                    return View(patients);
                }
                try
                {
                    _context.Update(patients);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PatientsExists(patients.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
                _context.Add(patients);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            

            return View(patients);
        }




        // GET: Patients/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Patient == null)
            {
                return NotFound();
            }

            var patients = await _context.Patient.FindAsync(id);
            if (patients == null)
            {
                return NotFound();
            }
            return View(patients);
        }

        // POST: Patients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RegistrationNumber,Age,Gender,NextOfKin,NextOfKinPhone,Id,FirstName,LastName,Phone,Address,AssignedDoctor")] Patients patients)
        {
            if (id != patients.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                // Calculate age based on DateOfBirth
                patients.Age = CalculateAge(patients.DateOfBirth);


                // Show ParentGuardianName field if the age is less than 18
                if (patients.Age < 18)
                {
                    ModelState.AddModelError("ParentGuardianName", "The Parent/Guardian Name field is required for patients under 18 years old.");
                    return View(patients);
                }
                try
                {
                    _context.Update(patients);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PatientsExists(patients.Id))
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
            return View(patients);
        }

        public int? CalculateAge(DateTime? dateOfBirth)
        {
            if (dateOfBirth.HasValue)
            {
                DateTime today = DateTime.Today;
                int age = today.Year - dateOfBirth.Value.Year;

                // Check if the birthday has already occurred this year
                if (dateOfBirth.Value.Date > today.AddYears(-age))
                {
                    age--;
                }

                return age;
            }

            return null; // Return null for unknown age (null date of birth)
        }

        // GET: Patients/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Patient == null)
            {
                return NotFound();
            }

            var patients = await _context.Patient
                .FirstOrDefaultAsync(m => m.Id == id);
            if (patients == null)
            {
                return NotFound();
            }

            return View(patients);
        }

        // POST: Patients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Patient == null)
            {
                return Problem("Entity set 'ApplicationDBContext.Patients'  is null.");
            }
            var patients = await _context.Patient.FindAsync(id);
            if (patients != null)
            {
                _context.Patient.Remove(patients);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PatientsExists(int id)
        {
          return (_context.Patient?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
