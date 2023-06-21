namespace HospitalManagement.Models
{
    public class Prescription
    {
        public int Id { get; set; } 
        public string? MedicinePrescription { get; set; }
        public String? Doctor { get; set; }
        public DateTime? DateDispensed { get; set; }
        public Doctors Doctors { get; set; }
        public string RegistrationNumber { get; set; } // Foreign key
        public Patients Patient { get; set; }

    }
}
