namespace HospitalManagement.Models
{
    public class LabRequest
    {
        public int Id { get; set; }
        public string? PatientName { get; set; }

        public Patients Patient { get; set; } // Navigation property for the associated Patient

        public string RequestedTests { get; set; }
        public DateTime RequestDate { get; set; }
        public string Status { get; set; } // e.g., "Pending," "In Progress," "Completed"
        public ICollection<LabTest> Requestedtest { get; set; }



        public List<Laboratory>? Laboratory { get; set; }
        public List<LabResults>? LabResults { get; set; }

    }


}
