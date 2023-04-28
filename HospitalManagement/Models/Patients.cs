using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Models
{
    public class Patients : HospitalMngt
    {
        public int RegistrationNumber { get; set; }
        public DateTime RegDate { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }

        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
		public int Age { get; set; }
		public string? Gender { get; set; }
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
		
	}
}
