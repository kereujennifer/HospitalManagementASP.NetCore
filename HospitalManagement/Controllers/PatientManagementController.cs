using HospitalManagement.Data;
using HospitalManagement.Models;
using HospitalManagement.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> MedicalHistory(MedicalHistory model)
        {
            if (ModelState.IsValid)
            {
                // Save the medical history to the database
                context.MedicalHistories.Add(model);
                await context.SaveChangesAsync();

                return RedirectToAction("Details", "PatientManagement", new { id = model.PatientId });
            }

            // If the model state is invalid, return the view with the invalid model
            return View(model);
        }

        public async Task<IActionResult> Prescriptions(int patientId)
        {
            // Retrieve the patient's prescriptions from the database
            var prescriptions = new Prescription();
            var patient = await context.Patient.FirstOrDefaultAsync(p => p.Id == patientId);

            if (patient != null)
            {
                prescriptions.Patient = patient;

                // Save the lab results to the database
                context.Prescriptions.Add(prescriptions);
                await context.SaveChangesAsync();
            }
            return View(prescriptions);
        }

        public async Task<IActionResult> VitalSigns(int patientId)
        {
            // Retrieve the patient's vital signs from the database
            var vitalSigns = new VitalSigns();
            var patient = await context.Patient.FirstOrDefaultAsync(p => p.Id == patientId);
            if (patient != null)
            {
                vitalSigns.Patient = patient;

                // Save the lab results to the database
                context.VitalSigns.Add(vitalSigns);
                await context.SaveChangesAsync();
            }
            // Pass the vital signs to the view
            return View(vitalSigns);
          
        }

        public async Task<IActionResult> LabResults(int patientId)
        {
            // Retrieve the patient's lab results from the database
var labResults = new LabResults();
var patient = await context.Patient.FirstOrDefaultAsync(p => p.Id == patientId);

if (patient != null)
{
    labResults.Patient = patient;

    // Save the lab results to the database
    context.LabResults.Add(labResults);
    await context.SaveChangesAsync();
}

             // Pass the lab results to the view
                return View(labResults);
           
        }
    }
}
