using HospitalManagement.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace HospitalManagement.Data
{
    public class ApplicationDBContext : IdentityDbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Patients> Patient{ get; set; }

        public DbSet<Doctors> Doctors { get; set; }

        public DbSet<Laboratory> Laboratory { get; set; }

        public DbSet<Pharmacy> Pharmacy { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<Bill> Bills { get; set; }
        public DbSet<Insurance> Insurance { get; set; }
        public DbSet<Medicine> Medicine { get; set; }
        public DbSet<PatientReport> PatientReports { get; set; }

        public DbSet<MedicineReport> MedicineReports { get; set; }

        public DbSet<HospitalManagement.Models.Supplier>? Supplier { get; set; }

    }

}
