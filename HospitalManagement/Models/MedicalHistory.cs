using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace HospitalManagement.Models
{
	public class MedicalHistories
	{
        public int Id { get; set; }
        public int PatientId { get; set; }


        public string? OnMedications { get; set; }
        public string?Allergies { get; set; }

        public string? PastMedicalConditions { get; set; }

        public string? SurgicalProcedures { get; set; }




        public Patients? Patient { get; set; }

        public string? FamilyHistory { get; set; }

        public string? SocialHistory { get; set; }

       
    }
}
