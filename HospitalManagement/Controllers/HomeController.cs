﻿using HospitalManagement.Data;
using HospitalManagement.Models;
using HospitalManagement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
namespace HospitalManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
		private readonly RoleManager<IdentityRole> roleManager;
		private readonly UserManager<IdentityUser> userManager;
		private readonly ApplicationDBContext context;
        private readonly SignInManager<IdentityUser> signInManager;

        public HomeController(ILogger<HomeController> logger, RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager, ApplicationDBContext context, SignInManager<IdentityUser> signInManager)
        {
            _logger = logger;
			this.roleManager = roleManager;
			this.userManager = userManager;
			this.context = context;
            this.signInManager = signInManager;
        }

        public IActionResult Dashboard()
        {
			var doctorCount = context.Doctors.ToList().Count;
			var patientCount = context.Patient.ToList().Count;
			var pharmacyCount = context.Pharmacy.ToList().Count;
			var laboratoryCount = context.Laboratory.ToList().Count;
			var appointmentSchedule = context.Appointments.ToList();
			var users = userManager.Users.ToList();
			var pharmacy = context.Pharmacy.ToList();
			var patients = context.Patient.ToList();
			var doctors = context.Doctors.ToList();



			var today = DateTime.Today;
			var endOfMonth = new DateTime(today.Year, today.Month, DateTime.DaysInMonth(today.Year, today.Month));
			var appointments = new List<Appointment>();
			for (var date = today; date <= endOfMonth; date = date.AddDays(1))
			{
				var dayOfWeek = date.DayOfWeek;
				if (dayOfWeek != DayOfWeek.Saturday && dayOfWeek != DayOfWeek.Sunday)
				{
					appointments.Add(new Appointment
					{
						Date = date,
						Description = $"Appointment on {date.ToShortDateString()}",
						Doctor = new List<Doctors> { context.Doctors.FirstOrDefault() },
						Patient = new List<Patients> { context.Patient.FirstOrDefault() },
					});
				}
			}


			var model = new DashboardVM
			{
				DoctorCount = doctorCount,
				PatientCount = patientCount,
				PharmacyCount = pharmacyCount,
				LaboratoryCount = laboratoryCount,
				Users = users,
				Pharmacy = pharmacy,
				Appointments = appointmentSchedule.Select(a => new Appointment
				{
					Id = a.Id,
					Date = a.Date,
					Description = a.Description,
					Doctor = a.Doctor,
					Patient = a.Patient
				}).ToList()

			};

			return View(model);
        }

   public IActionResult Index()
		{
			if (signInManager.IsSignedIn(User))
			{
                return RedirectToAction("Dashboard", "Home");

            }
			else
            {
                return View();
			}
		}


		public IActionResult Contact()
		{
			return View();
		}
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
