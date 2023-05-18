using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class OutPatient : HospitalMngt
    {
        public string? RegistrationNumber { get; set; }
        [Display(Name = "Registration Date")]
        public static int RegistrationNumberCounter { get; set; }

        public DateTime RegDate { get; set; }
        [Display(Name = "First Name")]

        public string? FirstName { get; set; }
        [Display(Name = " Middle Name")]

        public string? MiddleName { get; set; }
        [Display(Name = " Last Name")]

        public string? LastName { get; set; }
        [Display(Name = " Date Of Birth")]

        public DateTime? DateOfBirth { get; set; }
        public int Age { get; set; }
        public string? Gender { get; set; }
        public string? Phone { get; set; }
        [Display(Name = " Employment Status")]

        public string? EmploymentStatus { get; set; }

        public string? Address { get; set; }
        public string? Email { get; set; }
        public bool UnderEighteen { get; set; }
        [Display(Name = " Parent/Guardian Name")]

        public string? ParentGuardianName { get; set; }
        [Display(Name = " Marital Status")]

        public string? MaritalStatus { get; set; }

        [Display(Name = "Next Of Kin ")]

        public string? NextOfKin { get; set; }
        [Display(Name = " Name")]

        public string? NextOfKinName { get; set; }
        [Display(Name = " Address")]


        public string? NextOfKinAddress { get; set; }
        [Display(Name = " Phone")]

        public string? NextOfKinPhone { get; set; }
        public string? Payment { get; set; }
        public string? Weight { get; set; }
        public string? Height { get; set; }
        public string? BloodPressure { get; set; }
        public string? Temprature { get; set; }
        public string? BMI { get; set; }
        public string? MedicinePrescription { get; set; }
        public string? Ward { get; set; }
        public string? Bed { get; set; }
        public string? BedCategory { get; set; }
        public string? Floor { get; set; }
        public string? AdmittingDoctor { get; set; }

        public string? Discharge { get; set; }

        public Patients? PatientName { get; set; }
        public DateTime? DateDispendsed { get; set; }
    }
}
