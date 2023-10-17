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
        public DbSet<Patients>? Patient{ get; set; }

        public DbSet<Doctors>? Doctors { get; set; }

        public DbSet<Laboratory>? Laboratory { get; set; }

        public DbSet<Pharmacy>? Pharmacy { get; set; }
        public DbSet<Appointment>? Appointments { get; set; }

        public DbSet<Bill>? Bills { get; set; }
        public DbSet<Insurance>? Insurance { get; set; }
        public DbSet<Medicine>? Medicine { get; set; }
        public DbSet<PatientReport>? PatientReports { get; set; }

        public DbSet<MedicineReport>? MedicineReports { get; set; }

        public DbSet<HospitalManagement.Models.Supplier>? Supplier { get; set; }

        public DbSet<HospitalManagement.Models.Prescription>? Prescriptions{ get; set; }

        public DbSet<HospitalManagement.Models.VitalSigns>? VitalSigns { get; set; }

        public DbSet<MedicalHistories>? MedicalHistories { get; set; }

        public DbSet<HospitalManagement.Models.LabResults>? LabResults { get; set; }

        public DbSet<HospitalManagement.Models.OutPatient>? OutPatient { get; set; }
        public DbSet<HospitalManagement.Models.LabTest>? LabTest { get; set; }

        public DbSet<HospitalManagement.Models.LabTestCategory>? LabTestCategory { get; set; }
        public DbSet<HospitalManagement.Models.HospitalMngt>? HospitalMngt { get; set; }
        //public DbSet<HospitalManagement.Models.HospitalMngt.Bed>? Beds { get; set; }
        //public DbSet<HospitalManagement.Models.HospitalMngt.Ward>? Wards { get; set; }
        //public DbSet<HospitalManagement.Models.HospitalMngt.Room>? Rooms { get; set; }
        //public DbSet<HospitalManagement.Models.HospitalMngt.RoomType>? RoomTypes { get; set; }




        public DbSet<HospitalManagement.Models.LabRequest> LabRequests { get; set; }

        public DbSet<HospitalManagement.Models.Department> Department { get; set; }
        public DbSet<HospitalManagement.Models.Staff> Staff { get; set; }
      



        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Configure the relationship between Patients and Prescriptions
        //    modelBuilder.Entity<Prescription>()
        //        .HasOne(r => r.Patient)
        //        .WithMany(p => p.Prescriptions)
        //        .HasForeignKey(r => r.RegistrationNumber)
        //        .HasPrincipalKey(p => p.RegistrationNumber);



        //    // Configure the relationship between Patients and MedicalHistory
        //    modelBuilder.Entity<MedicalHistory>()
        //        .HasOne(m => m.Patient)
        //        .WithMany(p => p.MedicalHistories)
        //        .HasForeignKey(m => m.RegistrationNumber)
        //                        .HasPrincipalKey(p => p.RegistrationNumber);


        //    // Configure the relationship between Patients and LabResults
        //    modelBuilder.Entity<LabResults>()
        //        .HasOne(l => l.Patient)
        //        .WithMany(p => p.LabResults)
        //        .HasForeignKey(l => l.RegistrationNumber)
        //                        .HasPrincipalKey(p => p.RegistrationNumber);


        //    // Configure the relationship between Patients and VitalSigns
        //    modelBuilder.Entity<VitalSigns>()
        //        .HasOne(v => v.Patient)
        //        .WithMany(p => p.VitalSigns)
        //        .HasForeignKey(v => v.RegistrationNumber)
        //                        .HasPrincipalKey(p => p.RegistrationNumber);


        //    // Other configuration code...

        //    base.OnModelCreating(modelBuilder);
        //}

    }

}
