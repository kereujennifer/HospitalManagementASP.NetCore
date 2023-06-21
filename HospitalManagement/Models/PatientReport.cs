using Microsoft.AspNetCore.Identity;

namespace HospitalManagement.Models
{
    public class PatientReport
    {

       
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Diagnose { get; set; }
        public string? MedicineName { get; set; }
        public string? Weight { get; set; }
        public string? Height { get; set; }
        public string? BloodPressure { get; set; }
        public string? Temprature { get; set; }
        public string? BMI { get; set; }
        //public int DoctorId { get; set; }  // Foreign key to Doctor
        public IdentityUser Doctor { get; set; }  // Navigation property to Doctor

        public string RegistrationNumber { get; set; }  // Foreign key to Patient
        public IdentityUser Patient { get; set; }  // Navigation property to Patient


        public ICollection<MedicineReport>? MedicineReport { get; set; }

    

    }
}
