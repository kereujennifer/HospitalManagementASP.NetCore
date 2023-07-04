namespace HospitalManagement.Models
{
    public class LabResults
    {
        public int Id { get; set; }
        public string? TestPerformed { get; set; }
        public string? TestPerformedBy { get; set; }
        public string? Report { get; set; }
        public int PatientId { get; set; } // Foreign key
        public Patients? Patient { get; set; }
    }
}
