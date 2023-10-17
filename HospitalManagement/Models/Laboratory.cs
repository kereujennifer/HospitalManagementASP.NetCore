using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagement.Models
{
    public class Laboratory
    {
        public int Id { get; set; }
        //public string? RegistrationNumber { get; set; }
        public string? PatientName { get; set; }
        public string? TestPerformedBy { get; set; }
        public string? Report { get; set; }
        public string? Test { get; set; }
        public string? TestName { get; set; }

        public string? TestType { get; set; }
        public string? Equipment { get; set; }
        public Patients? Patient { get; set; }

        public DateTime OrderDate { get; set; }

        public string? Priority { get; set; }

        public string? SpecimenCollectionDetails { get; set; }
        public string? SpecimenType { get; set; }
        public int TestOrderId { get; set; }
        public string? Label { get; set; }
        public DateTime CollectionDate { get; set; }
        public string? CollectionMethod { get; set; }

        public string? CollectionSite { get; set; }
        public string? CollectionInstructions { get; set; }
        public int SpecimenId { get; set; }
        public decimal ResultValue { get; set; }
        public DateTime ResultDate { get; set; }
        public int DoctorId { get; set; }
        public int LabRequestId { get; set; }

        public int LabResultId { get; set; }
        public List<LabRequest>? LabRequest { get; set; }







    }
}

