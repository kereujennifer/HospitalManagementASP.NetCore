using Microsoft.AspNetCore.Identity;

namespace HospitalManagement.Models
{
    public class PatientReport
    {

       
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Diagnose { get; set; }
        public string? MedicineName { get; set; }
        public IdentityUser? Doctor { get; set; }
        public IdentityUser? Patient { get; set; }

        public ICollection<MedicineReport>? MedicineReport { get; set; }

    

    }
}
