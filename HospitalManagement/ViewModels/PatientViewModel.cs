namespace HospitalManagement.ViewModels
{
    public class PatientViewModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public int? Age { get; set; }


        public string? Mobile { get; set; }

        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Allergies { get; set; }
        public string? CurrentMedication { get; set; }
    }
}
