using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace HospitalManagement.Models
{
    public class Patients : HospitalMngt
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
        public List<LabResults>? LaboratoryResults { get; set; }
        public List<MedicalHistory>? MedicalHistories { get; set; }
        public List<Prescription>? Prescriptions { get; set; }
        public List<VitalSigns>? VitalSigns { get; set; }




    }
}
