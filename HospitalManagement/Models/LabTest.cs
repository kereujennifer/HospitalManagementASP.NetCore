namespace HospitalManagement.Models
{
    
        public class LabTest
        {
            public int Id { get; set; }
            public string TestName { get; set; }
        public string Description { get; set; }
        public int? LabTestCategoryID { get; set; }
        public ICollection<LabRequest> LabRequests { get; set; }
        public LabTestCategory? LabTestCategory { get; set; }
        }

    
}
