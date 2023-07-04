using HospitalManagement.Models;
using System.Net;
using HospitalManagement.Data;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.ViewModels
{
    public class PatientViewModel
    {
     
        public int Id { get; set; }
        public DateTime RegDate { get; set; }

        public string? FirstName { get; set; }

        public string? MiddleName { get; set; }
        public string? LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }
        public int Age { get; set; }
        public string? Gender { get; set; }
        public string? Prescription { get; set; }
        public string? DateDispensed { get; set; }

        public string? Phone { get; set; }
        public string? EmploymentStatus { get; set; }

        public string? Address { get; set; }
        public string? Email { get; set; }
        public bool UnderEighteen { get; set; }
        public string? ParentGuardianName { get; set; }
        public string? MaritalStatus { get; set; }

        public string? NextOfKin { get; set; }
        public string? NextOfKinName { get; set; }
        public string? NextOfKinAddress { get; set; }
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
        public string? PatientType { get; set; }
        public string RegistrationNumber { get; set; }
        public Patients Patient { get; set; }
        public List<MedicalHistories> MedicalHistories { get; set; } = new List<MedicalHistories>();
        public List<Prescription> Prescriptions { get; set; } = new List<Prescription>();
        public List<LabResults> LabResults { get; set; } = new List<LabResults>();
        public List<VitalSigns> VitalSigns { get; set; } = new List<VitalSigns>();


        
}

}
