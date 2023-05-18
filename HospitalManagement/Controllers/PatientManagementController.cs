using HospitalManagement.Data;
using HospitalManagement.Models;
using HospitalManagement.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.EntityFrameworkCore;

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
        public IActionResult MedicalHistory()
        {
            return View();
        }
        public IActionResult Prescriptions()
        {
            return View();
        }
        public IActionResult VitalSigns()
        {
            return View();
        }
        public IActionResult LabResults()
        {
            return View();
        }
        public async Task<IActionResult> Index()
        {
            var viewModel = new PatientViewModel
            {
                MedicalHistories = await context.MedicalHistories.ToListAsync(),
                Prescriptions = await context.Prescriptions.ToListAsync(),
                LabResults = await context.LabResults.ToListAsync(),
                VitalSigns = await context.VitalSigns.ToListAsync()
            };

            return View(viewModel);
        }



        [HttpPost]
        public async Task<IActionResult> SaveMedicalHistory(MedicalHistory model)
        {
            if (ModelState.IsValid)
            {
                context.MedicalHistories.Add(model);
                await context.SaveChangesAsync();

                return RedirectToAction("Details", "Patients");
            }

            var viewModel = new PatientViewModel
            {
                MedicalHistories = await context.MedicalHistories.ToListAsync(),
                VitalSigns = await context.VitalSigns.ToListAsync(),
                LabResults = await context.LabResults.ToListAsync(),
                Prescriptions = await context.Prescriptions.ToListAsync(),
            };

            return View( viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> SaveLabResults(LabResults model)
        {
            if (ModelState.IsValid)
            {
                context.LabResults.Add(model);
                await context.SaveChangesAsync();

                return RedirectToAction("Details", "Patients");
            }


            var viewModel = new PatientViewModel
            {
                MedicalHistories = await context.MedicalHistories.ToListAsync(),
                VitalSigns = await context.VitalSigns.ToListAsync(),
                LabResults = await context.LabResults.ToListAsync(),
                Prescriptions = await context.Prescriptions.ToListAsync(),
            };

            return View("Details", viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> SavePrescription(Prescription model)
        {
            if (ModelState.IsValid)
            {
                context.Prescriptions.Add(model);
                await context.SaveChangesAsync();

                var patient = await context.Patient.FirstOrDefaultAsync();
                if (patient != null)
                {
                    string registrationNumber = patient.RegistrationNumber;
                    return RedirectToAction("Details", "Patients");
                }
            }

            var viewModel = new PatientViewModel
            {
                MedicalHistories = await context.MedicalHistories.ToListAsync(),
                VitalSigns = await context.VitalSigns.ToListAsync(),
                LabResults = await context.LabResults.ToListAsync(),
                Prescriptions = await context.Prescriptions.ToListAsync(),
            };

            return View( viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> SaveVitalSigns(VitalSigns model)
        {
            if (ModelState.IsValid)
            {
                context.VitalSigns.Add(model);
                await context.SaveChangesAsync();

                return RedirectToAction("Details", "Patients");
            }

            var viewModel = new PatientViewModel
            {
                MedicalHistories = await context.MedicalHistories.ToListAsync(),
                VitalSigns = await context.VitalSigns.ToListAsync(),
                LabResults = await context.LabResults.ToListAsync(),
                Prescriptions = await context.Prescriptions.ToListAsync(),
            };
            return View( viewModel);

        }

    }

}