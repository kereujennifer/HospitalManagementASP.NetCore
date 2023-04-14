namespace HospitalManagement.Models
{
    public class Prescription
    {
        public int Id { get; set; } 
        public string? MedicinePrescription { get; set; }
        public Patients? PatientName { get; set; }
        public Doctors? Doctor { get; set; }
        public DateTime? DateDispendsed { get; set; }
    }
}
