namespace HospitalManagement.Models
{
	public class MedicalHistory
	{
        public int Id { get; set; }

        public string? Medications { get; set; }
        public string?Allergies { get; set; }
        public string? MedicalCondition { get; set; }
	}
}
