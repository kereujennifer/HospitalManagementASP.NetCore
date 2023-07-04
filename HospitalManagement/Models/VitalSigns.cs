namespace HospitalManagement.Models
{
    public class VitalSigns
    {

        public int Id { get; set; }
        public int PatientId { get; set; } // Foreign key
        public Patients? Patient { get; set; }
        public string? Weight{ get; set; }
        public string? Height { get; set; }
        public string? BloodPressure{ get; set; }
        public string?Temperature{ get; set; }
        public string?BMI { get; set; }




    }
}
