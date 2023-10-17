using HospitalManagement.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace HospitalManagement.ViewModels
{
    public class LabRequestViewModel
    {
        public int Id { get; set; } // Assuming you have an Id for the lab request
        public int PatientId { get; set; }
        public string TestName { get; set; }
        public string TestDescription { get; set; }
        public DateTime? TestDate { get; set; }
        public string Priority { get; set; }
        public string RequestedBy { get; set; }
        public Patients Patient { get; set; }
        public string RequestedTests { get; set; }

        public LabRequest? LabRequest { get; set; }
        public Laboratory? Laboratory { get; set; }
        public List<LabTest> AvailableTests { get; set; }
        public Dictionary<int, bool> SelectedTests { get; set; }

        public LabRequestViewModel()
        {
            AvailableTests = new List<LabTest>();
        }
        [Display(Name = "Selected Test")]
        public List<int> SelectedTestIds { get; set; }
    }
}
