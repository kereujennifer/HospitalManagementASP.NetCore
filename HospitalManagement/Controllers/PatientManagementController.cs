using HospitalManagement.Data;
using HospitalManagement.Models;
using HospitalManagement.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagement.Controllers
{
    public class PatientManagementController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;
        private readonly ApplicationDBContext context;

        public PatientManagementController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager, ApplicationDBContext context)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.context = context;
        }

        [HttpGet]
            public async Task<IActionResult> Prescriptions(int patientId)
            {
            
            var patient = await context.Patient.FirstOrDefaultAsync(p => p.Id == patientId);

            if (patient != null)
            {
                var doctors = await context.Doctors.ToListAsync();

                var model = new Prescription
                {
                    PatientId = patient.Id,
                    Patient = patient


                };
                ViewBag.Doctors = doctors; // Add this line

                return View(model);
            }

            // Handle case when patient is not found
            return RedirectToAction("PatientNotFound", "Error");
        }
        [HttpPost]
        public async Task<IActionResult> Prescriptions(Prescription model, int patientId)
        {
            if (ModelState.IsValid)
            {
                var patient = await context.Patient.FirstOrDefaultAsync(p => p.Id == patientId);

                if (patient != null)
                {
                    // Retrieve the selected doctor from the database based on the doctor ID
                    var doctor = await context.Doctors.FirstOrDefaultAsync(d => d.DoctorId == model.DoctorsId);
                    ViewBag.Doctors = doctor;

                    if (doctor != null)
                    {
                        model.Patient = patient;
                        model.Doctors = doctor;

                        // Save the prescription to the database
                        context.Prescriptions.Add(model);
                        await context.SaveChangesAsync();
                    }
                    else
                    {
                        // Handle case when selected doctor does not exist
                        return RedirectToAction("DoctorNotFound", "Error");
                    }
                }

                return RedirectToAction("Details", "Patients", new { id = patientId });
            }

            return View(model);
        }

        [HttpGet]
public async Task<IActionResult> MedicalHistory(int patientId)
{
    var patient = await context.Patient.FirstOrDefaultAsync(p => p.Id == patientId);

    if (patient != null)
    {
        var model = new MedicalHistories
        {
            PatientId = patient.Id,
            Patient = patient
        };

        return View(model);
    }

    // Handle case when patient is not found
    return RedirectToAction("PatientNotFound", "Error");
}

[HttpPost]
public async Task<IActionResult> MedicalHistory(MedicalHistories model)
{
    if (ModelState.IsValid)
    {
        var patient = await context.Patient.FirstOrDefaultAsync(p => p.Id == model.PatientId);

        if (patient != null)
        {
            model.Patient = patient;
            context.MedicalHistories.Add(model);
            await context.SaveChangesAsync();

            return RedirectToAction("Details", "Patients", new { id = model.PatientId });
        }
    }

    // Handle case when model state is invalid or patient is not found
    return RedirectToAction("InvalidModelState", "Error");
}


        [HttpGet]
        public async Task<IActionResult> VitalSigns(int patientId)
        {
            var patient = await context.Patient.FirstOrDefaultAsync(p => p.Id == patientId);

            if (patient != null)
            {
                var model = new VitalSigns
                {
                    PatientId = patient.Id,
                    Patient = patient
                };

                return View(model);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> VitalSigns(VitalSigns model, int patientId)
        {
            if (ModelState.IsValid)
            {
                var patient = await context.Patient.FirstOrDefaultAsync(p => p.Id == patientId);

                if (patient != null)
                {
                    model.Patient = patient;
                    context.VitalSigns.Add(model);
                    await context.SaveChangesAsync();
                }

                return RedirectToAction("Details", "Patients", new { id = patientId });
            }

            return View(model);
        }



        [HttpGet]
        public async Task<IActionResult> LabResults(int patientId)
        {
            var patient = await context.Patient.FirstOrDefaultAsync(p => p.Id == patientId);

            if (patient != null)
            {
                var laboratories = await context.Laboratory.ToListAsync();
                var staff = await context.Staff.Where(s => s.DepartmentId ==3 ).ToListAsync();

                ViewBag.Laboratories = new SelectList(laboratories, "Id", "TestName");
                ViewBag.Staff = new SelectList(staff, "StaffId", "Name");

                var model = new LabResults
                {
                    PatientId = patient.Id,
                    Patient = patient
                };

                return View(model);
            }

            // Handle case when patient is not found
            return RedirectToAction("PatientNotFound", "Error");
        }


        [HttpPost]
        public async Task<IActionResult> LabResults(LabResults model, int patientId)
        {
            if (ModelState.IsValid)
            {
              
                var patient = await context.Patient.FirstOrDefaultAsync(p => p.Id == model.PatientId);

                if (patient != null)
                {
                    model.Patient = patient;

                    // Save the lab results to the database
                    context.LabResults.Add(model);
                    await context.SaveChangesAsync();
                }
                
                return RedirectToAction("Details", "Patients", new { id = model.PatientId });
            }

            // Retrieve the necessary data for dropdowns again
            var laboratories = await context.Laboratory.ToListAsync();
            var staff = await context.Staff.Where(s => s.DepartmentId == 3).ToListAsync();

            ViewBag.Laboratories = new SelectList(laboratories, "Id", "TestName");
            ViewBag.Staff = new SelectList(staff, "StaffId", "Name");

            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> LabRequest(int patientId)
        {
            var patient = await context.Patient.FirstOrDefaultAsync(p => p.Id == patientId);

            if (patient != null)
            {
                var model = new LabRequestViewModel
                {
                    PatientId = patient.Id,
                    Patient = patient,// Set the Patient property to the patient object
                     AvailableTests = await context.LabTest.ToListAsync(),
                    SelectedTests = new Dictionary<int, bool>() // Initialize the dictionary here
                };
                // Fetch the list of available tests and assign them to the model
                model.AvailableTests = await context.LabTest.ToListAsync();
                return View(model);
            }

            // Handle case when patient is not found
            return RedirectToAction("PatientNotFound", "Error");
        }
        [HttpPost]
        public IActionResult SendLabRequest(LabRequestViewModel labRequest)
        {
            if (ModelState.IsValid)
            {
               
                var patient = context.Patient.FirstOrDefault(p => p.Id == labRequest.Patient.Id);

                if (patient == null)
                {
                    // Handle case when patient is not found
                    return RedirectToAction("PatientNotFound", "Error");
                }
                var selectedTestIds = labRequest.SelectedTests
                .Where(kv => kv.Value)
                .Select(kv => kv.Key)
                .ToList();

                // Map the data from LabRequestViewModel to the LabRequest entity (database model)
                var labRequestEntity = new LabRequest
                {
                    Patient = patient, // Set the entire Patient object
                    PatientName= patient.FirstName,
                    RequestedTests = labRequest.RequestedTests,
                    RequestDate = DateTime.Now,
                    Status = "Pending", // Set an initial status for the lab request
                    //SelectedTest = selectedTestIds,

                    Requestedtest = selectedTestIds.Select(testId => context.LabTest.FirstOrDefault(test => test.Id == testId)).ToList()
                    // Add any other properties as needed
                };


                context.LabRequests.Add(labRequestEntity);
                context.SaveChanges();

                // Set LabRequestId for passing to Create action
                //var labRequestId = labRequestEntity.Id;

                // Redirect to the Create action in Laboratories controller
                //return RedirectToAction("Create", "Laboratories", new { labRequestId });

                // Redirect to the confirmation view or any other relevant action
                return RedirectToAction("LabRequestConfirmation");
            }

            // If the model state is invalid, return to the lab request form view to show validation errors
            return View("LabRequest", labRequest);
        }

        public IActionResult LabRequestConfirmation()
        {
            // This action can display a confirmation message or any other relevant information
            return View();
        }

    }
}