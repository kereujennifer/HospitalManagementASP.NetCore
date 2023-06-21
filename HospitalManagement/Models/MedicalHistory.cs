using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace HospitalManagement.Models
{
	public class MedicalHistory
	{
        public int Id { get; set; }

        
        public string? OnMedications { get; set; }
        public string?Allergies { get; set; }

        public string? PastMedicalConditions { get; set; }

        public string? SurgicalProcedures { get; set; }




        public string RegistrationNumber { get; set; } // Foreign key
        public Patients Patient { get; set; }

        public string? FamilyHistory { get; set; }

        public string? SocialHistory { get; set; }

        public MedicalHistory()
        {
            // Set the registration number to an empty string by default
            RegistrationNumber = string.Empty;
        }
    }
}
