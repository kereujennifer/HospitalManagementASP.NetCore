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
        public IdentityUser? Doctor { get; set; }
        public IdentityUser? Patient { get; set; }

        public ICollection<MedicineReport>? MedicineReport { get; set; }

    

    }
}
