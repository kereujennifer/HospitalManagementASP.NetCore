using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace HospitalManagement.Models
{
    public class Patients 
    {
        public int Id { get; set; }
        
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
        //public int Age
        //{
        //    get
        //    {
        //        if (DateOfBirth.HasValue)
        //        {
        //            var today = DateTime.Today;
        //            var age = today.Year - DateOfBirth.Value.Year;

        //            // Check if the birthday has already occurred this year
        //            if (DateOfBirth.Value.Date > today.AddYears(-age))
        //            {
        //                age--;
        //            }

        //            return age;
        //        }

        //        return 0;
        //    }
        //}
        public int? Age { get; set; }

        public bool UnderEighteen
        {
            get { return Age < 18; }
        }
        public string? Gender { get; set; }
        public string? Prescription { get; set; }
        [Display(Name = "Date Dispensed")]

        public string? DateDispensed { get; set; }

        public string? Phone { get; set; }
        [Display(Name = " Employment Status")]

        public string? EmploymentStatus { get; set; }

        public string? Address { get; set; }
        public string? Email { get; set; }
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
        public string? WardNumber { get; set; }
        public string? FloorNumber { get; set; }
        public string? BedNumber { get; set; }
        public DateTime? CheckedInDate { get; set; }
        public string? PatientType { get; set; }
        public DateTime? CheckedOutDate { get; set; }
        public string? AssignedDoctor { get; set; }
        public int AssignedDoctorId { get; set; }

        public void AssignDoctor(string doctorName)
        {
            AssignedDoctor = doctorName;
        }

        public TimeSpan CalculateLengthOfStay()
        {
            if (CheckedOutDate.HasValue)
            {
                return (TimeSpan)(CheckedOutDate.Value - CheckedInDate);
            }
            else
            {
                return TimeSpan.Zero;
            }
        }

        public void Discharge()
        {
            CheckedOutDate = DateTime.Now;
        }

        public List<LabResults>? LabResults { get; set; }
        public List<MedicalHistories>? MedicalHistories { get; set; }
        public List<Prescription>? Prescriptions { get; set; }
        public List<VitalSigns>? VitalSigns { get; set; }
        public List<Doctors>? GetDoctors { get; set; }



    }
}