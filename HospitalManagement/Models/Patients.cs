namespace HospitalManagement.Models
{
    public class Patients : HospitalMngt
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }

        public int Age { get; set; }
        public string? Gender { get; set; }

        public string? NextOfKin { get; set; }

        public string? NextOfKinPhone { get; set; }
        //public string? Medications { get; set; }
        //public string?Allergies { get; set; }
        //public string? MedicalCondition { get; set; }
        //public string? Weight { get; set; }
        //public string? Height { get; set; }
        //public string? BloodPressure { get; set; }
        //public string? Temprature { get; set; }
        //public string? BMI { get; set; }

    }
}
