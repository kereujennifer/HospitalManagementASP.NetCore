namespace HospitalManagement.Models
{
    public class LabRequestTest
    {
        public int Id { get; set; }
        public int LabRequestId { get; set; }
        public LabRequest LabRequest { get; set; }
        public int LabTestId { get; set; }
        public LabTest LabTest { get; set; }
    }

}
